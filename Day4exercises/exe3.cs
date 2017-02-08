using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4exercises
{
    class exe3
    {
        static void Main()
        {
            int num, times=0;
            
            
            bool needtorepeat = true;

            while (needtorepeat)
            {
                Console.Write("Enter a number between 0 and 9 : ");
                int input = Convert.ToInt32(Console.ReadLine());
                times++;
                Random rnum = new Random();
                num = rnum.Next(0, 9);

                Console.WriteLine("The correct number is {0}", num);

                if (num == input)
                {
                    if (times <= 2)
                    {
                        Console.WriteLine("You are a Wizzard!");
                    }
                    else if (times == 3)
                    {
                        Console.WriteLine("You are a good guess!");
                    }
                    else
                    {
                        Console.WriteLine("You are a lousy!");
                    }

                    needtorepeat = false;
                }
                else {
                    Console.WriteLine("Try again!");
                }

            }
        

        }
    }
}
