
namespace Zhkh2
{
    partial class Form4
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
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.zhkhDataSet = new Zhkh2.ZhkhDataSet();
            this.показанияСчетчикаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.показания_счетчикаTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Показания_счетчикаTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электричествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.холоднаяВодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.горячаяВодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.газDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСнятияПоказанийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показанияСчетчикаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.показанияСчетчикаBindingSource;
            this.comboBox7.DisplayMember = "Газ";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(720, 342);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(169, 28);
            this.comboBox7.TabIndex = 84;
            this.comboBox7.ValueMember = "Газ";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.показанияСчетчикаBindingSource;
            this.comboBox6.DisplayMember = "Электричество";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(379, 342);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(166, 28);
            this.comboBox6.TabIndex = 83;
            this.comboBox6.ValueMember = "Электричество";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.показанияСчетчикаBindingSource;
            this.comboBox5.DisplayMember = "Горячая вода";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(76, 342);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(196, 28);
            this.comboBox5.TabIndex = 82;
            this.comboBox5.ValueMember = "Горячая вода";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.показанияСчетчикаBindingSource;
            this.comboBox4.DisplayMember = "Холодная вода";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(801, 239);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(145, 28);
            this.comboBox4.TabIndex = 81;
            this.comboBox4.ValueMember = "Холодная вода";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.показанияСчетчикаBindingSource;
            this.comboBox3.DisplayMember = "Месяц";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(532, 239);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(173, 28);
            this.comboBox3.TabIndex = 80;
            this.comboBox3.ValueMember = "Месяц";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.показанияСчетчикаBindingSource;
            this.comboBox2.DisplayMember = "Номер квартиры";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(289, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 79;
            this.comboBox2.ValueMember = "Номер квартиры";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.показанияСчетчикаBindingSource;
            this.comboBox1.DisplayMember = "Адрес дома";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 28);
            this.comboBox1.TabIndex = 78;
            this.comboBox1.ValueMember = "Адрес дома";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 67);
            this.button1.TabIndex = 77;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Введите месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Введите показания за газ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Введите показания за электричество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Введите показания по горячей воде";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Введите показания по холодной воде";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Введите номер квартиры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Введите адрес дома";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.электричествоDataGridViewTextBoxColumn,
            this.холоднаяВодаDataGridViewTextBoxColumn,
            this.горячаяВодаDataGridViewTextBoxColumn,
            this.газDataGridViewTextBoxColumn,
            this.датаСнятияПоказанийDataGridViewTextBoxColumn,
            this.месяцDataGridViewTextBoxColumn,
            this.адресДомаDataGridViewTextBoxColumn,
            this.номерКвартирыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.показанияСчетчикаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 150);
            this.dataGridView1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Внести показания счетчиков";
            // 
            // zhkhDataSet
            // 
            this.zhkhDataSet.DataSetName = "ZhkhDataSet";
            this.zhkhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
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
            // датаСнятияПоказанийDataGridViewTextBoxColumn
            // 
            this.датаСнятияПоказанийDataGridViewTextBoxColumn.DataPropertyName = "Дата снятия показаний";
            this.датаСнятияПоказанийDataGridViewTextBoxColumn.HeaderText = "Дата снятия показаний";
            this.датаСнятияПоказанийDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаСнятияПоказанийDataGridViewTextBoxColumn.Name = "датаСнятияПоказанийDataGridViewTextBoxColumn";
            this.датаСнятияПоказанийDataGridViewTextBoxColumn.Width = 150;
            // 
            // месяцDataGridViewTextBoxColumn
            // 
            this.месяцDataGridViewTextBoxColumn.DataPropertyName = "Месяц";
            this.месяцDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.месяцDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.месяцDataGridViewTextBoxColumn.Name = "месяцDataGridViewTextBoxColumn";
            this.месяцDataGridViewTextBoxColumn.Width = 150;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 450);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показанияСчетчикаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private ZhkhDataSet zhkhDataSet;
        private System.Windows.Forms.BindingSource показанияСчетчикаBindingSource;
        private ZhkhDataSetTableAdapters.Показания_счетчикаTableAdapter показания_счетчикаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электричествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn холоднаяВодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn горячаяВодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn газDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСнятияПоказанийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКвартирыDataGridViewTextBoxColumn;
    }
}