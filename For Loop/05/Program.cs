using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of terms: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                double result = i*i*i;
                Console.WriteLine("Number is : {0} and cube of the {0} is :{1}",i,result);
            }
            Console.ReadKey();
        }
    }
}
