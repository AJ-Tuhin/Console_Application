using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            for (int i = number; i !=0; i=i/10)
            {
                int reminder = i%10;
                reverse = reverse*10 + reminder;
            }
           Console.WriteLine(number==reverse?@"{0} is a palindrome number." 
               : "{0} is not a palindrome number.",number);

            Console.ReadKey();
        }
    }
}
