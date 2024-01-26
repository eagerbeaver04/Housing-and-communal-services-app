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
    public partial class Form7 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form7()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"Select [Долг], [Временной долг], [Имя], [Фамилия], [Отчество] FROM [Список квартир] WHERE [Долг] < {0} AND [Временной долг] >{0} AND [Временной долг] < {6}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            string name = ""; string surname = ""; string otch = "";
            Int32 debt = 0; Int32 time_debt = 0;
            int i = 0;
            while (reader.Read())
            {
                debt = reader.GetInt32(0);
                debt *= -1;
                time_debt = reader.GetInt32(1);
                name = reader.GetString(2);
                surname = reader.GetString(3);
                otch = reader.GetString(4);
                string path1 = String.Format("debtor_{0}.txt", i);
                string str1 = String.Format("Уведомление\nУважаемый {0} {1} {2}!\nИнформируем Вас о задолженности за оплату услуг ЖКХ за {3} месяца.\nПросим Вас погасить задолженность, которая составляет {4}\nС уважением, ЖКХ. ", surname, name, otch, time_debt, debt);
                using (StreamWriter writer1 = new StreamWriter(path1, false))
                {
                    writer1.WriteLineAsync(str1);
                }
                i++;
            }
            string query1 = $"Select [Долг], [Временной долг], [Имя], [Фамилия], [Отчество] FROM [Список квартир] WHERE [Долг] < {0} AND [Временной долг] >{5}";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            OleDbDataReader reader1 = command1.ExecuteReader();
            i = 0;
            while (reader1.Read())
            {
                debt = reader1.GetInt32(0);
                debt *= -1;
                time_debt = reader1.GetInt32(1);
                name = reader1.GetString(2);
                surname = reader1.GetString(3);
                otch = reader1.GetString(4);
                string path2 = String.Format("subpoena_for_debtor_{0}.txt", i);
                string str2 = String.Format("Уведомление\nУважаемый {0} {1} {2}!\nИнформируем Вас о задолженности за оплату услуг ЖКХ за {3} месяцев.\nВ связи с большим сроком неуплаты, Вам отключается горячая вода в квартире.\nТакже Вы будете вызваны в суд о взыыскании с Вас необходимой суммы\nдля уплаты долга, которая составляет {4}.\nС уважением, ЖКХ.", surname, name, otch, time_debt, debt);
                using (StreamWriter writer2 = new StreamWriter(path2, false))
                {
                    writer2.WriteLineAsync(str2);
                }
                i++;
            }
            MessageBox.Show("Уведомления успешно сгенерированы!");

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.Show();
        }
    }
}
