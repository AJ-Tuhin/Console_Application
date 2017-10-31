using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of term: ");
            int term = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            int sqr = 0;
            int sum = 0;
            Console.Write("The square natural upto {0} terms are : ",term);
            for (int i = 1; i <=term; i++)
            {
                sqr = j*j;
                sum += sqr;
                Console.Write(sqr+" ");
                j++;

            }
            
            Console.WriteLine("\nThe Sum of Square Natural Number upto {0} terms = {1}",term,sum);
            Console.ReadKey();
        }
    }
}
