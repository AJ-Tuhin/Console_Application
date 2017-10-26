using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((firstNumber>= -10 && firstNumber<=10)||(secondNumber>=-10 && secondNumber<=10));
            Console.ReadKey();
        }
    }
}
