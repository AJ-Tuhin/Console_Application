using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number to multiply: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = firstNumber*secondNumber*thirdNumber;

            Console.WriteLine("Expected Output:");
            Console.WriteLine("{0} x {1} x {2} = {3}",firstNumber,secondNumber,thirdNumber,result);

            Console.Read();
        }
    }
}
