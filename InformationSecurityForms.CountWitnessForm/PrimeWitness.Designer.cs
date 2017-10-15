namespace InformationSecurityForms.CountWitnessForm
{
    partial class PrimeWitness
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.upperNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.watchtime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpq = new System.Windows.Forms.RichTextBox();
            this.tbresult = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result1);
            this.groupBox1.Controls.Add(this.n1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.q1);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритм";
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(80, 183);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(100, 20);
            this.result1.TabIndex = 6;
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(28, 102);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(22, 13);
            this.n1.TabIndex = 5;
            this.n1.Text = "n =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "q=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "p=";
            // 
            // q1
            // 
            this.q1.Location = new System.Drawing.Point(80, 65);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(100, 20);
            this.q1.TabIndex = 2;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(80, 34);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 20);
            this.p1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upperNumber
            // 
            this.upperNumber.Location = new System.Drawing.Point(484, 28);
            this.upperNumber.Name = "upperNumber";
            this.upperNumber.Size = new System.Drawing.Size(100, 20);
            this.upperNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "   Верхняя граница";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // watchtime
            // 
            this.watchtime.Location = new System.Drawing.Point(311, 285);
            this.watchtime.Name = "watchtime";
            this.watchtime.Size = new System.Drawing.Size(100, 20);
            this.watchtime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " Время выполнения:";
            // 
            // tbpq
            // 
            this.tbpq.Location = new System.Drawing.Point(311, 78);
            this.tbpq.Name = "tbpq";
            this.tbpq.Size = new System.Drawing.Size(316, 138);
            this.tbpq.TabIndex = 8;
            this.tbpq.Text = "";
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(684, 78);
            this.tbresult.Name = "tbresult";
            this.tbresult.Size = new System.Drawing.Size(161, 138);
            this.tbresult.TabIndex = 9;
            this.tbresult.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Статистика:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Результат:";
            // 
            // PrimeWitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 337);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.tbpq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.watchtime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upperNumber);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrimeWitness";
            this.Text = "Свидетели простоты";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q1;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox upperNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox watchtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbpq;
        private System.Windows.Forms.RichTextBox tbresult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

