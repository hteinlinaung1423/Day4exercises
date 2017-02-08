using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4exercises
{
    class exe4
    {
        static void Main()
        {
            int num;

            bool needtorepeat = true;

            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Random x = new Random();
            double g = x.Next(1, num);

            double sqrnum = Math.Round(Math.Sqrt(num),3);
            Console.WriteLine("Random number : {0:0.000}", g);

            

            g *= g;

            if (g == sqrnum)
            {
                Console.Write("Corret output : {0}", g);
            }
            else
            {
                while (needtorepeat)
                {
                    g = (g + num / g) / 2;
                    if ((g * g - num) < 0.00001)
                    {
                        needtorepeat = false;
                        Console.WriteLine("Nearest output : {0:0.000}", g);

                    }
                }
               

            }

        }
    }
}
