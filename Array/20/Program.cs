using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the square matrix (less than 5): ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] fMatrix = new int[size, size];
            int[,] sMatrix = new int[size, size];
            int[,] addition = new int[size, size];

            Console.WriteLine("Input elements in the first matrix : ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    fMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Input elements in the second matrix : ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    sMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The First matrix is: ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(fMatrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Second matrix is: ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(sMatrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Substraction of two matrix is : ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    addition[i, j] = fMatrix[i, j] - sMatrix[i, j];
                    Console.Write(addition[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
