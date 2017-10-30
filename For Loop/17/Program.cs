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
            Console.Write("Enter the number of row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int spc = row - 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = spc; j >=1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
                spc--;
            }

            Console.ReadKey();
        }
    }
}
