
using System.Numerics;

namespace Functions
{
    public class EylerFunction
    {

        public static int FindEylerFunctionInt(int n)
        {

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

            return result;


        }

        public static BigInteger FindEylerFunctionBig(BigInteger n)
        {

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

            return result;


        }

    }
}
