using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            int[] arr2 =new int[a];
            int[] arr3 = new int[100];
            int count = 0, m = 1;

            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}: ",i+1);
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
                        arr3[j] = m;
                        m++;
                    }
                }
                m = 1;
            }
            foreach (int t in arr3)
            {
                if (t == 2)
                {
                    count++;
                }
            }
            Console.WriteLine("Total number of duplicate elements found in the array is: {0}",count);

            Console.ReadKey();
        }
    }
}
