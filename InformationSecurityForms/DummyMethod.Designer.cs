namespace InformationSecurityForms
{
    partial class DummyMethod
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
            this.resultDummy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numberN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Результат";
            // 
            // resultDummy
            // 
            this.resultDummy.Location = new System.Drawing.Point(64, 174);
            this.resultDummy.Name = "resultDummy";
            this.resultDummy.Size = new System.Drawing.Size(156, 20);
            this.resultDummy.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "n =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberN
            // 
            this.numberN.Location = new System.Drawing.Point(89, 29);
            this.numberN.Name = "numberN";
            this.numberN.Size = new System.Drawing.Size(100, 20);
            this.numberN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // delit
            // 
            this.delit.Location = new System.Drawing.Point(233, 174);
            this.delit.Name = "delit";
            this.delit.Size = new System.Drawing.Size(92, 20);
            this.delit.TabIndex = 10;
            // 
            // DummyMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultDummy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberN);
            this.Name = "DummyMethod";
            this.Text = "Перебор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultDummy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numberN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delit;
    }
}