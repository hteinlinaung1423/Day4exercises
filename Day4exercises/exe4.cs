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
            double g = x.Next(1, num+1);

            double sqrnum = Math.Round(Math.Sqrt(num),5);
            Console.WriteLine("Random number : {0:0.000}", g);
            Console.WriteLine("Squareroot number : {0:0.000}", sqrnum);


            g *= g;

            if (g == num)
            {
                Console.Write("Corret output : {0}", g);
            }
            else if (num == 0)
            {
                Console.WriteLine("Nearest output : 0.000");
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
