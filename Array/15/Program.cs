using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
 
            Console.Write("Input {0} elements in the array in ascending order:\n",a);

            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the position where to delete: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                if (i==b-1)
                {
                    continue;
                }
                else
                {
                    Console.Write(arr[i]+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
