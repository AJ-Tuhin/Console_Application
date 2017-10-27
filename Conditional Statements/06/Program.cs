using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;
            if (m>0)
            {
                n = 1;
            }
            else if (m<0)
            {
                n = -1;
            }
            else
            {
                n = 0;
            }
            Console.WriteLine("The value of m = {0}",m);
            Console.WriteLine("The value of n = {0}", n);
            Console.ReadKey();
        }
    }
}
