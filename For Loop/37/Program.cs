using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to reverse: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("The number in reverse order is: ");
            for (int i = a; i !=0 ;i= i / 10)
            {
                int reminder = i%10;
                Console.Write(reminder);
            }
            Console.ReadKey();
        }
    }
}
