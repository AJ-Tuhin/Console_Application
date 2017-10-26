using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Data: ");
            string data = Console.ReadLine();
            

            if (data.Substring(1, 2).Equals("hp"))
            {
                string sb = data.Remove(1, 2);
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("There are no 'hp' in second index");
            }

            
            Console.ReadKey();
        }
    }
}
