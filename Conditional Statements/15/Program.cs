using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of first Angle: ");
            int angleA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of second Angle: ");
            int angleB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of third Angle: ");
            int angleC = Convert.ToInt32(Console.ReadLine());

            int sum = angleA + angleB + angleC;

            
            Console.WriteLine(sum == 180
                ?"The triangle is valid.": 
                "The triangle is not valid.");
            
            Console.ReadKey();
        }
    }
}
