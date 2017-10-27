using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter a number: 6
            //Enter the desired width: 6

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int reduceWidth = width;

            for (int i = 1; i <= width; i++)
            {
                for (int j = reduceWidth; j >0; j--)
                {
                    Console.Write(number);
                }
                reduceWidth -= 1;
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
