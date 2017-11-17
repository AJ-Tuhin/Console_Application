using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[a];
            int[] arr2 = new int[a+1];

            Console.WriteLine("Input {0} elements in the array in ascending order: ",a);
            for (int i = 0; i <a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr2[i] = arr1[i];
            }

            Console.Write("Input the value to be inserted: ");
            arr2[a] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr2.Length-1; i++)
            {
                if (arr2[i] > arr2[i+1])
                {
                    int temp = arr2[i+1];
                    arr2[i+1] = arr2[i];
                    arr2[i] = temp;
                }
            }
            Console.WriteLine("The exist array list is: ");
            foreach (int i in arr1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nAfter Insert the list is: ");
            foreach (int i in arr2)
            {
                Console.Write(i+" ");
            }

            Console.ReadKey();
        }
    }
}
