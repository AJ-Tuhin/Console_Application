using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int digit = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}",digit);
            Console.WriteLine("{0}{0}{0}{0}", digit);
            Console.WriteLine("{0} {0} {0} {0}", digit);
            Console.WriteLine("{0}{0}{0}{0}", digit);

            Console.ReadKey();
        }
    }
}
