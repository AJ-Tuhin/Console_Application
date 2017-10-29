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
            Console.Write("Input side 1 of triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input side 2 of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input side 3 of triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a==b || a==c||b==c)
            {
                if (a==b && b==c)
                {
                    Console.WriteLine("This is an Equilateral triangle.");
                }
                else
                {
                    Console.WriteLine("This is an isosceles triangle.");
                }
            }
            else
            {
                Console.WriteLine("This is an Scalene triangle.");
            }

            Console.ReadKey();
        }
    }
}
