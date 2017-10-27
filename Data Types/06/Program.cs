using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x = y2 + 2y + 1 ");

            for (int y = -5; y <=5; y++)
            {
                int x = y*y - 2*(y) + 1;
                Console.WriteLine("y={0}, x= ({0})2 + 2*{0} + 1={1}",y,x);
            }

            Console.ReadKey();
        }
    }
}
