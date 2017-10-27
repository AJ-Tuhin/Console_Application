using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(year%4==0?@"{0} is a leap year.": "{0} is not a leap year.",year);
            Console.ReadKey();
        }
    }
}
