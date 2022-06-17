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

        public List<int> Prisme(int number)
        {
            List<int> Premier = new List<int>();
            int m = number / 2;
            bool flag = false;
            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Premier.Add(number);
            }
            return Premier;
        }

    }
}