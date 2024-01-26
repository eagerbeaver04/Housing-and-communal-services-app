
namespace Zhkh2
{
    partial class Form6
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
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.zhkhDataSet = new Zhkh2.ZhkhDataSet();
            this.квитанцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.квитанцияTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.КвитанцияTableAdapter();
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
            this.финансыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.финансыTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.ФинансыTableAdapter();
            this.списокКвартирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_квартирTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Список_квартирTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.квитанцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.финансыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 74);
            this.button1.TabIndex = 35;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.квитанцияBindingSource;
            this.comboBox4.DisplayMember = "Сумма";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(822, 286);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 34;
            this.comboBox4.ValueMember = "Сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(818, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Введите сумму";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.квитанцияBindingSource;
            this.comboBox3.DisplayMember = "Месяц";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(610, 286);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(130, 28);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.ValueMember = "Месяц";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.квитанцияBindingSource;
            this.comboBox2.DisplayMember = "Номер квартиры";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(339, 286);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.ValueMember = "Номер квартиры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Введите месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Введите номер квартиры";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.квитанцияBindingSource;
            this.comboBox1.DisplayMember = "Адрес дома";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 28);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "Адрес дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Введите адрес дома";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Оплата квитанций";
            // 
            // zhkhDataSet
            // 
            this.zhkhDataSet.DataSetName = "ZhkhDataSet";
            this.zhkhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // квитанцияBindingSource
            // 
            this.квитанцияBindingSource.DataMember = "Квитанция";
            this.квитанцияBindingSource.DataSource = this.zhkhDataSet;
            // 
            // квитанцияTableAdapter
            // 
            this.квитанцияTableAdapter.ClearBeforeFill = true;
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
            // финансыBindingSource
            // 
            this.финансыBindingSource.DataMember = "Финансы";
            this.финансыBindingSource.DataSource = this.zhkhDataSet;
            // 
            // финансыTableAdapter
            // 
            this.финансыTableAdapter.ClearBeforeFill = true;
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.квитанцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.финансыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.BindingSource финансыBindingSource;
        private ZhkhDataSetTableAdapters.ФинансыTableAdapter финансыTableAdapter;
        private System.Windows.Forms.BindingSource списокКвартирBindingSource;
        private ZhkhDataSetTableAdapters.Список_квартирTableAdapter список_квартирTableAdapter;
    }
}