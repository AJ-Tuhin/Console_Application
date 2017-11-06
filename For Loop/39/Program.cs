using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Numbers between 100 and 200, divisible by 9: \n");
            for (int i = 100; i <=200; i++)
            {
                if (i%9==0)
                {
                    Console.Write(i+" ");
                    sum += i;
                }
            }
            Console.WriteLine("\nThe sum:{0}",sum);
            Console.ReadKey();
        }
    }
}
