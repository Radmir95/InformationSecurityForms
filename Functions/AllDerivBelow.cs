using System.Collections;
using System.Numerics;

namespace Functions
{
    public class AllDerivBelow
    {

        public ArrayList FindAllDerivBelow(BigInteger n) {

            var result = new ArrayList();

            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                }
            }
            result.Add(int.Parse(n.ToString()));

            return result;

        }

    }
}
