using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            double term = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <=term; i++)
            {
                double d = 1/ (double)i;
                sum += d;
            }
            Console.WriteLine("Sum of Series upto {0} terms :{1}",term,sum);
            Console.ReadKey();
        }
    }
}
