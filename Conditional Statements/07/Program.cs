using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your height(in centimeter): ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height<150)
            {
                Console.WriteLine("you are Dwarf.");
            }
            else if (height >150 && height<165)
            {
                Console.WriteLine("you are average.");
            }
            else if (height > 165 && height < 195)
            {
                Console.WriteLine("you are tall.");
            }
            else
            {
                Console.WriteLine("your height is abnormal.");
            }
            Console.ReadKey();
        }
    }
}
