using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Roll Number of the student: ");
            int roll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();

            Console.Write("Input the marks of Physics: ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks of Chemistry: ");
            int che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks of Computer Application: ");
            int comApp = Convert.ToInt32(Console.ReadLine());

            int totalMark = phy + che + comApp;
            int average = totalMark/3;

            Console.WriteLine("Roll No: "+roll);
            Console.WriteLine("Name of Student : "+name );
            Console.WriteLine("Marks in Physics: " + phy);
            Console.WriteLine("Marks in Chemistry: " + che);
            Console.WriteLine("Marks in Computer Application: " + comApp);
            Console.WriteLine("Total marks: " + totalMark);
            Console.WriteLine("Percentage: " + average);

            if (average>=60)
            {
                Console.WriteLine("Division = First");
            }
            else if (average>=50 && average<60)
            {
                Console.WriteLine("Division = Second");
            }
            else if (average >= 33 && average < 50)
            {
                Console.WriteLine("Division = Third");
            }
            else
            {
                Console.WriteLine("You are failed");
            }

            Console.ReadKey();
        }
    }
}
