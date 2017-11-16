using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert: ");
            int dNumber = Convert.ToInt32(Console.ReadLine());
            string result = string.Empty;

            for (int i = dNumber; i > 0; i = i / 2)
            {
                int reminder = i % 2;
                result = reminder+result;
                
            }
            Console.WriteLine(result);

            //string binary = Convert.ToString(dNumber, 2);
            //Console.WriteLine(binary);

            Console.ReadKey();
        }
    }
}
