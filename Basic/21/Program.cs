using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(CheckSum(firstNumber,secondNumber));

            Console.ReadKey();
        }

        public static bool CheckSum(int a, int b)
        {
            int sum = a + b;
            return (sum == 20 || a == 20 || b == 20)
            ?true:false;
        }
    }
}
