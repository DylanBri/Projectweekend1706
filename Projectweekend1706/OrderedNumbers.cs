using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectweekend1706
{
    public class OrderedNumbers : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static List<int> Primes()
        {
            List<int> list = new List<int>();
            for (int i = 1000; i <= 9999; i++)
            {
                int number = i, a = 0;
                for (int j = 1; j <= number; j++)
                {
                    if (number % j == 0)
                    {
                        a++;
                    }
                }
            
                if (a == 2)
                {
                    list.Add(number);
                }
            }
            return list;
        }

    }
}

