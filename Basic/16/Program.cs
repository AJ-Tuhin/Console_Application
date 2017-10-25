using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string firstString = Console.ReadLine();

            Console.Write("Enter second string: ");
            string secondString = Console.ReadLine();

            Console.WriteLine(First_last(firstString));
            Console.WriteLine(First_last(secondString));

            //Console.WriteLine(firstString.Substring(firstString.Length - 1));

            Console.ReadKey();

        }

        public static string First_last(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
                : str;
        }
        
    }
}
