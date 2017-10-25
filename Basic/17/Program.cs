using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            string s = str.Substring(0, 1);

            string str2 = s + str + s;
            Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}
