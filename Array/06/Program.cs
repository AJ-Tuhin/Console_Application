using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[a];
            int[] arr2 = new int[a];
            int[] arr3 = new int[a];
            int m = 1;

            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                arr2[i] = arr[i];
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (arr[i]==arr2[j])
                    {
                        arr3[i] = m;
                        m++;
                    }
                }
                m = 1;
            }
            Console.WriteLine("The unique elements found in the array are: ");
            for (int i = 0; i < a; i++)
            {
                if (arr3[i]==1)
                {
                    Console.Write(arr[i]+" ");

                }
            }

            Console.ReadKey();
        }
    }
}
