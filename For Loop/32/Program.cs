using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i <=a/2; i++)
            {
                if (a%i==0)
                {
                    Console.WriteLine("{0} is not a prime number.",a);
                    count++;
                    break;
                }
            }
            if (count==0 & a!=1)
            {
                Console.WriteLine("{0} is a prime number.",a);
            }
            Console.ReadKey();
        }
    }
}
