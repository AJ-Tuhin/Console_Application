using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the starting number of the A.P. series: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number of items for the A.P. series: ");
            int range = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the common difference of A.P. series: ");
            int diff = Convert.ToInt32(Console.ReadLine());

            int sum = sNumber;
            int result = 0;
            for (int i = 1; i <= range; i++)
            {
                result += sum;
                Console.Write(sum);
                if (i<range)
                {
                    Console.Write(" + ");
                }
                sum += diff;
            }
            Console.Write(" = {0}",result);
            Console.ReadKey();
        }
    }
}
