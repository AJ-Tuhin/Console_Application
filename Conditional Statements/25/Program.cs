using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.App
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.Write("Enter the first number: ");
            double fNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double sNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Here are the options: ");
            Console.WriteLine("1 - Addition.\n2 - Substraction.\n3 - Multiplication.\n4 - Division.\n5 - Exit.");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = fNumber + sNumber;
                    Console.WriteLine("The Addition of {0} and {1} is: {2}",fNumber,sNumber,result);
                    break;

                case 2:
                    result = fNumber - sNumber;
                    Console.WriteLine("The Subtraction of {0} and {1} is: {2}", fNumber, sNumber, result);
                    break;

                case 3:
                    result = fNumber * sNumber;
                    Console.WriteLine("The Multiplication of {0} and {1} is: {2}", fNumber, sNumber, result);
                    break;

                case 4:
                    if (sNumber == 0)
                    {
                        Console.WriteLine("The result is Undifined");
                    }
                    else
                    {
                        result = fNumber / sNumber;
                        Console.WriteLine("The division of {0} and {1} is: {2}", fNumber, sNumber, result);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


            Console.ReadKey();
        }
    }
}
