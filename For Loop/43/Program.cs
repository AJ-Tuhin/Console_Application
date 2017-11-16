using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number for HCF: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number for HCF: ");
            int lNumber = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int j = fNumber < lNumber ? fNumber : lNumber;

            for (int i = 1; i <=j; i++)
            {
                if (fNumber%i==0 && lNumber%i==0)
                {
                    result = i;
                }
            }
            Console.WriteLine("HCF of {0} and {1} is: {2} ",fNumber,lNumber,result);
            Console.ReadKey();
        }
    }
}
