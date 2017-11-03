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
            Console.Write("Input the number of elements to be stored in the first array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            int k;

            for (int i = 0; i <a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the number of elements to be stored in the second array: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[b];
            int s = a + b;
            int[] arr3 = new int[s];
            
            for (int i = 0; i < b; i++)
            {
                Console.Write("element - {0}: ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <a; i++)
            {
                arr3[i] = arr[i];
            }
            for (int i = 0; i < b; i++)
            {
                arr3[i+a] = arr2[i];
            }

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s-1; j++)
                {
                    if (arr3[j] >= arr3[j+1])
                    {
                        k = arr3[j + 1];
                        arr3[j + 1] = arr3[j];
                        arr3[j] = k;

                    }
                } 
            }
            foreach (int i in arr3)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
