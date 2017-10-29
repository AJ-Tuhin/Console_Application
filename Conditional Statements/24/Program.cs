using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.App
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            double area = 0;
            Console.WriteLine("Input 1 for area of circle");
            Console.WriteLine("Input 2 for area of rectangle");
            Console.WriteLine("Input 3 for area of triangle");

            Console.Write("Input your choice: ");
            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.Write("Enter the radious of the circle: ");
                    double radious = Convert.ToDouble(Console.ReadLine());
                    area = pi*(radious*radious);
                    break;

                case 2:
                    Console.Write("Enter the length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());

                    area = length*width;
                    break;

                case 3:
                    Console.Write("Enter the base of the triangle: ");
                    double base1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    area = .5*height*base1;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
            Console.WriteLine("The area  is: {0}", area);
            Console.ReadKey();
        }
    }
}
