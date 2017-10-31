using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            Console.Write("The positive divisor: ");
            for (int i = 1; i <=num/2; i++)
            {
                if (num%i==0)
                {
                    sum += i;
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine("\nThe sum of the divisor is : {0}",sum);
            if (sum==num)
            {
                Console.WriteLine("This is a perfect number!");
            }
            else
            {
                Console.WriteLine("This is not a perfect number!");
            }
            
            Console.ReadKey();
        }
    }
}
