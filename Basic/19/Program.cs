using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _19.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SumTriple(firstNumber,secondNumber));

            Console.ReadKey();
        }

        public static int SumTriple(int a,int b)
        {
            return (a == b)
                ? (a+b)*3 : a+b;
        }
    }
}
