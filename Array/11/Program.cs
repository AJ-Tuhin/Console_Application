using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[a];
            
            Console.WriteLine("Input {0} elements in the array",a);
            for (int i = 0; i < a; i++)
            {
                Console.Write("element - 0: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <arr1.Length-1; i++)
            {
                if (arr1[i] > arr1[i + 1])
                {
                    int temp = arr1[i + 1];
                    arr1[i + 1] = arr1[i];
                    arr1[i] = temp;
                }
            }
            
            Console.WriteLine("Elements of array in sorted ascending order: ");
            foreach (int value in arr1)
            {
                Console.Write(value+" ");    
            }
            Console.ReadKey();
        }
    }
}
