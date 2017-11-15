using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[a];
            int[] arr2 = new int[a];
            int count = 0;   

            Console.WriteLine("Input {0} elements in the array: ",a);
            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <a; i++)
            {
                arr2[i] = arr[i];
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (arr[i]==arr2[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0} occurs {1} times",arr[i],count);
                count = 0;
            }


            Console.ReadKey();
        }
    }
}
