using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i <5; i++)
            {
                for (int j =0 ; j <= i; j++)
                {
                    Console.Write(count+1);
                    count++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
