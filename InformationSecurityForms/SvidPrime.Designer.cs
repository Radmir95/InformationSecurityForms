namespace InformationSecurityForms
{
    partial class SvidPrime
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
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numberN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Результат";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(72, 193);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(156, 20);
            this.result.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "n =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberN
            // 
            this.numberN.Location = new System.Drawing.Point(97, 48);
            this.numberN.Name = "numberN";
            this.numberN.Size = new System.Drawing.Size(100, 20);
            this.numberN.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "a =";
            // 
            // numberA
            // 
            this.numberA.Location = new System.Drawing.Point(97, 86);
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(100, 20);
            this.numberA.TabIndex = 20;
            // 
            // SvidPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberN);
            this.Name = "SvidPrime";
            this.Text = "Свидетель простоты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numberN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberA;
    }
}