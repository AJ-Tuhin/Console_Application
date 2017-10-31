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
            Console.Write("Enter the number of term: ");
            int term = Convert.ToInt32(Console.ReadLine());
            int t=0 ;
            int sum = 0;
            for (int i = 0; i < term; i++)
            {
                t = t*10 + 1;
                sum += t;
                Console.Write("{0}+",t);
            }
            Console.WriteLine("\nThe Sum is: {0}",sum);
            Console.ReadKey();
        }
    }
}
