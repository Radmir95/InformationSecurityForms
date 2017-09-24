using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityForms.CountWitnessForm
{
    public partial class PrimeWitness : Form
    {

        protected AllDerivBelow adb = new AllDerivBelow();

        public PrimeWitness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Radmir's part of code

            var p = int.Parse(p1.Text);
            var q = int.Parse(q1.Text);

            n1.Text = "n = " + p * q;

            var delp = adb.FindAllDerivBelow(p-1);
            var delq = adb.FindAllDerivBelow(q-1);

            var intersp = delp.ToArray().Intersect(delq.ToArray()).ToList();

            var step2 = new Dictionary<int,int>();

            for (int i = 0; i < intersp.Count; i++)
            {

                var t = (int)(intersp[i]);
                var s = 0;
                while (t % 2 == 0)
                {
                    s++;
                    t = t / 2;
                }

                if (step2.ContainsKey(s))
                    step2[s] += EylerFunction.FindEylerFunction((int)intersp[i]);
                else
                    step2.Add(s, EylerFunction.FindEylerFunction((int)intersp[i]));
            }

            var result = 0;

            foreach(var keyval in step2)
            {

                result += keyval.Value * keyval.Value;

            }

            result1.Text = result.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Alina's part of code
        }
    }
}
