using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number of terms: ");
            int term = Convert.ToInt32(Console.ReadLine());
            double fac = 1;
            int x2 = x;
            double sum = 1+x;
            for (int i = 2; i <term; i++)
            {

                for (int j = 2; j <=i; j++)
                {
                    fac *= j;
                    x2 *= x;

                }
                double result = x2/fac;
                sum += result;
                fac = 1;
                x2 = x;
            }
            Console.WriteLine("The sum is:"+sum);
            Console.WriteLine("Number of terms = {0}",term);
            Console.WriteLine("The value of x= {0}",x);
            Console.ReadKey();
        }
    }
}
