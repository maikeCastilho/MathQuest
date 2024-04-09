using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathquest
{
    public class Multiples_number
    {
        public List<int> GetMultiplesFromNumber(int number)
        {
            List<int> multiples = new List<int>();

            int max_multiples = number * 10;

            for (int i = number; i <= max_multiples; i++)
            {
                if (i % number == 0)
                {
                    multiples.Add(i);
                }
            }
            return multiples;

        }
    }
}
