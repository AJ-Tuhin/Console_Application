using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the starting range or number: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending range or number: ");
            int lNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("The Perfect numbers within the given range: ");
            for (int i = fNumber; i <=lNumber; i++)
            {
                for (int j = 1; j <=i/2; j++)
                {
                    if (i%j==0)
                    {
                        sum += j;
                    }
                }
                if (i==sum)
                {
                    Console.Write(i+" ");
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
            }
            Console.ReadKey();

        }
    }
}
