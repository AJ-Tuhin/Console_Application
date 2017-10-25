using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.RemoveCharApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove_Char("w3resource",1));
            Console.WriteLine(Remove_Char("w3resource",9));
            Console.WriteLine(Remove_Char("w3resource",0));

            Console.ReadKey();

        }

        public static string Remove_Char(string str,int n)
        {
            return str.Remove(n, 1);
        }
    }
}
