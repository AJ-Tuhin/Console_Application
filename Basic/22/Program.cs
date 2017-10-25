using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
            Console.ReadKey();
        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
                return true;
            return false;
        }
    }
}
