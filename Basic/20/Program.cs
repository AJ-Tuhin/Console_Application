using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(DifferenceNumber(firstNumber,secondNumber));

            Console.ReadKey();

        }

        public static int DifferenceNumber(int a,int b)
        {
            return (a > b)
                ? Math.Abs(a - b)*2
                : b-a;

        }
    }
}
