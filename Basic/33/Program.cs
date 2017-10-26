using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number%3==0 || number%7==0);
            Console.ReadKey();
        }
    }
}
