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
    public partial class Form9 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form9()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Финансы". При необходимости она может быть перемещена или удалена.
            this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Финансы". При необходимости она может быть перемещена или удалена.
            this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 mounth = Convert.ToInt32(comboBox1.Text);
            string type = Convert.ToString(textBox1.Text);
            if (type == "Электричество" || type == "Газ" || type == "Холодная вода" || type == "Горячая вода")
            {
                Int32 debt = 0; Int32 profit = 0; Int32 finance = 0;
                string query = $"SELECT [" + type + "],[Прибыль], [Итог] FROM [Финансы] WHERE [Месяц] = @Mounth";
                using (OleDbCommand command = new OleDbCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@Mounth", mounth);
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        debt = reader.GetInt32(0);
                        profit = reader.GetInt32(1);
                        finance = reader.GetInt32(2);
                    }
                    if (debt > 0)
                    {
                        if (finance > debt)
                        {
                            finance -= debt;
                            profit -= debt;
                            debt *= -1;
                            string query1 = String.Format("UPDATE [Финансы] SET [" + type + "] ={0}, [Прибыль] = {1}, [Итог] = {2} WHERE [Месяц] = {3}", debt, profit, finance, mounth);
                            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                            command1.ExecuteNonQuery();

                            string query2 = "SELECT COUNT(*) FROM [Финансы]";
                            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                            Int32 max = (Int32)command2.ExecuteScalar();

                            if (mounth < max)
                            {
                                for (int i = mounth + 1; i <= max; i++)
                                {
                                    string query3 = $"Select [Начальный капитал],[Итог] FROM [Финансы] WHERE [Месяц] = {i}";
                                    OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                                    OleDbDataReader reader3 = command3.ExecuteReader();
                                    Int32 start_capital; Int32 end_capital;
                                    if (reader3.Read())
                                    {
                                        start_capital = reader3.GetInt32(0);
                                        end_capital = reader3.GetInt32(1);
                                        start_capital += debt;
                                        end_capital += debt;
                                        string query4 = String.Format("UPDATE [Финансы] SET [Начальный капитал] = {0}, [Итог] = {1} WHERE [Месяц] = {2}", start_capital, end_capital, i);
                                        OleDbCommand command4 = new OleDbCommand(query4, myConnection);
                                        command4.ExecuteNonQuery();
                                    }
                                }

                                this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);

                                MessageBox.Show("Оплата по выбранной услуге произведена!");

                            }
                        }
                        else MessageBox.Show("Недостаточно средств на счете!");
                    }
                    else MessageBox.Show("Услуга уже оплачена!");
                }
            }
            else MessageBox.Show("Неверно введен тип услуги!");
        }
    }
}
