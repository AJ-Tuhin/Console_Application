using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string astring = "Display the pattern like pyramid using the alphabet";
            char[] cArray = astring.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse);
            Console.ReadKey();
        }
    }
}
