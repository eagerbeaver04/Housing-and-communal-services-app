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
    public partial class Form4 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Показания_счетчика". При необходимости она может быть перемещена или удалена.
            this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adress = Convert.ToInt32(comboBox1.Text);
            int number = Convert.ToInt32(comboBox2.Text);
            int mounth = Convert.ToInt32(comboBox3.Text);
            int cold_water = Convert.ToInt32(comboBox4.Text);
            int hot_water = Convert.ToInt32(comboBox5.Text);
            int electro = Convert.ToInt32(comboBox6.Text);
            int gas = Convert.ToInt32(comboBox7.Text);

            string queryString = "SELECT MAX(ID) FROM [Показания счетчика]";
            int id = 0;
            using (OleDbCommand command1 = new OleDbCommand(queryString, myConnection))
            {
                Int32 reader = (Int32)command1.ExecuteScalar();
                id = reader;
            }
            id++;
            string query = "INSERT INTO [Показания счетчика] ([ID], [Адрес дома], [Номер квартиры], [Электричество], [Холодная вода], [Горячая вода], [Газ], [Месяц]) VALUES (" + id + "," + adress + "," + number + "," + electro + "," + cold_water + "," + hot_water + "," + gas + "," + mounth + ")";
            OleDbCommand command2 = new OleDbCommand(query, myConnection);
            command2.ExecuteNonQuery();
            this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);
            MessageBox.Show("Данные о показаниях счетчика внесены!");
        }
    }
}
