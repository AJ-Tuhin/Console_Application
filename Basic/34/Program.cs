using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string astring = Console.ReadLine();

            string a = "hello";
            Console.WriteLine(astring.Substring(0,5)==a);
            Console.ReadKey();
        }
    }
}
