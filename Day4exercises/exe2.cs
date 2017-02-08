using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4exercises
{
    class exe2
    {
        static void Main()
        {
            int a, b;
            int HCF=0, LCM=0;
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());

            int oa = a;
            int ob = b;

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else if( b > a )
                {
                    b -= a;
                }
                
            }

            if (a == b)
            {
                HCF = a;
                LCM = oa * ob / HCF;
            }


            Console.WriteLine("HCF : {0} \nLCM: {1}", HCF,LCM);


        }

    }
}
