using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            Console.WriteLine("Expected Output: ");

            result = number*1;
            Console.WriteLine("{0} * {1} = {2}",number,1,result);

            result = number * 2;
            Console.WriteLine("{0} * {1} = {2}", number, 2, result);

            result = number * 3;
            Console.WriteLine("{0} * {1} = {2}", number, 3, result);

            result = number * 4;
            Console.WriteLine("{0} * {1} = {2}", number, 4, result);

            result = number * 5;
            Console.WriteLine("{0} * {1} = {2}", number, 5, result);

            result = number * 6;
            Console.WriteLine("{0} * {1} = {2}", number, 6, result);

            result = number * 7;
            Console.WriteLine("{0} * {1} = {2}", number, 7, result);

            result = number * 8;
            Console.WriteLine("{0} * {1} = {2}", number, 8, result);

            result = number * 9;
            Console.WriteLine("{0} * {1} = {2}", number, 9, result);
            
            result = number * 10;
            Console.WriteLine("{0} * {1} = {2}", number, 10, result);

            Console.Read();
        }
    }
}
