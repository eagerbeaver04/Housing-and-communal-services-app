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
    public partial class Form2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form2()
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
            int adress = Convert.ToInt32(comboBox1.Text);
            string query = "DELETE FROM [Список домов] WHERE [Адрес дома] = " + adress;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            string query1 = $"DELETE FROM [Список квартир] WHERE [Адрес дома] = {adress}";
            OleDbCommand command2 = new OleDbCommand(query1, myConnection);
            command2.ExecuteNonQuery();

            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);

            MessageBox.Show("Данные о доме и квартирах в нем удалены!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);

        }
    }
}