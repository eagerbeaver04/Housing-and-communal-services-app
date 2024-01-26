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
    public partial class Form8 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form8()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Квитанция". При необходимости она может быть перемещена или удалена.
            this.квитанцияTableAdapter.Fill(this.zhkhDataSet.Квитанция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Финансы". При необходимости она может быть перемещена или удалена.
            this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 mounth1 = Convert.ToInt32(comboBox1.Text);
            Int32 mounth2 = Convert.ToInt32(comboBox2.Text);
            string type = "";
            type = Convert.ToString(textBox1.Text);
            Int32 adress = 0;
            adress = Convert.ToInt32(comboBox4.Text);

            string query = "SELECT COUNT(*) FROM [Финансы]";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            Int32 max_mounth = (Int32)command.ExecuteScalar();

            if (max_mounth >= mounth2 && mounth2 >= mounth1 && mounth1 > 0)
            {
                if (type != "")
                {
                    Int32 value = 0; Int32 value_abs = 0; Int32 counter = 0; Int32 paid_debt = 0; Int32 paid_debt_abs = 0;
                    string query1 = $"SELECT [" + type + "],[Статус],[Адрес дома],[Номер квартиры],[Отключение] FROM [Квитанция] WHERE [Месяц] >= @Mounth1 AND [Месяц] <= @Mounth2";
                    using (OleDbCommand command1 = new OleDbCommand(query1, myConnection))
                    {
                        command1.Parameters.AddWithValue("@Mounth1", mounth1);
                        command1.Parameters.AddWithValue("@Mounth2", mounth2);
                        OleDbDataReader reader1 = command1.ExecuteReader();
                        while (reader1.Read())
                        {
                            Int32 current_value = reader1.GetInt32(0);
                            Int32 status = reader1.GetInt32(1);
                            Int32 current_adress = reader1.GetInt32(2);
                            Int32 current_number = reader1.GetInt32(3);
                            Int32 off = reader1.GetInt32(4);
                            if (status == 1) paid_debt += current_value;
                            paid_debt_abs += current_value;

                            string query3 = $"Select [Газ] FROM [Список домов] WHERE [Адрес дома] = {current_adress}";
                            OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                            Int32 gas_avaliable = (Int32)command3.ExecuteScalar();
                            
                            counter++;
                            if (type == "Газ" && gas_avaliable == 0) counter--;
                            else if (type == "Горячая вода" && off == 1) counter--;
                        }
                    }
                    string query2 = $"SELECT [" + type + "] FROM [Финансы] WHERE [Месяц] >= @Mounth1 AND [Месяц] <= @Mounth2";
                    using (OleDbCommand command2 = new OleDbCommand(query2, myConnection))
                    {
                        command2.Parameters.AddWithValue("@Mounth1", mounth1);
                        command2.Parameters.AddWithValue("@Mounth2", mounth2);
                        OleDbDataReader reader2 = command2.ExecuteReader();
                        while (reader2.Read())
                        {
                            Int32 current_value2 = reader2.GetInt32(0);
                            if (current_value2 < 0) value += current_value2;
                            value_abs += current_value2;
                        }
                    }
                    Int32 final_abs = paid_debt_abs - value_abs;
                    Int32 final = paid_debt - value;
                    string str1 = String.Format("Финансовый отчет по услуге: {0}\nВсего оказано услуг: {1}\nДолжно быть отдано компаниям: {2}\nФактически отдано компаниям: {3}\nДолжно быть получено с людей: {4}\nФактически получено с людей: {5}\nОжидается прибыль: {6}\nТекущая прибыль: {7}\nВременой интервал от {8} до {9} месяца", type, counter, Math.Abs(value_abs), Math.Abs(value), Math.Abs(paid_debt_abs), Math.Abs(paid_debt), final_abs, final, mounth1, mounth2);
                    string path1 = String.Format("report_{0}_{1}_{2}.txt", type, mounth1, mounth2);
                    using (StreamWriter writer1 = new StreamWriter(path1, false))
                    {
                        writer1.WriteLineAsync(str1);
                    }
                    MessageBox.Show("Отчет сгенерирован!");
                }
                else if (adress != 0)
                {
                    string query3 = $"Select [Газ] FROM [Список домов] WHERE [Адрес дома] = {adress}";
                    OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                    Int32 gas_avaliable = (Int32)command3.ExecuteScalar();

                    Int32 gas = 0; Int32 gas_abs = 0; Int32 counter = 0; Int32 electro = 0; Int32 electro_abs = 0;
                    Int32 cold_water = 0; Int32 cold_water_abs = 0; Int32 hot_water = 0; Int32 hot_water_abs = 0;
                    string query1 = $"SELECT [Статус],[Электричество],[Холодная вода],[Горячая вода],[Газ],[Номер квартиры],[Отключение] FROM [Квитанция] WHERE [Месяц] >= {mounth1} AND [Месяц] <= {mounth2} AND [Адрес дома] = {adress} ";
                    using (OleDbCommand command1 = new OleDbCommand(query1, myConnection))
                    {
                        OleDbDataReader reader1 = command1.ExecuteReader();
                        while (reader1.Read())
                        {
                            Int32 status = reader1.GetInt32(0);
                            Int32 current_electro = reader1.GetInt32(1);
                            Int32 current_cold_water = reader1.GetInt32(2);
                            Int32 current_hot_water = reader1.GetInt32(3);
                            Int32 current_gas = reader1.GetInt32(4);
                            Int32 current_number = reader1.GetInt32(5);
                            Int32 off = reader1.GetInt32(6);                            

                            if (status == 1)
                            {
                                gas += current_gas;
                                cold_water += current_cold_water;
                                hot_water += current_hot_water;
                                electro += current_electro;
                            }
                            gas_abs += current_gas;
                            cold_water_abs += current_cold_water;
                            hot_water_abs += current_hot_water;
                            electro_abs += current_electro;
                            counter += 2;
                            if (current_hot_water != 0) counter++;
                            else if (off == 0) counter++;
                            if (current_gas != 0) counter++;
                            else if (gas_avaliable == 1) counter++;
                        }
                    }
                    int percent_comp = 95;
                    gas_abs = (Int32)((double)gas_abs * percent_comp / 100);
                    electro_abs = (Int32)((double)electro_abs * percent_comp / 100);
                    cold_water_abs = (Int32)((double)cold_water_abs * percent_comp / 100);
                    hot_water_abs = (Int32)((double)hot_water_abs * percent_comp / 100);
                    Int32 final_gas = -gas_abs + gas;
                    Int32 final_cold_water = -cold_water_abs + cold_water;
                    Int32 final_electro = -electro_abs + electro;
                    Int32 final_hot_water = -hot_water_abs + hot_water;
                    string str1 = String.Format("Финансовый отчет по дому: {0}\nВсего оказано услуг: {1}\nДолжно быть отдано компаниям по электричеству: {2}\nПолучено с людей по электричеству: {3}\nДолжно быть отдано компаниям по холодной воде: {4}\nПолучено с людей по холодной воде: {5}\nДолжно быть отдано компаниям по горячей воде: {6}\nПолучено с людей по горячей воде: {7}\nДолжно быть отдано компаниям по газу: {8}\nПолучено с людей по газу: {9}\nПрибыль по электричеству: {10}\nПрибыль по холодной воде: {11}\nПрибыль по горячей воде: {12}\nПрибыль по газу: {13}\nВременой интервал от {14} до {15} месяца ", adress, counter, Math.Abs(electro_abs), Math.Abs(electro), Math.Abs(cold_water_abs), Math.Abs(cold_water), Math.Abs(hot_water_abs), Math.Abs(hot_water), Math.Abs(gas_abs), Math.Abs(gas), final_electro, final_cold_water, final_hot_water, final_gas, mounth1, mounth2);
                    string path1 = String.Format("report_{0}_{1}_{2}.txt", adress, mounth1, mounth2);
                    using (StreamWriter writer1 = new StreamWriter(path1, false))
                    {
                        writer1.WriteLineAsync(str1);
                    }
                    MessageBox.Show("Отчет сгенерирован!");
                }
            }
            else MessageBox.Show("Неверны введены границы периода!");
        }
    }
}
