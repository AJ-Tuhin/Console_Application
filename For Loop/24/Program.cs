using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms: ");
            int term = Convert.ToInt32(Console.ReadLine());

            int x2 = x,count=1;
            double sum = 0;
            int j;

            for (int i = 1; i <= term*2; i++)
            {
                if (i%2!=0)
                {
                    for (j = 1; j < i; j++)
                    {
                        x2 *= x;

                    }
                    //Console.WriteLine(x2);
                    if (count % 2 != 0)
                    {
                        sum += x2;
                    }
                    else
                    {
                        sum -= x2;
                    }
                    //Console.WriteLine(sum);
                    count++;
                }
                x2 = x;
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
