using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int i;
            int j;
            int count2 = 0;
            int result = 0;
            Console.WriteLine("Sum of the first 500 prime numbers: ");
            
                for (i = 2;count2 < 500; i++)
                {
                    count = 0;

                    for (j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                            break;
                        }
                    }


                    if (count == 0 && i != 1)
                    {
                        Console.WriteLine(i);
                        result += i;
                        count2++;
                    }


                }
            Console.WriteLine("sum is {0}", result);
            Console.ReadKey();
        }
    }
}
