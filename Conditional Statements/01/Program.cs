using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            if (fNumber==sNumber)
            {
                Console.WriteLine("{0} and {1} are equal",fNumber,sNumber);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", fNumber, sNumber);
            }
            Console.ReadKey();
        }
    }
}
