﻿namespace InformationSecurityForms.CountWitnessForm
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
            this.n1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.n2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.result1 = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.result2);
            this.groupBox2.Controls.Add(this.n2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.q2);
            this.groupBox2.Controls.Add(this.p2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(332, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Миллер-Рабин";
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(41, 102);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(22, 13);
            this.n2.TabIndex = 7;
            this.n2.Text = "n =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "q=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "p=";
            // 
            // q2
            // 
            this.q2.Location = new System.Drawing.Point(96, 65);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(100, 20);
            this.q2.TabIndex = 3;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(96, 34);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 20);
            this.p2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(80, 183);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(100, 20);
            this.result1.TabIndex = 6;
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(96, 183);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(100, 20);
            this.result2.TabIndex = 7;
            // 
            // PrimeWitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrimeWitness";
            this.Text = "Свидетели простоты";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q1;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox q2;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox result2;
    }
}

