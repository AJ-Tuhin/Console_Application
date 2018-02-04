using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3];

            Console.WriteLine("Input elements in the matrix : ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i,j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nThe matrix is : \n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j]+"  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
