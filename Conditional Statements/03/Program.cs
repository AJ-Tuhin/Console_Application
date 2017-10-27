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

            if (number>0)
            {
                Console.WriteLine("{0} is a positive number",number);
            }
            else if(number<0)
            {
                Console.WriteLine("{0} is a negative number", number);
            }
            else
            {
                Console.WriteLine("this is a zero");
            }
            Console.ReadKey();
        }
    }
}
