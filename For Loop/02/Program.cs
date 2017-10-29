using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("The first 10 natural number is:");
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i+" ");
                result += i;
            }
            Console.WriteLine();
            Console.WriteLine("The sum is {0}",result);
            Console.ReadKey();
        }
    }
}
