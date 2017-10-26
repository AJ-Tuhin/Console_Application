using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.App
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(@"E:\Exercise\self practise\Basic C#\000.problems\01. Problem.txt");

            Console.WriteLine("Size of a file:{0}",f.Length.ToString());
            Console.ReadKey();
        }
    }
}
