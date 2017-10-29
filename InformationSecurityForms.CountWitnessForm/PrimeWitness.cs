using Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
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

            // read p and q from textboxes
            var p = int.Parse(p1.Text);
            var q = int.Parse(q1.Text);

            // fill n1 - textbox
            n1.Text = "n = " + p * q;

            // find number of witness
            var result = NumOfWitnessOfPrime(p, q);

            result1.Text = result.ToString();
        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            var stopWatch = Stopwatch.StartNew();
            var upperNum = Int32.Parse(upperNumber.Text);

            var result = Sieve(upperNum).ToList();

            tbpq.ResetText();
            tbresult.ResetText();

            var resultstring = "";

            int n = 0;

            double result1 = 0;
            double result2 = 0;

            // boiler place
            for (int i = 1; i < result.Count/2; i++)
                for (int j = 0; j < i; j++)
                {
                    var p = result[i];
                    var q = result[j];

                    if (p * q > upperNum)
                    {
                        continue;
                    }
                    var wtnprm = NumOfWitnessOfPrime(p, q);

                    n++;

                    result1 += double.Parse(((double)wtnprm / (p * q)).ToString());

                    result2 += (double)(p-1)*(q-1)/4;

                }

            tbpq.Text = result1 / n + " " + result2 / n;

            stopWatch.Stop();

            watchtime.Text = stopWatch.ElapsedMilliseconds.ToString();

        }

        private int NumOfWitnessOfPrime(int p, int q)
        {
            //find Del P and Del Q
            var delp = adb.FindAllDerivBelow(p - 1);
            var delq = adb.FindAllDerivBelow(q - 1);

            // intersection of Del P and Del Q

            var one = from int i in delp select i;
            var second = from int i in delq select i;

            var intersp = one.Intersect(second).ToList();

            // Step 2
            var step2 = new Dictionary<int, int>();

            for (int i = 0; i < intersp.Count; i++)
            {

                var t = intersp[i];
                var s = 0;
                while (t % 2 == 0)
                {
                    s++;
                    t = t / 2;
                }

                if (step2.ContainsKey(s))
                    step2[s] += EylerFunction.FindEylerFunctionInt(intersp[i]);
                else
                    step2.Add(s, EylerFunction.FindEylerFunctionInt(intersp[i]));
            }

            var result = 0;

            foreach (var keyval in step2)
            {
                result += keyval.Value * keyval.Value;
            }

            return result;
        }

        private List<BigInteger> AllPrimesBelow(BigInteger maximum)
        {
            var primes = new List<BigInteger>() { 2 };
            var m = new BigInteger(Math.Ceiling(Math.Sqrt((double)maximum)));
            for (BigInteger i = 2; i <= maximum; i++)
            {
                var prime = true;
                if (i > 2)
                    for (var j = 0; j < primes.Count; j++) { if (primes[j] < m && i % primes[j] == 0) { prime = false; break; } }
                if (prime)
                    if (!primes.Contains(i)) primes.Add(i);
            }
            return primes;
        }

        public static IEnumerable<int> Sieve(Int32 maxValue)
        {
            if (maxValue < 10)
            {
                if (maxValue == 9 || maxValue == 8 || maxValue == 7)
                {
                    return new List<int>() { 2, 3, 5, 7 };
                }
                else if (maxValue == 6 || maxValue == 5)
                {
                    return new List<int>() { 2, 3, 5 };
                }
                else if (maxValue == 4 || maxValue == 3)
                {
                    return new List<int>() { 2, 3 };
                }
                else
                {
                    return new List<int>() { 2 };
                }
            }

            Int32 counter = 0;
            Int32 counterStart = 3;
            Int32 inc;
            Int32 sqrt = 3;

            Int32 ceil = maxValue >= Int32.MaxValue - 2 ? Int32.MaxValue - 2 : (Int32)maxValue;
            bool[] primeMembershipArray = new bool[ceil + 2];

            primeMembershipArray[2] = true;

            // Set all odds as true
            for (counter = counterStart; counter <= maxValue; counter += 2)
            {
                if ((counter & 1) == 1) // Check if odd. &1 is the same as: %2
                {
                    primeMembershipArray[counter] = true;
                }
            }

            while (sqrt * sqrt <= maxValue)
            {
                counter = sqrt * sqrt;
                inc = sqrt + sqrt;

                while (counter <= maxValue)
                {
                    primeMembershipArray[counter] = false;
                    counter += inc;
                }

                sqrt += 2;

                while (!primeMembershipArray[sqrt])
                {
                    sqrt++;
                }
            }

            IEnumerable<int> result = Enumerable.Range(2, (int)maxValue).Where(l => primeMembershipArray[l]);
            return result;
        }

    }
}
