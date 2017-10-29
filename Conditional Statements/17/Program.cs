using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the cost price: ");
            int cost = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the selling price: ");
            int sell = Convert.ToInt32(Console.ReadLine());

            if (sell>cost)
            {
                Console.WriteLine("Your profit amount is: {0}",sell-cost);
            }
            else if (sell < cost)
            {
                Console.WriteLine("Your loss amount is: {0}", cost-sell);
            }
            else
            {
                Console.WriteLine("Your are in no profit no loss condition");
            }

            Console.ReadKey();
        }
    }
}
