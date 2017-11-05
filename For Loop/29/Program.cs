using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int reminder;
            int sum =0;
            Console.Write("Enter a number of 3 digit: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i >0 ; i=i/10)
            {
                reminder = i%10;
                sum = sum + reminder*reminder*reminder;
            }
            Console.WriteLine(sum == num ? "{0} is an Armstrong number." : "{0} is not an Armstrong number.", num);
            Console.ReadKey();
        }
    }
}
