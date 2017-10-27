using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Math: ");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemestry: ");
            int che = Convert.ToInt32(Console.ReadLine());

            int total = math + phy + che;
            int totalMathAndPhy = math + phy;
            
            if (math >= 65)
            {
                if (phy >= 55)
                {
                    if (che >= 50)
                    {
                        if ((total >= 180) || (totalMathAndPhy >= 140))
                        {
                            Console.WriteLine("The candidate is eligible for admission.");
                        }
                        else
                        {
                            Console.WriteLine("The candidate is not eligible for admission.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The candidate is not eligible for admission.");
                    }
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission.");
                }
                
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadKey();
        }
    }
}
