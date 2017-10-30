using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of terms: ");
            int number =Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            Console.Write("The even numbers are: ");
            for (int i = 1; count<number; i++)
            {
                if (i%2==0)
                {
                    sum += i;
                    Console.Write(i+" ");
                    count++;
                }
            }
            
            Console.WriteLine("\nThe Sum of even Natural Number upto {0} terms : {1}",number,sum);
            Console.ReadKey();
        }
    }
}
