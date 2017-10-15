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

        private const int deriv = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            var p = int.Parse(p1.Text);
            var q = int.Parse(q1.Text);

            n1.Text = "n = " + p * q;

            var result = NumOfWitnessOfPrime(p, q);

            result1.Text = result.ToString();
        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            var stopWatch = Stopwatch.StartNew();
            // var upperNum = BigInteger.Parse(upperNumber.Text);
            var upperNum = Int32.Parse(upperNumber.Text);

            var result = Sieve(upperNum).ToList();

            tbpq.ResetText();
            tbresult.ResetText();

            for (int i = 1; i < result.Count; i++)
                for (int j = 0; j < i; j++)
                {

                    var p = result[i];
                    var q = result[j];

                    if (p * q > upperNum) continue;
                    var wtnprm = NumOfWitnessOfPrime(p, q);

                    var patternpq = "p = {0}, q = {1} ";

                    var patternwtnprm = "Result= {0}, F(n)/4 = {1} \n";

                    var fn = (p - 1) * (q - 1);

                    tbpq.AppendText(string.Format(patternpq, p, q));
                    tbpq.AppendText(string.Format(patternwtnprm, wtnprm, fn/4));

                }


            stopWatch.Stop();

            watchtime.Text = stopWatch.ElapsedMilliseconds.ToString();

        }

        private int NumOfWitnessOfPrime(BigInteger p, BigInteger q)
        {

            //find Del P and Del Q
            var delp = adb.FindAllDerivBelow(p - 1);
            var delq = adb.FindAllDerivBelow(q - 1);

            // intersection of Del P and Del Q
            var intersp = delp.ToArray().Intersect(delq.ToArray()).ToList();

            // Step 2
            var step2 = new Dictionary<int, int>();

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

        public static IEnumerable<BigInteger> Sieve(Int32 maxValue)
        {
            if (maxValue < 10)
            {
                if (maxValue == 9 || maxValue == 8 || maxValue == 7)
                {
                    return new List<BigInteger>() { 2, 3, 5, 7 };
                }
                else if (maxValue == 6 || maxValue == 5)
                {
                    return new List<BigInteger>() { 2, 3, 5 };
                }
                else if (maxValue == 4 || maxValue == 3)
                {
                    return new List<BigInteger>() { 2, 3 };
                }
                else
                {
                    return new List<BigInteger>() { 2 };
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
            return result.Select(i => new BigInteger(i));
        }


    }
}
