using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int p, q;
            for (int i = 1; i <= row; i++)
            {
                if (i%2==0)
                {
                    p = 0;
                    q = 1;
                }
                else
                {
                    p = 1;
                    q = 0;
                }
                for (int j = 1; j <=i; j++)
                {
                    if (j%2==0)
                    {
                        Console.Write(q);
                    }
                    else
                    {
                        Console.Write(p);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
