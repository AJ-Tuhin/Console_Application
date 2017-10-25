using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            int kelvin = celsius + (int)273.15;
            double fahrenheit = (celsius *1.8 ) + 32;

            Console.WriteLine("Kelvin = {0}",kelvin);
            Console.WriteLine("Fahrenheit = {0}",fahrenheit);

            Console.ReadKey();
        }
    }
}
