using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the grade you obtain: ");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            string notes;

            switch (grade)
            {
                case 'E':
                    notes = "Excellent";
                    break;
                case 'V':
                    notes = "Very Good";
                    break;
                case 'G':
                    notes = "Good";
                    break;
                case 'A':
                    notes = "Average";
                    break;
                case 'F':
                    notes = "Fail";
                    break;
                default:
                    notes = "you don't entered a valid grade";
                    break;
            }
            Console.WriteLine(notes);
            Console.ReadKey();
        }
    }
}
