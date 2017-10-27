using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.App
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            Console.Write("Input the radius of the circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = pi*(radius*radius);
            double paramiter = 2*pi*radius;

            Console.WriteLine("Perimeter of Circle :{0}",paramiter);
            Console.WriteLine("Area of the circle:{0}",area);
            Console.ReadKey();
        }
    }
}
