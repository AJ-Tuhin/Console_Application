using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int add = firstNumber + secondNumber;
            int sub = firstNumber - secondNumber;
            int multiply = firstNumber * secondNumber;
            int divide = firstNumber / secondNumber;
            int mod = firstNumber%secondNumber;

            Console.WriteLine("Expected Output: ");
            Console.WriteLine("{0} + {1} = {2}",firstNumber,secondNumber,add);
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, sub);
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, multiply);
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, divide);
            Console.WriteLine("{0} mod {1} = {2}", firstNumber, secondNumber, mod);

            Console.Read();
        }
    }
}
