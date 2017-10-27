using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input an operator amonge +,-,*,/: ");
            char opera = Convert.ToChar(Console.ReadLine());

            if (opera == '+')
            {
                Console.WriteLine("{0} + {1} = {2}",firstNumber,secondNumber,firstNumber+secondNumber);
            }
            else if (opera == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
            }
            else if (opera == '*')
            {
                Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);
            }
            else if (opera == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            }

            else
            {
                Console.WriteLine("you entered invalid operator");
            }
            Console.Read();
        }
    }
}
