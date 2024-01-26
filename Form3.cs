using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Zhkh2
{
    public partial class Form3 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            int adress = Convert.ToInt32(comboBox1.Text);
            int number = Convert.ToInt32(comboBox3.Text);
            int square = Convert.ToInt32(comboBox2.Text);
            string Otch = comboBox4.Text;
            string Surname = comboBox5.Text;
            string Name = comboBox6.Text;
            int floor = Convert.ToInt32(comboBox7.Text);
            string Type = comboBox8.Text;
            bool gas = checkBox1.Checked;
            Int32 g;
            if (gas == true)
                g = 1;
            else
                g = 0;
            string query = "INSERT INTO [Список домов] ([Газ], [Адрес дома],  [Тип дома]) VALUES (" + g + "," + adress + ",'" + Type + "' )";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            string queryString2 = "SELECT MAX(ID) FROM [Список квартир]";
            using (OleDbCommand command1 = new OleDbCommand(queryString2, myConnection))
            {
                Int32 reader = (Int32)command1.ExecuteScalar();
                id = reader;
            }
            id++;
            string query1 = "INSERT INTO [Список квартир] ([ID], [Номер квартиры], [Адрес дома], [Площадь квартиры], [Этаж], [Имя], [Фамилия], [Отчество], [Долг]) VALUES (" + id + "," + number + "," + adress + "," + square + "," + floor + ",'" + Name + "','" + Surname + "','" + Otch + "'," + 0 + ")";
            OleDbCommand command2 = new OleDbCommand(query1, myConnection);
            command2.ExecuteNonQuery();
            MessageBox.Show("Данные о доме и квартирах внесены!");
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
        }
    }
}
