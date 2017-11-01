using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[a];
            Console.WriteLine("Input {0} number of elements in the array: ",a);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("element - 0: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are: ");
            foreach (int value in arr1)
            {
                Console.Write(+value+" ");
            }
            
            Console.WriteLine("\nThe values store into the array in reverse are: ");
            for (int i = a-1; i >=0; i--)
            {
                Console.Write(+arr1[i]+" ");
            }


            Console.ReadKey();
        }
    }
}
