using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance(meters): ");
            double meters = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input timeSec(hour): ");
            double hour = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input timeSec(minutes): ");
            double minutes = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input timeSec(seconds): ");
            double seconds = Convert.ToDouble(Console.ReadLine());

            double minuteToHour = minutes/60;
            double secondToHour = seconds/3600;
            double hourFinal = hour + minuteToHour + secondToHour;

            double totalSecond = seconds + minutes*60 + hour*3600;
            double km = meters/1000;
            double mile = km/1.6093;
            double meterPerSecond = meters/totalSecond;
            double kmPerHour = km/hourFinal;
            double milePerHour = mile/hourFinal;


            Console.WriteLine("Your speed in meters/sec is {0}",meterPerSecond);
            Console.WriteLine("Your speed in km/h is {0}",kmPerHour);
            Console.WriteLine("Your speed in miles/h is {0}",milePerHour);

            Console.ReadKey();

        }
    }
}
