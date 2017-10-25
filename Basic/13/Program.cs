using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}",number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);

            Console.ReadKey();
        }
    }
}
