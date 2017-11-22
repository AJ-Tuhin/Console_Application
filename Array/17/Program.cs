using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 5 elements in the array (value must be <9999) : ");
            int[] arr = new int[size];
           
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[i]<=arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                } 
            }
            Console.WriteLine("The Second smallest element in the array is : {0}",arr[1]);

            Console.ReadKey();
        }
    }
}
