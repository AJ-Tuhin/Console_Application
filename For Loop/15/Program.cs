using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <=number ; i++)
            {
                result *= i;
            }
            Console.WriteLine("The Factorial of {0} is:{1}",number,result);
            Console.ReadKey();
        }
    }
}
