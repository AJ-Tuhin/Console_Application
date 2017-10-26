using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hexadecimal number: ");
            string hexadesiNumber = Console.ReadLine();

            int deciValue = Convert.ToInt32(hexadesiNumber, 16);

            Console.WriteLine(deciValue);
            Console.ReadKey();
        }
    }
}
