using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an octal number (using digit 0 - 7): ");
            uint octal = Convert.ToUInt32(Console.ReadLine());

            uint a = 0;
            uint sum = 0;

            for (uint i = octal; i >0; i=i/10)
            {
                uint reminder = i%10;
                double b = reminder * Math.Pow(8, a);
                sum += (uint)b;
                a++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
