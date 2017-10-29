using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the month: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            if (monthNumber<13 && monthNumber>0)
            {
                if (monthNumber == 2)
                {
                    Console.WriteLine("if the Month is leap year it has 29 days or it 28 days");
                }
                else if ((monthNumber % 2 != 0) || (monthNumber == 12) || (monthNumber == 8))
                {
                    Console.WriteLine("Month have 31 days");
                }

                else
                {
                    Console.WriteLine("Month have 30 days");
                }
            }
            else
            {
                Console.WriteLine("Invalid month Number");
            }
            
            Console.ReadKey();

        }
    }
}
