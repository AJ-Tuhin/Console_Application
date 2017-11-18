using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[a];

            Console.WriteLine("Input {0} elements in the array: ",a);
            for (int i = 0; i <a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = i+1; j < a; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        int temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            Console.WriteLine("Elements of the array in sorted descending order: ");
            foreach (int i in arr1)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
