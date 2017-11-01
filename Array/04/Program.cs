using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array : ",a);
            int[] arr1 = new int[a];
            int[] arr2 = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write("element - 0: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("The elements stored in the first array are: ");
            foreach (var value in arr1)
            {
                Console.Write(value+" ");
            }
            Console.WriteLine("\nThe elements copied into the second array are: ");
            foreach (var value in arr2)
            {
                Console.Write(value + " ");
            }
            Console.ReadKey();
        }
    }
}
