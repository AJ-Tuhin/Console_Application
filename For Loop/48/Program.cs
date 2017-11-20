using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input starting range of number: ");
            int startRange = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending range of number: ");
            int endRange = Convert.ToInt32(Console.ReadLine());

            int fac = 1;
            int result = 0;

            Console.WriteLine("The Strong numbers are: ");
            for (int i = startRange; i <=endRange; i++)
            {
                for (int j = i; j >0; j=j/10)
                {
                    int reminder = j % 10;

                    for (int k = 1; k <= reminder; k++)
                    {
                        fac *= k;
                    }
                    result += fac;
                    fac = 1;
                }

                if (result==i)
                {
                    Console.Write(i+" ");
                }
                result = 0;
            }
            Console.ReadKey();
        }
    }
}
