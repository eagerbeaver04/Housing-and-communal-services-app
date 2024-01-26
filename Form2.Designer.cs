
namespace Zhkh2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zhkhDataSet = new Zhkh2.ZhkhDataSet();
            this.списокДомовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_домовTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Список_домовTableAdapter();
            this.адресДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.газDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокДомовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 52);
            this.button1.TabIndex = 125;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.адресДомаDataGridViewTextBoxColumn,
            this.типДомаDataGridViewTextBoxColumn,
            this.газDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокДомовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(649, 184);
            this.dataGridView1.TabIndex = 124;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.DataSource = this.списокДомовBindingSource;
            this.comboBox1.DisplayMember = "Адрес дома";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(289, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 28);
            this.comboBox1.TabIndex = 123;
            this.comboBox1.ValueMember = "Адрес дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "Укажите адрес дома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Снос дома";
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
            // адресДомаDataGridViewTextBoxColumn
            // 
            this.адресДомаDataGridViewTextBoxColumn.DataPropertyName = "Адрес дома";
            this.адресДомаDataGridViewTextBoxColumn.HeaderText = "Адрес дома";
            this.адресДомаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.адресДомаDataGridViewTextBoxColumn.Name = "адресДомаDataGridViewTextBoxColumn";
            this.адресДомаDataGridViewTextBoxColumn.Width = 150;
            // 
            // типДомаDataGridViewTextBoxColumn
            // 
            this.типДомаDataGridViewTextBoxColumn.DataPropertyName = "Тип дома";
            this.типДомаDataGridViewTextBoxColumn.HeaderText = "Тип дома";
            this.типДомаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.типДомаDataGridViewTextBoxColumn.Name = "типДомаDataGridViewTextBoxColumn";
            this.типДомаDataGridViewTextBoxColumn.Width = 150;
            // 
            // газDataGridViewTextBoxColumn
            // 
            this.газDataGridViewTextBoxColumn.DataPropertyName = "Газ";
            this.газDataGridViewTextBoxColumn.HeaderText = "Газ";
            this.газDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.газDataGridViewTextBoxColumn.Name = "газDataGridViewTextBoxColumn";
            this.газDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокДомовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZhkhDataSet zhkhDataSet;
        private System.Windows.Forms.BindingSource списокДомовBindingSource;
        private ZhkhDataSetTableAdapters.Список_домовTableAdapter список_домовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn газDataGridViewTextBoxColumn;
    }
}