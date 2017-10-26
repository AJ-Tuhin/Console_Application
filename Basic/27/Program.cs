using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number(integer): ");
            int number = int.Parse(Console.ReadLine());

            int mod = 0;
            int result = 0;

            while (number>0)
            {
                int m = number%10;
                mod += m;
                number = number/10;
                if (number<10)
                {
                    result = mod + number;
                }

            }
            Console.WriteLine("Sum of the digits of the said integer:{0}",result);
            Console.ReadKey();
        }
    }
}
