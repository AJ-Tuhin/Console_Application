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
            int[] element = new int[10];
            for (int i = 0; i < element.Length; i++)
            {
                Console.Write("Element {0}: ",i);
                element[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var value in element)
            {
                Console.Write(value+" ");
            }
            Console.ReadKey();
        }
    }
}
