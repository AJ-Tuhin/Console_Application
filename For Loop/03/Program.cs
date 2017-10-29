using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first {0} natural number is:",number);
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i+" ");
                result += i;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of Natural Number upto {0} terms : {1}",number,result);
            Console.ReadKey();
        }
    }
}
