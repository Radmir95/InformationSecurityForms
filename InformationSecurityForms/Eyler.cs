using System;
using System.Windows.Forms;

namespace InformationSecurityForms
{
    public partial class Eyler : Form
    {
        public Eyler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var n = long.Parse(numberN.Text);

            var result = n;
            for (var i = 2; i * i <= n; ++i)
            {

                if (n % i == 0)
                {
                    while (n % i == 0)
                        n /= i;
                    result -= result / i;
                }
            }

            if (n > 1)
                result -= result / n;

            resultEyler.Text = result.ToString();

        }
    }
}
