
namespace Zhkh2
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.квитанцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhkhDataSet = new Zhkh2.ZhkhDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электричествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.холоднаяВодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.горячаяВодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.газDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отключениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квитанцияTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.КвитанцияTableAdapter();
            this.списокДомовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_домовTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Список_домовTableAdapter();
            this.списокКвартирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_квартирTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Список_квартирTableAdapter();
            this.коэффициентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.коэффициентTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.КоэффициентTableAdapter();
            this.показанияСчетчикаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.показания_счетчикаTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Показания_счетчикаTableAdapter();
            this.поставщикТарифBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщик___тарифTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.поставщик___тарифTableAdapter();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.ПоставщикиTableAdapter();
            this.финансыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.финансыTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.ФинансыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.квитанцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокДомовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.коэффициентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показанияСчетчикаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикТарифBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.финансыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 68);
            this.button1.TabIndex = 24;
            this.button1.Text = "Создать квитанции";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.квитанцияBindingSource;
            this.comboBox1.DisplayMember = "Месяц";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "Месяц";
            // 
            // квитанцияBindingSource
            // 
            this.квитанцияBindingSource.DataMember = "Квитанция";
            this.квитанцияBindingSource.DataSource = this.zhkhDataSet;
            // 
            // zhkhDataSet
            // 
            this.zhkhDataSet.DataSetName = "ZhkhDataSet";
            this.zhkhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Выберите месяц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Формирование квитанций";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.адресДомаDataGridViewTextBoxColumn,
            this.номерКвартирыDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.месяцDataGridViewTextBoxColumn,
            this.электричествоDataGridViewTextBoxColumn,
            this.холоднаяВодаDataGridViewTextBoxColumn,
            this.горячаяВодаDataGridViewTextBoxColumn,
            this.газDataGridViewTextBoxColumn,
            this.отключениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.квитанцияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(968, 252);
            this.dataGridView1.TabIndex = 20;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // адресДомаDataGridViewTextBoxColumn
            // 
            this.адресДомаDataGridViewTextBoxColumn.DataPropertyName = "Адрес дома";
            this.адресДомаDataGridViewTextBoxColumn.HeaderText = "Адрес дома";
            this.адресДомаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.адресДомаDataGridViewTextBoxColumn.Name = "адресДомаDataGridViewTextBoxColumn";
            this.адресДомаDataGridViewTextBoxColumn.Width = 150;
            // 
            // номерКвартирыDataGridViewTextBoxColumn
            // 
            this.номерКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Номер квартиры";
            this.номерКвартирыDataGridViewTextBoxColumn.HeaderText = "Номер квартиры";
            this.номерКвартирыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерКвартирыDataGridViewTextBoxColumn.Name = "номерКвартирыDataGridViewTextBoxColumn";
            this.номерКвартирыDataGridViewTextBoxColumn.Width = 150;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 150;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.Width = 150;
            // 
            // месяцDataGridViewTextBoxColumn
            // 
            this.месяцDataGridViewTextBoxColumn.DataPropertyName = "Месяц";
            this.месяцDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.месяцDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.месяцDataGridViewTextBoxColumn.Name = "месяцDataGridViewTextBoxColumn";
            this.месяцDataGridViewTextBoxColumn.Width = 150;
            // 
            // электричествоDataGridViewTextBoxColumn
            // 
            this.электричествоDataGridViewTextBoxColumn.DataPropertyName = "Электричество";
            this.электричествоDataGridViewTextBoxColumn.HeaderText = "Электричество";
            this.электричествоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.электричествоDataGridViewTextBoxColumn.Name = "электричествоDataGridViewTextBoxColumn";
            this.электричествоDataGridViewTextBoxColumn.Width = 150;
            // 
            // холоднаяВодаDataGridViewTextBoxColumn
            // 
            this.холоднаяВодаDataGridViewTextBoxColumn.DataPropertyName = "Холодная вода";
            this.холоднаяВодаDataGridViewTextBoxColumn.HeaderText = "Холодная вода";
            this.холоднаяВодаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.холоднаяВодаDataGridViewTextBoxColumn.Name = "холоднаяВодаDataGridViewTextBoxColumn";
            this.холоднаяВодаDataGridViewTextBoxColumn.Width = 150;
            // 
            // горячаяВодаDataGridViewTextBoxColumn
            // 
            this.горячаяВодаDataGridViewTextBoxColumn.DataPropertyName = "Горячая вода";
            this.горячаяВодаDataGridViewTextBoxColumn.HeaderText = "Горячая вода";
            this.горячаяВодаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.горячаяВодаDataGridViewTextBoxColumn.Name = "горячаяВодаDataGridViewTextBoxColumn";
            this.горячаяВодаDataGridViewTextBoxColumn.Width = 150;
            // 
            // газDataGridViewTextBoxColumn
            // 
            this.газDataGridViewTextBoxColumn.DataPropertyName = "Газ";
            this.газDataGridViewTextBoxColumn.HeaderText = "Газ";
            this.газDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.газDataGridViewTextBoxColumn.Name = "газDataGridViewTextBoxColumn";
            this.газDataGridViewTextBoxColumn.Width = 150;
            // 
            // отключениеDataGridViewTextBoxColumn
            // 
            this.отключениеDataGridViewTextBoxColumn.DataPropertyName = "Отключение";
            this.отключениеDataGridViewTextBoxColumn.HeaderText = "Отключение";
            this.отключениеDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отключениеDataGridViewTextBoxColumn.Name = "отключениеDataGridViewTextBoxColumn";
            this.отключениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // квитанцияTableAdapter
            // 
            this.квитанцияTableAdapter.ClearBeforeFill = true;
            // 
            // списокДомовBindingSource
            // 
            this.списокДомовBindingSource.DataMember = "Список домов";
            this.списокДомовBindingSource.DataSource = this.zhkhDataSet;
            // 
            // список_домовTableAdapter
            // 
            this.список_домовTableAdapter.ClearBeforeFill = true;
            // 
            // списокКвартирBindingSource
            // 
            this.списокКвартирBindingSource.DataMember = "Список квартир";
            this.списокКвартирBindingSource.DataSource = this.zhkhDataSet;
            // 
            // список_квартирTableAdapter
            // 
            this.список_квартирTableAdapter.ClearBeforeFill = true;
            // 
            // коэффициентBindingSource
            // 
            this.коэффициентBindingSource.DataMember = "Коэффициент";
            this.коэффициентBindingSource.DataSource = this.zhkhDataSet;
            // 
            // коэффициентTableAdapter
            // 
            this.коэффициентTableAdapter.ClearBeforeFill = true;
            // 
            // показанияСчетчикаBindingSource
            // 
            this.показанияСчетчикаBindingSource.DataMember = "Показания счетчика";
            this.показанияСчетчикаBindingSource.DataSource = this.zhkhDataSet;
            // 
            // показания_счетчикаTableAdapter
            // 
            this.показания_счетчикаTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикТарифBindingSource
            // 
            this.поставщикТарифBindingSource.DataMember = "поставщик - тариф";
            this.поставщикТарифBindingSource.DataSource = this.zhkhDataSet;
            // 
            // поставщик___тарифTableAdapter
            // 
            this.поставщик___тарифTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.zhkhDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // финансыBindingSource
            // 
            this.финансыBindingSource.DataMember = "Финансы";
            this.финансыBindingSource.DataSource = this.zhkhDataSet;
            // 
            // финансыTableAdapter
            // 
            this.финансыTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.квитанцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокДомовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.коэффициентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показанияСчетчикаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикТарифBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.финансыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZhkhDataSet zhkhDataSet;
        private System.Windows.Forms.BindingSource квитанцияBindingSource;
        private ZhkhDataSetTableAdapters.КвитанцияTableAdapter квитанцияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электричествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn холоднаяВодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn горячаяВодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn газDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отключениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource списокДомовBindingSource;
        private ZhkhDataSetTableAdapters.Список_домовTableAdapter список_домовTableAdapter;
        private System.Windows.Forms.BindingSource списокКвартирBindingSource;
        private ZhkhDataSetTableAdapters.Список_квартирTableAdapter список_квартирTableAdapter;
        private System.Windows.Forms.BindingSource коэффициентBindingSource;
        private ZhkhDataSetTableAdapters.КоэффициентTableAdapter коэффициентTableAdapter;
        private System.Windows.Forms.BindingSource показанияСчетчикаBindingSource;
        private ZhkhDataSetTableAdapters.Показания_счетчикаTableAdapter показания_счетчикаTableAdapter;
        private System.Windows.Forms.BindingSource поставщикТарифBindingSource;
        private ZhkhDataSetTableAdapters.поставщик___тарифTableAdapter поставщик___тарифTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private ZhkhDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource финансыBindingSource;
        private ZhkhDataSetTableAdapters.ФинансыTableAdapter финансыTableAdapter;
    }
}