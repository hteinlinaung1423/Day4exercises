using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4exercises
{
    class exe1
    {
        static void Main()
        {
            int num;
            bool needtorepeat = true;
            

            while(needtorepeat)
            {
                Console.Write("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 88)
                {
                    Console.WriteLine("Lucky you!");
                    needtorepeat = false;
                }

                

            }
        }
    }
}
