using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number of the G.P. series: ");
            uint fNumber = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Input the number or terms in the G.P. series: ");
            uint term = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Input the common ratio of G.P. series: ");
            uint ratio = Convert.ToUInt32(Console.ReadLine());

            uint sum = 0;
            uint result = fNumber;
            uint tn=0;
            Console.WriteLine("The numbers for the G.P. series: ");
            for (int i = 0; i <=term; i++)
            {
                if (i== term - 1)
                {
                    tn = result;
                }
                Console.Write(result+" ");
                sum += result;
                result *= ratio;
            }
            Console.WriteLine("\nThe tn terms of G.P.: {0}",tn);
            Console.WriteLine("The Sum of the G.P. series:{0}",sum);
            Console.ReadKey();
        }
    }
}
