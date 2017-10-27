using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a symbol: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch=='a'|| ch == 'e'|| ch == 'i'|| ch == 'o'|| ch == 'u')
            {
                Console.WriteLine("it is a vowel");
            }
            else if (ch>'1' && ch<='9')
            {
                Console.WriteLine("It is a number");
            }
            else
            {
                Console.WriteLine("it is other symbol");
            }

            Console.ReadKey();
        }
    }
}
