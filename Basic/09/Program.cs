using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            Console.Write("Enter the First number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int fourthNumber = int.Parse(Console.ReadLine());

            int add = firstNumber + secondNumber + thirdNumber + fourthNumber;
            int average = add/4;

            Console.WriteLine("Expected Output:");
            Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4} ",firstNumber,secondNumber,thirdNumber,fourthNumber, average);
            Console.Read();

        }
    }
}
