using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fNumber%2==0 && sNumber%2==0?true:false);
            Console.ReadKey();
        }
    }
}
