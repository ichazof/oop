namespace light
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
            this.button1Read = new System.Windows.Forms.Button();
            this.textBox1Power = new System.Windows.Forms.TextBox();
            this.label1Power = new System.Windows.Forms.Label();
            this.label1Voltage = new System.Windows.Forms.Label();
            this.button1Get = new System.Windows.Forms.Button();
            this.textBox1Voltage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2Get = new System.Windows.Forms.Button();
            this.textBox2Voltage = new System.Windows.Forms.TextBox();
            this.button2Read = new System.Windows.Forms.Button();
            this.textBox2Power = new System.Windows.Forms.TextBox();
            this.label2Voltage = new System.Windows.Forms.Label();
            this.label2Power = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Read
            // 
            this.button1Read.Location = new System.Drawing.Point(139, 53);
            this.button1Read.Name = "button1Read";
            this.button1Read.Size = new System.Drawing.Size(132, 23);
            this.button1Read.TabIndex = 1;
            this.button1Read.Text = "Получить напряжение";
            this.button1Read.UseVisualStyleBackColor = true;
            this.button1Read.Click += new System.EventHandler(this.buttonRead_Click);
            this.button1Read.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // textBox1Power
            // 
            this.textBox1Power.Location = new System.Drawing.Point(11, 28);
            this.textBox1Power.Name = "textBox1Power";
            this.textBox1Power.Size = new System.Drawing.Size(38, 20);
            this.textBox1Power.TabIndex = 2;
            this.textBox1Power.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1Power
            // 
            this.label1Power.AutoSize = true;
            this.label1Power.Location = new System.Drawing.Point(21, 63);
            this.label1Power.Name = "label1Power";
            this.label1Power.Size = new System.Drawing.Size(0, 13);
            this.label1Power.TabIndex = 3;
            // 
            // label1Voltage
            // 
            this.label1Voltage.AutoSize = true;
            this.label1Voltage.Location = new System.Drawing.Point(62, 63);
            this.label1Voltage.Name = "label1Voltage";
            this.label1Voltage.Size = new System.Drawing.Size(0, 13);
            this.label1Voltage.TabIndex = 4;
            // 
            // button1Get
            // 
            this.button1Get.Location = new System.Drawing.Point(139, 28);
            this.button1Get.Name = "button1Get";
            this.button1Get.Size = new System.Drawing.Size(132, 23);
            this.button1Get.TabIndex = 5;
            this.button1Get.Text = "Считать";
            this.button1Get.UseVisualStyleBackColor = true;
            this.button1Get.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textBox1Voltage
            // 
            this.textBox1Voltage.Location = new System.Drawing.Point(79, 28);
            this.textBox1Voltage.Name = "textBox1Voltage";
            this.textBox1Voltage.Size = new System.Drawing.Size(38, 20);
            this.textBox1Voltage.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1Get);
            this.groupBox1.Controls.Add(this.textBox1Voltage);
            this.groupBox1.Controls.Add(this.button1Read);
            this.groupBox1.Controls.Add(this.textBox1Power);
            this.groupBox1.Controls.Add(this.label1Voltage);
            this.groupBox1.Controls.Add(this.label1Power);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лампа1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2Get);
            this.groupBox2.Controls.Add(this.textBox2Voltage);
            this.groupBox2.Controls.Add(this.button2Read);
            this.groupBox2.Controls.Add(this.textBox2Power);
            this.groupBox2.Controls.Add(this.label2Voltage);
            this.groupBox2.Controls.Add(this.label2Power);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лампа2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2Get
            // 
            this.button2Get.Location = new System.Drawing.Point(139, 28);
            this.button2Get.Name = "button2Get";
            this.button2Get.Size = new System.Drawing.Size(132, 23);
            this.button2Get.TabIndex = 5;
            this.button2Get.Text = "Считать";
            this.button2Get.UseVisualStyleBackColor = true;
            this.button2Get.Click += new System.EventHandler(this.button2Get_Click);
            // 
            // textBox2Voltage
            // 
            this.textBox2Voltage.Location = new System.Drawing.Point(79, 28);
            this.textBox2Voltage.Name = "textBox2Voltage";
            this.textBox2Voltage.Size = new System.Drawing.Size(38, 20);
            this.textBox2Voltage.TabIndex = 6;
            // 
            // button2Read
            // 
            this.button2Read.Location = new System.Drawing.Point(139, 53);
            this.button2Read.Name = "button2Read";
            this.button2Read.Size = new System.Drawing.Size(132, 23);
            this.button2Read.TabIndex = 1;
            this.button2Read.Text = "Получить напряжение";
            this.button2Read.UseVisualStyleBackColor = true;
            this.button2Read.Click += new System.EventHandler(this.button2Read_Click);
            // 
            // textBox2Power
            // 
            this.textBox2Power.Location = new System.Drawing.Point(11, 28);
            this.textBox2Power.Name = "textBox2Power";
            this.textBox2Power.Size = new System.Drawing.Size(38, 20);
            this.textBox2Power.TabIndex = 2;
            // 
            // label2Voltage
            // 
            this.label2Voltage.AutoSize = true;
            this.label2Voltage.Location = new System.Drawing.Point(62, 63);
            this.label2Voltage.Name = "label2Voltage";
            this.label2Voltage.Size = new System.Drawing.Size(0, 13);
            this.label2Voltage.TabIndex = 4;
            // 
            // label2Power
            // 
            this.label2Power.AutoSize = true;
            this.label2Power.Location = new System.Drawing.Point(21, 63);
            this.label2Power.Name = "label2Power";
            this.label2Power.Size = new System.Drawing.Size(0, 13);
            this.label2Power.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1Read;
        private System.Windows.Forms.TextBox textBox1Power;
        private System.Windows.Forms.Label label1Power;
        private System.Windows.Forms.Label label1Voltage;
        private System.Windows.Forms.Button button1Get;
        private System.Windows.Forms.TextBox textBox1Voltage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2Get;
        private System.Windows.Forms.TextBox textBox2Voltage;
        private System.Windows.Forms.Button button2Read;
        private System.Windows.Forms.TextBox textBox2Power;
        private System.Windows.Forms.Label label2Voltage;
        private System.Windows.Forms.Label label2Power;
    }
}

