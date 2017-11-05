using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of term: ");
            int term = Convert.ToInt32(Console.ReadLine());

            int sum = 0, a=0, temp=0;
            for (int i = 0; i <term; i++)
            {
                a = temp-a;
                sum += a;
                temp = sum;
                Console.Write(sum+" ");
                if (temp==0)
                {
                    temp++;
                }
                
            }
            Console.ReadKey();
        }
    }
}
