using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the binary number: ");
            int binary = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            double result = 0;

            for (int i = binary; i >0; i=i/10)
            {
                int reminder = i % 10;
                if (reminder !=0)
                {
                    double j = Math.Pow(2, k);
                    result += j;
                }
                k++;
            }
            Console.WriteLine("The Binary Number: {0}",binary);
            Console.WriteLine("The equivalent Decimal Number is: {0}", result);
            Console.ReadKey();
        }
    }
}
