using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number for LCM: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number for LCM: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            int j = fNumber*sNumber;
            int lmc = 0;

            for (int i = 1; i <= j; i++)
            {
                if (i%fNumber==0 && i%sNumber==0)
                {
                    lmc = i;
                    break;
                }
            }

            Console.WriteLine("The LCM of {0} and {1} is: {2}",fNumber,sNumber,lmc);
            Console.ReadKey();
        }
    }
}
