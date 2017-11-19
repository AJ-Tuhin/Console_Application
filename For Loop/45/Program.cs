using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number for LCM: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number for LCM: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            int j = fNumber > sNumber ? fNumber : sNumber;
            int lcf = 0;

            for (int i = j; ; i +=j)
            {
                if (i%fNumber==0&&i%sNumber==0)
                {
                    lcf = i;
                    break;
                }
            }

            Console.WriteLine("The LCM of {0} and {1} is: {2}",fNumber,sNumber,lcf);
            Console.ReadKey();
        }
    }
}
