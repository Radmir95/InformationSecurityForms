using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace Functions
{
    public class MillerRabin
    {

        public MillerRabin()
        {
            FillSPP();
        }

        private static readonly List<BigInteger> SPP = new List<BigInteger>();

        private static readonly List<BigInteger> firstPrimes = new List<BigInteger>(); // спсок первых к простых чисел 

        public static void FillSPP()
        {
            SPP.Add(2047);
            SPP.Add(BigInteger.Parse("1373653"));
            SPP.Add(BigInteger.Parse("25326001"));
            SPP.Add(BigInteger.Parse("3215031751"));
            SPP.Add(BigInteger.Parse("2152302898747"));
            SPP.Add(BigInteger.Parse("3474749660383"));
            SPP.Add(BigInteger.Parse("341550071728321"));
            SPP.Add(BigInteger.Parse("341550071728321"));
            SPP.Add(BigInteger.Parse("3825123056546413051"));
            SPP.Add(BigInteger.Parse("3825123056546413051"));
            SPP.Add(BigInteger.Parse("3825123056546413051"));
            firstPrimes.Add(2);
            firstPrimes.Add(3);
            firstPrimes.Add(5);
            firstPrimes.Add(7);
            firstPrimes.Add(11);
            firstPrimes.Add(13);
            firstPrimes.Add(17);
            firstPrimes.Add(19);
            firstPrimes.Add(23);
            firstPrimes.Add(29);
            firstPrimes.Add(31);
            firstPrimes.Add(37);
            firstPrimes.Add(41);
            firstPrimes.Add(43);
            firstPrimes.Add(47);
            firstPrimes.Add(53);
        }

        private static BigInteger Sqrt(BigInteger n)

        {
            if (n == 0) return 0;
            if (n <= 0) throw new ArithmeticException("NaN");
            var bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
            var root = BigInteger.One << (bitLength / 2);

            while (!IsSqrt(n, root))
            {
                root += n / root;
                root /= 2;
            }

            return root;
        }

        public static bool IsSqrt(BigInteger n, BigInteger root)
        {
            var lowerBound = root * root;
            var upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound) && (n < upperBound);
        }

        public int SearchK(BigInteger n) //ищем минимальный индекс к в списке SPP для которых SPP[k] > n
        {
            var k = 0;
            var j = 0;
            while (j < SPP.Count)
            {
                if (SPP[k] < n)
                    k++;
                j++;
            }

            return k;
        }

        public int CountWitnessOfPrimeMillerRabin(BigInteger n)
        {

            if (n <= 1)
                return 1;
            if (n == 2)
                return 2;

            var t = n - 1;
            BigInteger a;
            var s = 0;
            while (t % 2 == 0)
            {
                //Представить n − 1 в виде 2s·t, где t нечётно, можно сделать последовательным делением n - 1 на 2.
                s++;
                t = t / 2;
            }

            var k = SearchK(n);
            k++;
            int count = 1;

            for (a = 2; a < n - 2; a++)
                for (var i = 0; i < k; i++)
                {

                    //a = RandomIntegerBelow(n - 1); // Выбрать случайное целое число a в отрезке [2, n − 2]
                    //a = firstPrimes[i];
                    var x = BigInteger.ModPow(a, t, n); // вычисляется с помощью алгоритма возведения в степень по модулю
                    if ((x == 1) || (x == n - 1))
                        continue; //то перейти на следующую итерацию цикла А

                    var kk = true;

                    Parallel.For(0, s - 1, (ii, loopState) =>
                    {
                        x = BigInteger.ModPow(x, 2, n);
                        if (x == 1)
                        {
                            count++;
                            loopState.Break();
                        }
                        if (x == n - 1)
                            loopState.Break();

                    });
                    if (!kk)
                        count = count ;

                    if (x != n - 1)
                        count = count;
                }

            return count;

        }

        public bool Miller_Rabin(BigInteger n) // return true если простое 
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            var n1 = Sqrt(n);
            if (n1 * n1 == n)
                return false;

            var t = n - 1;
            BigInteger x, a;
            var s = 0;
            while (t % 2 == 0)
            {
                //Представить n − 1 в виде 2s·t, где t нечётно, можно сделать последовательным делением n - 1 на 2.
                s++;
                t = t / 2;
            }

            var k = SearchK(n);
            k++;

            for (var i = 0; i < k; i++)
            {

                //a = RandomIntegerBelow(n - 1); // Выбрать случайное целое число a в отрезке [2, n − 2]
                a = firstPrimes[i];
                x = BigInteger.ModPow(a, t, n); // вычисляется с помощью алгоритма возведения в степень по модулю
                if ((x == 1) || (x == n - 1))
                    continue; //то перейти на следующую итерацию цикла А

                var kk = true;

                Parallel.For(0, s - 1, (ii, loopState) =>
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                    {
                        kk = false;
                        loopState.Break();
                    }
                    if (x == n - 1)
                        loopState.Break();

                });
                if (!kk)
                    return false;

                if (x != n - 1)
                    return false;
            }

            return true;
        }

    }
}
