using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double d, x1, x2;

            Console.Write("Enter the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of c : ");
            int c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("First  Root Root1= {0}", x1);
                Console.WriteLine("Second Root Root2= {0}", x2);
            }
            else if (d > 0)
            {
                
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("First  Root Root1= {0}", x1);
                Console.WriteLine("Second Root root2= {0}", x2);
            }
            else
            {
                Console.Write("Root are imeainary;\nNo Solution.");
            }
            Console.ReadKey();
        }
    }
}
