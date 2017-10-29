using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of terms: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int j = 1;
            int count = 0; 
            Console.Write("\nThe odd numbers are: ");
            while (count < number)
            {
                if (j % 2 != 0)
                {
                    Console.Write(j + ",");
                    sum += j;
                    count++;
                }
                j++;
            }
            
            Console.WriteLine("\nThe Sum of odd Natural Number upto 10 terms : {0}",sum);
            Console.ReadKey();
        }
    }
}
