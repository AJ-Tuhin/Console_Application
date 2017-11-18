using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];

            Console.WriteLine("Input {0} elements in the array: ",a);
            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = i+1; j < a; j++)
                {
                    if (arr[i]<arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }                
           
            Console.WriteLine("The Second largest element in the array is: {0}",arr[1]);
            Console.ReadKey();
        }
    }
}
