using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input starting number of range: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int reminder;
            int sum;
            for (int i = a; i <=b; i++)
            {
                sum = 0;
                for (int j = i; j !=0; j=j/10)
                {
                    reminder = j%10;
                    sum = sum + (reminder*reminder*reminder);
                }
                if (sum==i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}
