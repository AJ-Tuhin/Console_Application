using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string astring = Console.ReadLine();


           Console.WriteLine(Format(astring));
           Console.ReadKey();
        }

        private static string Format(string astring)
        {
            return astring.Length < 4 ? astring + astring + astring + astring:astring.Substring(astring.Length-4)+ astring.Substring(astring.Length - 4)+ astring.Substring(astring.Length - 4)+ astring.Substring(astring.Length - 4);
        }
    }
}
