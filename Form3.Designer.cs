
namespace Zhkh2
{
    partial class Form3
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zhkhDataSet = new Zhkh2.ZhkhDataSet();
            this.списокДомовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_домовTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Список_домовTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.списокКвартирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_квартирTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Список_квартирTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.долгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.временнойДолгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отключениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокДомовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(79, 384);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 24);
            this.checkBox1.TabIndex = 119;
            this.checkBox1.Text = "Есть ли газ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.списокДомовBindingSource;
            this.comboBox8.DisplayMember = "Тип дома";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(286, 392);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(245, 28);
            this.comboBox8.TabIndex = 118;
            this.comboBox8.ValueMember = "Тип дома";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 117;
            this.label9.Text = "Введите тип дома";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 50);
            this.button1.TabIndex = 116;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.списокКвартирBindingSource;
            this.comboBox7.DisplayMember = "Этаж";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(850, 314);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(191, 28);
            this.comboBox7.TabIndex = 115;
            this.comboBox7.ValueMember = "Этаж";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(846, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 114;
            this.label8.Text = "Введите этаж квартиры";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.списокКвартирBindingSource;
            this.comboBox6.DisplayMember = "Имя";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(45, 314);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(214, 28);
            this.comboBox6.TabIndex = 113;
            this.comboBox6.ValueMember = "Имя";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.списокКвартирBindingSource;
            this.comboBox5.DisplayMember = "Фамилия";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(286, 314);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(229, 28);
            this.comboBox5.TabIndex = 112;
            this.comboBox5.ValueMember = "Фамилия";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.списокКвартирBindingSource;
            this.comboBox4.DisplayMember = "Отчество";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(556, 314);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(244, 28);
            this.comboBox4.TabIndex = 111;
            this.comboBox4.ValueMember = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "Введите отчество собственника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 20);
            this.label6.TabIndex = 109;
            this.label6.Text = "Введите фамилию собственника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 20);
            this.label5.TabIndex = 108;
            this.label5.Text = "Введите имя собственника";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.списокКвартирBindingSource;
            this.comboBox3.DisplayMember = "Номер квартиры";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(286, 242);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 28);
            this.comboBox3.TabIndex = 107;
            this.comboBox3.ValueMember = "Номер квартиры";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.списокКвартирBindingSource;
            this.comboBox2.DisplayMember = "Площадь квартиры";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(557, 242);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 28);
            this.comboBox2.TabIndex = 106;
            this.comboBox2.ValueMember = "Площадь квартиры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 105;
            this.label4.Text = "Введите площадь квартиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Введите номер квартиры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Введите адрес дома";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.списокКвартирBindingSource;
            this.comboBox1.DisplayMember = "Адрес дома";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 28);
            this.comboBox1.TabIndex = 101;
            this.comboBox1.ValueMember = "Адрес дома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Принятие на баланс дома";
            // 
            // zhkhDataSet
            // 
            this.zhkhDataSet.DataSetName = "ZhkhDataSet";
            this.zhkhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.номерКвартирыDataGridViewTextBoxColumn,
            this.адресДомаDataGridViewTextBoxColumn,
            this.площадьКвартирыDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.долгDataGridViewTextBoxColumn,
            this.временнойДолгDataGridViewTextBoxColumn,
            this.отключениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокКвартирBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 150);
            this.dataGridView1.TabIndex = 103;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // номерКвартирыDataGridViewTextBoxColumn
            // 
            this.номерКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Номер квартиры";
            this.номерКвартирыDataGridViewTextBoxColumn.HeaderText = "Номер квартиры";
            this.номерКвартирыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерКвартирыDataGridViewTextBoxColumn.Name = "номерКвартирыDataGridViewTextBoxColumn";
            this.номерКвартирыDataGridViewTextBoxColumn.Width = 150;
            // 
            // адресДомаDataGridViewTextBoxColumn
            // 
            this.адресДомаDataGridViewTextBoxColumn.DataPropertyName = "Адрес дома";
            this.адресДомаDataGridViewTextBoxColumn.HeaderText = "Адрес дома";
            this.адресДомаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.адресДомаDataGridViewTextBoxColumn.Name = "адресДомаDataGridViewTextBoxColumn";
            this.адресДомаDataGridViewTextBoxColumn.Width = 150;
            // 
            // площадьКвартирыDataGridViewTextBoxColumn
            // 
            this.площадьКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Площадь квартиры";
            this.площадьКвартирыDataGridViewTextBoxColumn.HeaderText = "Площадь квартиры";
            this.площадьКвартирыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.площадьКвартирыDataGridViewTextBoxColumn.Name = "площадьКвартирыDataGridViewTextBoxColumn";
            this.площадьКвартирыDataGridViewTextBoxColumn.Width = 150;
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "Этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.этажDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            this.этажDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 150;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 150;
            // 
            // долгDataGridViewTextBoxColumn
            // 
            this.долгDataGridViewTextBoxColumn.DataPropertyName = "Долг";
            this.долгDataGridViewTextBoxColumn.HeaderText = "Долг";
            this.долгDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.долгDataGridViewTextBoxColumn.Name = "долгDataGridViewTextBoxColumn";
            this.долгDataGridViewTextBoxColumn.Width = 150;
            // 
            // временнойДолгDataGridViewTextBoxColumn
            // 
            this.временнойДолгDataGridViewTextBoxColumn.DataPropertyName = "Временной долг";
            this.временнойДолгDataGridViewTextBoxColumn.HeaderText = "Временной долг";
            this.временнойДолгDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.временнойДолгDataGridViewTextBoxColumn.Name = "временнойДолгDataGridViewTextBoxColumn";
            this.временнойДолгDataGridViewTextBoxColumn.Width = 150;
            // 
            // отключениеDataGridViewTextBoxColumn
            // 
            this.отключениеDataGridViewTextBoxColumn.DataPropertyName = "Отключение";
            this.отключениеDataGridViewTextBoxColumn.HeaderText = "Отключение";
            this.отключениеDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отключениеDataGridViewTextBoxColumn.Name = "отключениеDataGridViewTextBoxColumn";
            this.отключениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокДомовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private ZhkhDataSet zhkhDataSet;
        private System.Windows.Forms.BindingSource списокДомовBindingSource;
        private ZhkhDataSetTableAdapters.Список_домовTableAdapter список_домовTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource списокКвартирBindingSource;
        private ZhkhDataSetTableAdapters.Список_квартирTableAdapter список_квартирTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn долгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn временнойДолгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отключениеDataGridViewTextBoxColumn;
    }
}