using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.App
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 4;
            int[] array1 = new int[4] { 1, 3, -5, 4 };
            int[] array2 = new int[4] { 1, 4, -5, -2 };
            int[] array3 = new int[4];
            
            Console.WriteLine("Array1: [{0}]",string.Join(" ",array1));
            Console.WriteLine("Array2: [{0}]",string.Join(" ",array2));

            for (int i = 0; i <array1.Length; i++)
            {
                array3[i] = array1[i]*array2[i];

            }
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    Console.Write(array3[i] + " ");
            //}

            foreach (int value in array3)
            {
                Console.Write(value+" ");
            }

            Console.ReadKey();
        }
    }
}
