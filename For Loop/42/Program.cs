using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a binary number: ");
            int bNumber = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int result = 0,result1 =0 ;
            //int Decimal = Convert.ToInt32(bNumber,2);
            //Console.WriteLine(Decimal);

            for (int i = bNumber; i > 0; i = i / 10)
            {
                int reminder = i % 10;

                if (reminder == 1)
                {
                    result1 = (int) Math.Pow(2, a);
                }
                else
                {
                    a++;
                    continue;
                }
                result += result1;
                a++;
            }
            Console.WriteLine(result);

            //result = (int) Math.Pow(2, 2);
            //Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
