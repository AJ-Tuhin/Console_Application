using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[a+1];
            //int[] arr2 = new int[a+1];

            Console.WriteLine("Input {0} elements in the array: ",a);
            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}: ",i+1);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                //arr2[i] = arr1[i];
            }

            Console.Write("Input the value to be inserted: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Position, where the value to be inserted: ");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = arr1.Length-1; i >= c; i--)
            {
                arr1[i] = arr1[i - 1];
            }
            arr1[c - 1] = b;

            foreach (int i in arr1)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();

        }
    }
}
