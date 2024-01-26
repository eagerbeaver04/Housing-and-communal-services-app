using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace Zhkh2
{
    public partial class Form6 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form6()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Финансы". При необходимости она может быть перемещена или удалена.
            this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Финансы". При необходимости она может быть перемещена или удалена.
            this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Квитанция". При необходимости она может быть перемещена или удалена.
            this.квитанцияTableAdapter.Fill(this.zhkhDataSet.Квитанция);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 adress = Convert.ToInt32(comboBox1.Text);
            Int32 number = Convert.ToInt32(comboBox2.Text);
            Int32 mounth = Convert.ToInt32(comboBox3.Text);
            Int32 sum = Convert.ToInt32(comboBox4.Text);

            string query = $"SELECT [ID],[Сумма],[Статус],[Электричество],[Холодная вода],[Горячая вода],[Газ] FROM [Квитанция] WHERE [Месяц] = {mounth} AND [Адрес дома] = {adress} AND [Номер квартиры] = {number}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            Int32 current_finance = 0;
            Int32 current_end = 0;
            if (reader.Read())
            {
                Int32 id = reader.GetInt32(0);
                Int32 debt = reader.GetInt32(1);
                Int32 status = reader.GetInt32(2);
                Int32 electro = reader.GetInt32(3);
                Int32 cold_water = reader.GetInt32(4);
                Int32 hot_water = reader.GetInt32(5);
                Int32 gas = reader.GetInt32(6);
                Int32 finance = electro + cold_water + hot_water + gas;
                if (status == 1 || debt == 0)
                    MessageBox.Show("Нет необходимости оплачивать!");
                else if (sum < debt)
                    MessageBox.Show("Недостаточно средств!");
                else
                {
                    string query1 = String.Format("UPDATE [Квитанция] SET [Статус] ={0} WHERE [Адрес дома] = {1} AND [Номер квартиры] = {2} AND [Месяц] = {3}", 1, adress, number, mounth);
                    OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                    command1.ExecuteNonQuery();
                    string query2 = $"Select [Долг], [Временной долг], [Отключение] FROM [Список квартир] WHERE [Адрес дома] = {adress} AND [Номер квартиры] = {number}";
                    OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                    OleDbDataReader reader2 = command2.ExecuteReader();
                    Int32 debt_1 = 0; Int32 time_debt = 0; Int32 off = 0;
                    if (reader2.Read())
                    {
                        debt_1 = reader2.GetInt32(0);
                        time_debt = reader2.GetInt32(1);
                        off = reader2.GetInt32(2);
                    }
                    if (time_debt > 0) time_debt--;
                    debt_1 += debt;
                    if (time_debt < 6) off = 0;
                    string query3 = String.Format("UPDATE [Список квартир] SET [Отключение] ={0}, [Долг] = {1}, [Временной долг] = {2} WHERE [Адрес дома] = {3} AND [Номер квартиры] = {4} ", off, debt_1, time_debt, adress, number);
                    OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                    command3.ExecuteNonQuery();

                    string query4 = $"Select [Прибыль],[Итог] FROM [Финансы] WHERE [Месяц] = {mounth}";
                    OleDbCommand command4 = new OleDbCommand(query4, myConnection);
                    OleDbDataReader reader4 = command4.ExecuteReader();
                    if (reader4.Read())
                    {
                        current_finance = reader4.GetInt32(0);
                        current_end = reader4.GetInt32(1);
                    }
                    current_finance += finance;
                    current_end += finance;

                    string query5 = String.Format("UPDATE [Финансы] SET [Прибыль] = {0}, [Итог] = {1} WHERE [Месяц] = {2}", current_finance, current_end, mounth);
                    OleDbCommand command5 = new OleDbCommand(query5, myConnection);
                    command5.ExecuteNonQuery();

                    //обновление данных в финансах
                    string query6 = "SELECT COUNT(*) FROM [Финансы]";
                    OleDbCommand command6 = new OleDbCommand(query6, myConnection);
                    Int32 max = (Int32)command6.ExecuteScalar();
                    if (mounth < max)
                    {
                        for (int i = mounth + 1; i <= max; i++)
                        {
                            string query7 = $"Select [Начальный капитал],[Итог] FROM [Финансы] WHERE [Месяц] = {i}";
                            OleDbCommand command7 = new OleDbCommand(query7, myConnection);
                            OleDbDataReader reader7 = command7.ExecuteReader();
                            Int32 start_capital; Int32 end_capital;
                            if (reader7.Read())
                            {
                                start_capital = reader7.GetInt32(0);
                                end_capital = reader7.GetInt32(1);
                                start_capital += finance;
                                end_capital += finance;
                                string query8 = String.Format("UPDATE [Финансы] SET [Начальный капитал] = {0}, [Итог] = {1} WHERE [Месяц] = {2}", start_capital, end_capital, i);
                                OleDbCommand command8 = new OleDbCommand(query8, myConnection);
                                command8.ExecuteNonQuery();
                            }
                        }
                    }
                    this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);

                    this.квитанцияTableAdapter.Fill(this.zhkhDataSet.Квитанция);

                    this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);

                    MessageBox.Show("Оплата за выбранный месяц произведена!");

                }

            }
        }
    }
}
