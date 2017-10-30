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
            Console.Write("Enter the number of row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int spc = row - 1;
            for (int i = 1; i <= row; i++)
            {
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=i; j++)
                {
                    count++;
                    Console.Write(count+" ");
                }
                Console.WriteLine();
                spc--;
            }


            Console.ReadKey();
        }
    }
}
