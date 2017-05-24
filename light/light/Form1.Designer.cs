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
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.textBoxVoltage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(140, 37);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(132, 23);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Получить напряжение";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            this.buttonRead.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(12, 12);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(38, 20);
            this.textBoxPower.TabIndex = 2;
            this.textBoxPower.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(22, 47);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(0, 13);
            this.labelPower.TabIndex = 3;
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Location = new System.Drawing.Point(63, 47);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(0, 13);
            this.labelVoltage.TabIndex = 4;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(140, 10);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(132, 23);
            this.buttonGet.TabIndex = 5;
            this.buttonGet.Text = "Считать";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textBoxVoltage
            // 
            this.textBoxVoltage.Location = new System.Drawing.Point(80, 12);
            this.textBoxVoltage.Name = "textBoxVoltage";
            this.textBoxVoltage.Size = new System.Drawing.Size(38, 20);
            this.textBoxVoltage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxVoltage);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.labelVoltage);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.buttonRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.TextBox textBoxVoltage;
    }
}

