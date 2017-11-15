using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[a];
              
            Console.WriteLine("Input {0} elements in the array",a);

            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i <a; i++)
            {
                if (max <= arr[i])
                {
                    max = arr[i];
                }
                if (min >= arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element is: {0}",max);
            Console.WriteLine("Minimum element is: {0}",min);
            Console.ReadKey();
        }
    }
}
