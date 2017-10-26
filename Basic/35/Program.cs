using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a first number(<100): ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number(>100): ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((firstNumber<100 && secondNumber>200)||(secondNumber<100 && firstNumber>200));
            Console.ReadKey();
        }
    }
}
