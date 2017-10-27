using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number : ");
            int fNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2nd number : ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd number : ");
            int tNumber = Convert.ToInt32(Console.ReadLine());

            if (fNumber>sNumber)
            {
                Console.WriteLine(fNumber > tNumber
                    ? "The 1st Number is the greatest among three"
                    : "The 3rd Number is the greatest among three");
            }
            else if(sNumber>tNumber)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else 
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
            Console.ReadKey();
        }
    }
}
