using System;
using System.Numerics;
using System.Windows.Forms;

namespace InformationSecurityForms
{
    public partial class MillerRabin : Form
    {

        private Functions.MillerRabin millerRabin = new Functions.MillerRabin();

        #region c# stuffs
        public MillerRabin()
        {
            InitializeComponent();
        }

        private void MillerRabin_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            var n = BigInteger.Parse( numberN.Text );

            var isPrime = millerRabin.Miller_Rabin(n);

            if (isPrime)
                result.Text = "Простое";
            else
                result.Text = "Составное";

        }
    }
}
