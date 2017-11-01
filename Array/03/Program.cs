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
            Console.Write("Input the number of elements to be stored in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[a];
            int sum = 0;
            Console.WriteLine("Input 3 elements in the array: ");
            for (int i = 0; i < a; i++)
            {
                Console.Write("element - 0: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum of all elements stored in the array is: "+sum);
            Console.ReadKey();
        }
    }
}
