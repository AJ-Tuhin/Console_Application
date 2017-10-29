using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch>='a' && ch<='z') || (ch >= 'A' && ch <= 'Z'))
            {
                if ((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') || 
                    (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'))
                {
                    Console.WriteLine("The alphabet is a vowel.");
                }
                else
                {
                    Console.WriteLine("The alphabet is a consonant.");
                }

            }
            else
            {
                Console.WriteLine("your entered item is not alphabet");
            }

            Console.ReadKey();
        }
    }
}
