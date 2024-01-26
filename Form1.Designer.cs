
namespace Zhkh2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.zhkhDataSet = new Zhkh2.ZhkhDataSet();
            this.списокКвартирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_квартирTableAdapter = new Zhkh2.ZhkhDataSetTableAdapters.Список_квартирTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(492, 325);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(266, 62);
            this.button8.TabIndex = 49;
            this.button8.Text = "Оплата счетов от компаний";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(492, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(266, 65);
            this.button7.TabIndex = 48;
            this.button7.Text = "Оплата квитанций";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 62);
            this.button6.TabIndex = 47;
            this.button6.Text = "Занести показания счетчиков";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(246, 65);
            this.button5.TabIndex = 46;
            this.button5.Text = "Формирование квитанции";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(492, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 64);
            this.button4.TabIndex = 45;
            this.button4.Text = "Отчеты";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 74);
            this.button3.TabIndex = 44;
            this.button3.Text = "Принятие на баланс дома";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 68);
            this.button2.TabIndex = 43;
            this.button2.Text = "Получить список должников";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Что хотите сделать?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 68);
            this.button1.TabIndex = 41;
            this.button1.Text = "Снос дома";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zhkhDataSet
            // 
            this.zhkhDataSet.DataSetName = "ZhkhDataSet";
            this.zhkhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.zhkhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКвартирBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ZhkhDataSet zhkhDataSet;
        private System.Windows.Forms.BindingSource списокКвартирBindingSource;
        private ZhkhDataSetTableAdapters.Список_квартирTableAdapter список_квартирTableAdapter;
    }
}

