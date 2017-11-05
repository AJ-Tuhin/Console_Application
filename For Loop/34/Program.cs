using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input starting number of range: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int lNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = sNumber; i <=lNumber; i++)
            {
                int count = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j==0)
                    {
                        count++;
                        break;
                    }
                }
                if (count==0 && i!=1)
                {
                    Console.Write(i+" ");
                }

            }
            Console.ReadKey();

        }
    }
}
