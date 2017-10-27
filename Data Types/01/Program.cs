using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter latter: ");
            char latter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter latter: ");
            char latter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter latter: ");
            char latter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}",latter3,latter2,latter1);

            Console.Read();
        }
    }
}
