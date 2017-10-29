using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _20.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string day;

            switch (dayNumber)
            {
                case 1:
                    day = "Saterday";
                    break;

                case 2:
                    day = "Sunday";
                    break;

                case 3:
                    day = "Monday";
                    break;

                case 4:
                    day = "Tuesday";
                    break;

                case 5:
                    day = "Wednesday";
                    break;

                case 6:
                    day = "Thursday";
                    break;

                case 7:
                    day = "Friday";
                    break;

                default:
                    day = "Invalid day Number";
                    break;
            }
            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}
