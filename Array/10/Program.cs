using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[a];
            int[] even = new int[a];
            int[] odd = new int[a];
            int b = 0, c = 0;

            Console.WriteLine("Input {0} elements in the array",a);
            for (int i = 0; i < a; i++)
            {
                Console.Write("element - {0}:",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            foreach (int value in arr)
            {
                if (value%2==0)
                {
                    even[b] = value;
                    b++;
                }
                else
                {
                    odd[c] = value;
                    c++;
                }  
            }
            Console.WriteLine("The Even elements are: ");

            for (int i = 0; i < b; i++)
            {
                Console.Write(even[i] + " ");
            }
            
            Console.WriteLine("\nThe Odd elements are: ");
            for (int i = 0; i < c; i++)
            {
                Console.Write(odd[i] + " ");
            }
            

            Console.ReadKey();
        }
    }
}
