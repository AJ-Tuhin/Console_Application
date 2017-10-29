using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input upto the table number starting from 1: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    Console.Write("{0}x{1} = {2}, ",j,i,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
