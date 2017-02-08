using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4exercises
{
    class primes
    {
        static void Main(string[] args)
        {

            for (int i = 2; i < 101; i++)
            {
                bool found = false;
                for (int j = 2; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("{0} is a prime.", i);
                }
            }
        }
    }
}
