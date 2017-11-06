using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            char a = 'A';

            for (int i = 1; i <=row; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    Console.Write("{0}",a++);
                    
                }
                a--;
                a--;
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write("{0}", a);
                    a--;
                }
                Console.WriteLine();
                a = 'A';
            }

            Console.ReadKey();
        }
    }
}
