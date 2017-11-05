using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of half of diamond: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2*i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i =r-1; i >=1; i--)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        
      } 
}
