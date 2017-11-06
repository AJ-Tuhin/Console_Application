using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                    
                }
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
