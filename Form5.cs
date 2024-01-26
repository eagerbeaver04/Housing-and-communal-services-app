using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Zhkh2
{
    public partial class Form5 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Zhkh.mdb";
        private OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Финансы". При необходимости она может быть перемещена или удалена.
            this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.zhkhDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet._поставщик___тариф". При необходимости она может быть перемещена или удалена.
            this.поставщик___тарифTableAdapter.Fill(this.zhkhDataSet._поставщик___тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Показания_счетчика". При необходимости она может быть перемещена или удалена.
            this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Коэффициент". При необходимости она может быть перемещена или удалена.
            this.коэффициентTableAdapter.Fill(this.zhkhDataSet.Коэффициент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Финансы". При необходимости она может быть перемещена или удалена.
            this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.zhkhDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet._поставщик___тариф". При необходимости она может быть перемещена или удалена.
            this.поставщик___тарифTableAdapter.Fill(this.zhkhDataSet._поставщик___тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Коэффициент". При необходимости она может быть перемещена или удалена.
            this.коэффициентTableAdapter.Fill(this.zhkhDataSet.Коэффициент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Показания_счетчика". При необходимости она может быть перемещена или удалена.
            this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Показания_счетчика". При необходимости она может быть перемещена или удалена.
            this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Коэффициент". При необходимости она может быть перемещена или удалена.
            this.коэффициентTableAdapter.Fill(this.zhkhDataSet.Коэффициент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet._поставщик___тариф". При необходимости она может быть перемещена или удалена.
            this.поставщик___тарифTableAdapter.Fill(this.zhkhDataSet._поставщик___тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.zhkhDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.zhkhDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet._поставщик___тариф". При необходимости она может быть перемещена или удалена.
            this.поставщик___тарифTableAdapter.Fill(this.zhkhDataSet._поставщик___тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_домов". При необходимости она может быть перемещена или удалена.
            this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Список_квартир". При необходимости она может быть перемещена или удалена.
            this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Показания_счетчика". При необходимости она может быть перемещена или удалена.
            this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zhkhDataSet.Квитанция". При необходимости она может быть перемещена или удалена.
            this.квитанцияTableAdapter.Fill(this.zhkhDataSet.Квитанция);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mounth = Convert.ToInt32(comboBox1.Text);
            int average_electro = 10;
            int average_gas = 10;
            int average_cold_water = 10;
            int average_hot_water = 10;
            int percent_comp = 95;
            int percent2_comp = 100 - percent_comp;
            int percent_zhkh = 5;

            Int32 profit = 0;
            Int32 own_profit = 0;
            Int32 loses = 0;
            Int32 start_capital = 20000;
            Int32 number_services = 0;

            Int32 sum_electro = 0;
            Int32 sum_gas = 0;
            Int32 sum_cold_water = 0;
            Int32 sum_hot_water = 0;
            string queryStr = "SELECT COUNT(*) FROM [Поставщики]";
            Int32 max;
            OleDbCommand commandstr = new OleDbCommand(queryStr, myConnection);
            max = (Int32)commandstr.ExecuteScalar();

            Int32[] rate = new Int32[max];

            for (Int32 i = 1; i <= max; i++)
            {
                string querystr2 = $"SELECT [тариф] FROM [Поставщики] Where [ID поставщика] = {i}";
                OleDbCommand commandstr2 = new OleDbCommand(querystr2, myConnection);
                rate[i - 1] = (Int32)commandstr2.ExecuteScalar();
            }

            string query = $"SELECT [ID] FROM [Квитанция] WHERE [Месяц] = {mounth}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
                MessageBox.Show("Квитанции за выбранный месяц уже загружены!");
            else
            {
                string query1 = "Select [ID] FROM [Список квартир]";
                OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                OleDbDataReader reader1 = command1.ExecuteReader();

                string queryStr3 = "SELECT COUNT(*) FROM [Квитанция]";
                OleDbCommand commandstr3 = new OleDbCommand(queryStr3, myConnection);
                Int32 id_0;
                id_0 = (Int32)commandstr3.ExecuteScalar();

                while (reader1.Read())
                {
                    Int32 sum = 0;
                    Int32 sum2 = 0;
                    Int32 sum1 = 0;
                    Int32 id;
                    id = reader1.GetInt32(0);
                    Int32 id_cur = id + id_0;
                    string query2 = $"Select [Адрес дома], [Номер квартиры],[Долг],[Этаж], [Площадь квартиры],[Временной долг], [Отключение] FROM [Список квартир] WHERE [ID] = {id}";
                    OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                    OleDbDataReader reader2 = command2.ExecuteReader();
                    Int32 adress = 0; Int32 number = 0; Int32 debt = 0; Int32 floor = 0; Int32 square = 0; Int32 time_debt = 0; Int32 flag = 0;
                    while (reader2.Read())
                    {
                        adress = reader2.GetInt32(0);
                        number = reader2.GetInt32(1);
                        debt = reader2.GetInt32(2);
                        floor = reader2.GetInt32(3);
                        square = reader2.GetInt32(4);
                        time_debt = reader2.GetInt32(5);
                        flag = reader2.GetInt32(6);
                    }
                    string query3 = $"Select [Тип дома], [Газ] FROM [Список домов] WHERE [Адрес дома] = {adress}";
                    OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                    OleDbDataReader reader3 = command3.ExecuteReader();
                    string type = ""; Int32 gas_avaliable = 0;
                    while (reader3.Read())
                    {
                        type = reader3.GetString(0);
                        gas_avaliable = reader3.GetInt32(1);
                    }

                    string query4 = $"Select [Коэффициент] FROM [Коэффициент] WHERE [Тип дома] = '{type}'";
                    Int32 koef = 0;
                    using (OleDbCommand command4 = new OleDbCommand(query4, myConnection))
                    {
                        OleDbDataReader reader4 = command4.ExecuteReader();
                        while (reader4.Read())
                        {
                            koef = reader4.GetInt32(0);
                        }
                        reader4.Close();
                    }
                    string query5 = $"Select [Электричество], [Холодная вода], [Горячая вода], [Газ] FROM [Показания счетчика] WHERE [Месяц] = {mounth} AND [Адрес дома] = {adress} AND [Номер квартиры] ={number}";
                    OleDbCommand command5 = new OleDbCommand(query5, myConnection);
                    OleDbDataReader reader5 = command5.ExecuteReader();
                    Int32 hot_water = average_hot_water; Int32 gas = average_gas;
                    Int32 electro = average_electro; Int32 cold_water = average_cold_water;
                    if (reader5.Read())
                    {
                        electro = reader5.GetInt32(0);
                        cold_water = reader5.GetInt32(1);
                        hot_water = reader5.GetInt32(2);
                        gas = reader5.GetInt32(3);
                    }
                    Int32 electro_value = rate[0] * electro * koef;
                    electro_value /= 10;
                    sum_electro += electro_value;

                    Int32 cold_water_value = rate[1] * cold_water * koef;
                    cold_water_value /= 10;
                    sum_cold_water += cold_water_value;

                    Int32 hot_water_value = rate[2] * hot_water * koef;
                    hot_water_value /= 10;
                    sum_hot_water += hot_water_value;

                    if (flag == 1)
                    {
                        hot_water_value = 0;
                        number_services--;
                    }
                    Int32 gas_value = rate[3] * gas * gas_avaliable * koef;
                    gas_value /= 10;
                    sum_gas += gas_value;

                    sum1 += electro_value + cold_water_value + hot_water_value + gas_value;
                    number_services += 4;

                    if (gas_avaliable == 0) number_services--;

                    double mult1 = (double)sum1;
                    loses += (Int32)((double)percent_comp * mult1 / 100);
                    profit += (Int32)((double)percent2_comp * mult1 / 100);

                    Int32 current;
                    for (int i = 4; i < max; i++)
                    {
                        current = 1;
                        if (floor == 1 && i == 8) current = 0;
                        if (i == 5) current *= square;
                        sum2 += current * rate[i];
                    }
                    double mult = (double)koef / 10;
                    mult *= (double)sum2;
                    sum2 = (Int32)mult;

                    profit += (Int32)(mult * (double)percent_zhkh / 100);
                    own_profit += (Int32)(mult * (double)percent_zhkh / 100);

                    sum = sum1 + sum2;
                    debt -= sum;

                    time_debt++;
                    if (time_debt >= 6) flag = 1;
                    else flag = 0;
                    string query6 = String.Format("UPDATE [Список квартир] SET [Долг] ={0} ,[Временной долг] ={1} ,[Отключение]={2}  WHERE [ID] = {3} ", debt, time_debt, flag, id);
                    OleDbCommand command6 = new OleDbCommand(query6, myConnection);
                    command6.ExecuteNonQuery();

                    string query7 = "INSERT INTO [Квитанция] ([ID], [Адрес дома], [Номер квартиры], [Статус], [Сумма], [Месяц],[Электричество],[Холодная вода],[Горячая вода],[Газ],[Отключение]) VALUES (" + id_cur + "," + adress + "," + number + "," + 0 + "," + sum + "," + mounth + "," + electro_value + "," + cold_water_value + "," + hot_water_value + "," + gas_value + "," + flag + ")";
                    OleDbCommand command7 = new OleDbCommand(query7, myConnection);
                    command7.ExecuteNonQuery();
                }
                MessageBox.Show("Данные о квитанциях внесены!");

                if (mounth != 1)
                {
                    string query8 = $"Select [Итог] FROM [Финансы] WHERE [Месяц] = {mounth - 1}";
                    using (OleDbCommand command8 = new OleDbCommand(query8, myConnection))
                    {
                        start_capital = (Int32)command8.ExecuteScalar();
                    }
                }
                //Int32 end_capital = start_capital - loses;
                Int32 end_capital = start_capital + own_profit;
                sum_electro = (Int32)((double)sum_electro * (double)percent_comp / 100);
                sum_gas = (Int32)((double)sum_gas * (double)percent_comp / 100);
                sum_cold_water = (Int32)((double)sum_cold_water * (double)percent_comp / 100);
                sum_hot_water = (Int32)((double)sum_hot_water * (double)percent_comp / 100);
                //Int32 loses1 = own_profit - loses;
                string query9 = "INSERT INTO [Финансы] ([Месяц], [Ожидаемые расходы],[Количество услуг],[Электричество],[Холодная вода], [Горячая вода], [Газ], [Прибыль], [Ожидаемая прибыль], [Начальный капитал], [Итог]) VALUES (" + mounth + "," + loses + "," + number_services + "," + sum_electro + "," + sum_cold_water + "," + sum_hot_water + "," + sum_gas + "," + own_profit + "," + profit + "," + start_capital + "," + end_capital + ")";
                OleDbCommand command9 = new OleDbCommand(query9, myConnection);
                command9.ExecuteNonQuery();

                this.финансыTableAdapter.Fill(this.zhkhDataSet.Финансы);

                this.поставщикиTableAdapter.Fill(this.zhkhDataSet.Поставщики);

                this.поставщик___тарифTableAdapter.Fill(this.zhkhDataSet._поставщик___тариф);

                this.коэффициентTableAdapter.Fill(this.zhkhDataSet.Коэффициент);

                this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);

                this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);

                this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);

                this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);

                this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);

                this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);

                this.коэффициентTableAdapter.Fill(this.zhkhDataSet.Коэффициент);

                this.поставщик___тарифTableAdapter.Fill(this.zhkhDataSet._поставщик___тариф);

                this.поставщикиTableAdapter.Fill(this.zhkhDataSet.Поставщики);

                this.поставщик___тарифTableAdapter.Fill(this.zhkhDataSet._поставщик___тариф);

                this.список_домовTableAdapter.Fill(this.zhkhDataSet.Список_домов);

                this.список_квартирTableAdapter.Fill(this.zhkhDataSet.Список_квартир);

                this.показания_счетчикаTableAdapter.Fill(this.zhkhDataSet.Показания_счетчика);

                this.квитанцияTableAdapter.Fill(this.zhkhDataSet.Квитанция);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
