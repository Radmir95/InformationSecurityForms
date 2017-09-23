using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityForms
{
    public partial class SvidPrime : Form
    {
        public SvidPrime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var a = BigInteger.Parse(numberA.Text.ToString());
            var n = BigInteger.Parse(numberN.Text.ToString());

            var res = SvPrime(n, a);

            if (res)
                result.Text = "Свидетель простоты";
            else
                result.Text = "Не свидетель простоты";

        }

        private static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n <= 0) throw new ArithmeticException("NaN");
            var bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
            var root = BigInteger.One << (bitLength / 2);

            while (!isSqrt(n, root))
            {
                root += n / root;
                root /= 2;
            }

            return root;
        }

        public static bool isSqrt(BigInteger n, BigInteger root)
        {
            var lowerBound = root * root;
            var upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound) && (n < upperBound);
        }

        public bool SvPrime(BigInteger number, BigInteger a)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;

            var t = number - 1;
            BigInteger x;
            var s = 0;
            while (t % 2 == 0)
            {
                //Представить n − 1 в виде 2s·t, где t нечётно, можно сделать последовательным делением n - 1 на 2.
                s++;
                t = t / 2;
            }

            x = BigInteger.ModPow(a, t, number); // вычисляется с помощью алгоритма возведения в степень по модулю

            if ((x == 1) || (x == number - 1))
                return true; 

            var kk = true;

            // второе условие от 0 до s - 1
            Parallel.For(0, s - 1, (ii, loopState) =>
            {
                x = BigInteger.ModPow(x, 2, number);
                if (x == 1)
                {
                    kk = false;
                    loopState.Break();
                }
                if (x == number - 1)
                {
                    loopState.Break();
                    
                }

            });

            if (x != number - 1)
                return false;

            return kk;
        }

    }
}
