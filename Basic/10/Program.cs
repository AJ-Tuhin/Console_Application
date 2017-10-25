using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            Console.Write("Enter first number - ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number - ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number - ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int result1 = (firstNumber + secondNumber)*thirdNumber;
            int result2 = (firstNumber*secondNumber) + (secondNumber*thirdNumber);
            Console.WriteLine("Expected Output:");
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}",firstNumber,secondNumber,thirdNumber,result1,result2);

            Console.ReadKey();
        }
    }
}
