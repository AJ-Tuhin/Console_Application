using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string userId1 = "tuhincse001@gmail.com";
            string password1 = "131152540";

            Console.Write("Enter user id: ");
            string userId = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            for (int i = 0; i < 2 && (userId != userId1 || password != password1); i++)
            {
                Console.WriteLine("Enter id and password again ");

                Console.Write("Enter user id: ");
                userId = Console.ReadLine();

                Console.Write("Enter password: ");
                password = Console.ReadLine();

            }
            if (userId == userId1 || password == password1)
            {
                Console.WriteLine("you are successfully log in");
            }
            else
            {
                Console.WriteLine("you are rejected");
            }
            Console.Read();

        }
    }
}
