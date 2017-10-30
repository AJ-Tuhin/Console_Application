using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number or terms: ");
            int term = Convert.ToInt32(Console.ReadLine());
            int t = 9;
            int sum = 0;
            for (int i = 1; i <= term; i++)
            {
                sum += t;
                Console.Write(t+" ");
                t = 10*t + 9;
                
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the series ={0}",sum);
            Console.ReadKey();
        }
    }
}
