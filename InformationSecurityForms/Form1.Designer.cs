namespace InformationSecurityForms
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
            this.eylerBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eylerBtn
            // 
            this.eylerBtn.Location = new System.Drawing.Point(29, 25);
            this.eylerBtn.Name = "eylerBtn";
            this.eylerBtn.Size = new System.Drawing.Size(75, 23);
            this.eylerBtn.TabIndex = 0;
            this.eylerBtn.Text = "Эйлер";
            this.eylerBtn.UseVisualStyleBackColor = true;
            this.eylerBtn.Click += new System.EventHandler(this.eylerBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Перебор";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Свидетель простоты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Миллер-Рабин";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(311, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "      Простота чисел";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.eylerBtn);
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eylerBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

