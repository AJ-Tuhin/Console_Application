using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 10 numbers:");
            double result = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.Write("Number-{0}: ",i);
                double number = Convert.ToInt32(Console.ReadLine());
                result += number;
            }
            double average = result/10;
            Console.WriteLine("The sum of 10 no is: {0}",result);
            Console.WriteLine("The Average is : {0}", average);
            Console.ReadKey();
        }
    }
}
