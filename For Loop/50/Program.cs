using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert: ");
            int dNumber = Convert.ToInt32(Console.ReadLine());

            int a = 1;
            int octal = 0;
            for (int i = dNumber; i >0; i=i/8)
            {
                int reminder = i%8;
                int b = a*reminder;
                octal += b;
                a *= 10;    
            }

            Console.Write("The Octal of {0} is {1}.",dNumber,octal);
            Console.ReadKey();
        }
    }
}
