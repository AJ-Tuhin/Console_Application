using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number%2==0)
            {
                Console.WriteLine("{0} is an even integer",number);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer", number);
            }
            Console.ReadKey();
        }
    }
}
