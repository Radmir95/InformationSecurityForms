using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class AllDerivBelow
    {

        public ArrayList FindAllDerivBelow(int n) {

            var result = new ArrayList();

            for (var i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                }
            }
            result.Add(n);

            return result;

        }

    }
}
