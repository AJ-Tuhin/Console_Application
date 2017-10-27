using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double radious = Convert.ToDouble(Console.ReadLine());

            const double pi = 3.1416;
            double surface = 4*pi*(radious*radious);
            double volume = (4f/3f) * pi*(radious*radious*radious);

            Console.WriteLine("surface= {0}",surface);
            Console.WriteLine("volume= {0}",volume);

            Console.ReadKey();
        }
    }
}
