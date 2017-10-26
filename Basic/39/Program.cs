using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third integer: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("Largest  Number {0}",firstNumber);
                Console.WriteLine("Lowgest  Number {0}", thirdNumber);
            }
            if (firstNumber > thirdNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("Largest  Number {0}", firstNumber);
                Console.WriteLine("Lowgest  Number {0}", secondNumber);
            }
            if (secondNumber > firstNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("Largest  Number {0}", secondNumber);
                Console.WriteLine("Lowgest  Number {0}", thirdNumber);
            }
            if (secondNumber > thirdNumber && thirdNumber > firstNumber)
            {
                Console.WriteLine("Largest  Number {0}", secondNumber);
                Console.WriteLine("Lowgest  Number {0}", firstNumber);
            }
            if (thirdNumber > secondNumber && secondNumber > firstNumber)
            {
                Console.WriteLine("Largest  Number {0}", thirdNumber);
                Console.WriteLine("Lowgest  Number {0}", firstNumber);
            }
            if (thirdNumber > firstNumber && firstNumber > secondNumber)
            {
                Console.WriteLine("Largest  Number {0}", thirdNumber);
                Console.WriteLine("Lowgest  Number {0}", secondNumber);
            }

            Console.ReadKey();

        }
    }
}
