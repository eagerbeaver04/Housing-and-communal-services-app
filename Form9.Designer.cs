
namespace Zhkh2
{
    partial class Form9
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zhkhDataSet = new Zhkh2.ZhkhDataSet();
            this.финансыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.финансыTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.ФинансыTableAdapter();
            this.месяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ожидаемыеРасходыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоУслугDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электричествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.холоднаяВодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.горячаяВодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.газDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прибыльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ожидаемаяПрибыльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.начальныйКапиталDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.финансыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.финансыBindingSource;
            this.comboBox1.DisplayMember = "Месяц";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Напишите тип услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите месяц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оплата счетов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.месяцDataGridViewTextBoxColumn,
            this.ожидаемыеРасходыDataGridViewTextBoxColumn,
            this.количествоУслугDataGridViewTextBoxColumn,
            this.электричествоDataGridViewTextBoxColumn,
            this.холоднаяВодаDataGridViewTextBoxColumn,
            this.горячаяВодаDataGridViewTextBoxColumn,
            this.газDataGridViewTextBoxColumn,
            this.прибыльDataGridViewTextBoxColumn,
            this.ожидаемаяПрибыльDataGridViewTextBoxColumn,
            this.начальныйКапиталDataGridViewTextBoxColumn,
            this.итогDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.финансыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 214);
            this.dataGridView1.TabIndex = 7;
            // 
            // zhkhDataSet
            // 
            this.zhkhDataSet.DataSetName = "ZhkhDataSet";
            this.zhkhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // месяцDataGridViewTextBoxColumn
            // 
            this.месяцDataGridViewTextBoxColumn.DataPropertyName = "Месяц";
            this.месяцDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.месяцDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.месяцDataGridViewTextBoxColumn.Name = "месяцDataGridViewTextBoxColumn";
            this.месяцDataGridViewTextBoxColumn.Width = 150;
            // 
            // ожидаемыеРасходыDataGridViewTextBoxColumn
            // 
            this.ожидаемыеРасходыDataGridViewTextBoxColumn.DataPropertyName = "Ожидаемые расходы";
            this.ожидаемыеРасходыDataGridViewTextBoxColumn.HeaderText = "Ожидаемые расходы";
            this.ожидаемыеРасходыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ожидаемыеРасходыDataGridViewTextBoxColumn.Name = "ожидаемыеРасходыDataGridViewTextBoxColumn";
            this.ожидаемыеРасходыDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествоУслугDataGridViewTextBoxColumn
            // 
            this.количествоУслугDataGridViewTextBoxColumn.DataPropertyName = "Количество услуг";
            this.количествоУслугDataGridViewTextBoxColumn.HeaderText = "Количество услуг";
            this.количествоУслугDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествоУслугDataGridViewTextBoxColumn.Name = "количествоУслугDataGridViewTextBoxColumn";
            this.количествоУслугDataGridViewTextBoxColumn.Width = 150;
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
            // прибыльDataGridViewTextBoxColumn
            // 
            this.прибыльDataGridViewTextBoxColumn.DataPropertyName = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.HeaderText = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.прибыльDataGridViewTextBoxColumn.Name = "прибыльDataGridViewTextBoxColumn";
            this.прибыльDataGridViewTextBoxColumn.Width = 150;
            // 
            // ожидаемаяПрибыльDataGridViewTextBoxColumn
            // 
            this.ожидаемаяПрибыльDataGridViewTextBoxColumn.DataPropertyName = "Ожидаемая прибыль";
            this.ожидаемаяПрибыльDataGridViewTextBoxColumn.HeaderText = "Ожидаемая прибыль";
            this.ожидаемаяПрибыльDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ожидаемаяПрибыльDataGridViewTextBoxColumn.Name = "ожидаемаяПрибыльDataGridViewTextBoxColumn";
            this.ожидаемаяПрибыльDataGridViewTextBoxColumn.Width = 150;
            // 
            // начальныйКапиталDataGridViewTextBoxColumn
            // 
            this.начальныйКапиталDataGridViewTextBoxColumn.DataPropertyName = "Начальный капитал";
            this.начальныйКапиталDataGridViewTextBoxColumn.HeaderText = "Начальный капитал";
            this.начальныйКапиталDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.начальныйКапиталDataGridViewTextBoxColumn.Name = "начальныйКапиталDataGridViewTextBoxColumn";
            this.начальныйКапиталDataGridViewTextBoxColumn.Width = 150;
            // 
            // итогDataGridViewTextBoxColumn
            // 
            this.итогDataGridViewTextBoxColumn.DataPropertyName = "Итог";
            this.итогDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.итогDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.итогDataGridViewTextBoxColumn.Name = "итогDataGridViewTextBoxColumn";
            this.итогDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.финансыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZhkhDataSet zhkhDataSet;
        private System.Windows.Forms.BindingSource финансыBindingSource;
        private ZhkhDataSetTableAdapters.ФинансыTableAdapter финансыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ожидаемыеРасходыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоУслугDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электричествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn холоднаяВодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn горячаяВодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn газDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прибыльDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ожидаемаяПрибыльDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn начальныйКапиталDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогDataGridViewTextBoxColumn;
    }
}