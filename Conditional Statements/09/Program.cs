using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x>0 && y>0)
            {
                Console.WriteLine("The coordinate point({0}, {1}) lies in the First quadrant.",x,y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point({0}, {1}) lies in the Second quadrant.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point({0}, {1}) lies in the Third quadrant.", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate point({0}, {1}) lies in the Fourth quadrant.", x, y);
            }
            else
            {
                Console.WriteLine("The coordinate point ({0} {1}) lies at the origin.",x,y);
            }
            Console.ReadKey();
        }
    }
}
