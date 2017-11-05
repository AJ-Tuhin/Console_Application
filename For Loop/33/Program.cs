using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of row: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <b; i++)
            {
                double a= Math.Pow(11, i);
                for (int j = (int)a; j >=1; j=j/10)
                {
                    int reminder = j % 10;
                    Console.Write(reminder+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
