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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "debt.txt";
            string str = "Список должников:\n";
            OleDbCommand command = new OleDbCommand($"SELECT [Имя], [Фамилия], [Отчество],[Долг] FROM [Список квартир] WHERE [Долг]<0 ", myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Int32 debt = Math.Abs(reader.GetInt32(3));
                str += reader.GetString(1) + " " + reader.GetString(0) + " " + reader.GetString(2) + " - долг составляет:" + debt.ToString() + "\n";
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLineAsync(str);
            }
            MessageBox.Show("Список должников успешно сгенерирован!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Show();
        }

       
        private void button8_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Owner = this;
            f9.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);

        }
    }
}
