using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive: ");
            Console.WriteLine((firstNumber>0 && secondNumber<0) || (firstNumber < 0 && secondNumber > 0));

            Console.ReadKey();

        }
    }
}
