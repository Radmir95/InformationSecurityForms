using System;
using System.Windows.Forms;

namespace InformationSecurityForms
{
    public partial class DummyMethod : Form
    {
        public DummyMethod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            resultDummy.Text = string.Empty;
            delit.Text = string.Empty;

            var n = long.Parse( numberN.Text );

            var isPrimeNumber = true;

            for (var i = 2; i <= Math.Sqrt(n) && isPrimeNumber; i++)
            {
                if (n % i == 0)
                {
                    isPrimeNumber = false;
                    delit.Text = i.ToString();
                }
            }

            if (isPrimeNumber)
                resultDummy.Text = "Простое";
            else
                resultDummy.Text = "Составное";

            Cursor.Current = Cursors.Arrow;


        }
    }
}
