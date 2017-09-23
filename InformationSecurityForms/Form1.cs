using System;
using System.Windows.Forms;

namespace InformationSecurityForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eylerBtn_Click(object sender, EventArgs e)
        {

            var eyler = new Eyler();
            eyler.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var dm = new DummyMethod();
            dm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var mr = new MillerRabin();
            mr.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sp = new SvidPrime();
            sp.Show();
        }
    }
}
