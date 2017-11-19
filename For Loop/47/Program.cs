using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number to check whether it is Strong number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int result = 0;

            for (int i = number; i >0; i=i/10)
            {
                int reminder = i%10;

                for (int j = 1; j <=reminder; j++)
                {
                    factorial *= j;
                }
                result += factorial;
                factorial = 1;
            }
            Console.WriteLine(number == result ? "{0} is a Strong number." : "{0} is not a Strong number.", number);
            Console.ReadKey();
        }
    }
}
