using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Integer: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second Integer: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            int a = Math.Abs(20 - fNumber);
            int b = Math.Abs(20 - sNumber);
            if (fNumber==sNumber)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(a > b ? sNumber : fNumber);
            }
            Console.ReadKey();
        }
    }
}
