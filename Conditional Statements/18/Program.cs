using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter customer Id: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter unit Consumed: ");
            int unit = Convert.ToInt32(Console.ReadLine());
            double unitcost;
            double amount = 0;
            double charge = 0;
            double totalBill = 0;

            if (unit<=199)
            {
                unitcost = 1.20;
                amount = unit*unitcost;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit:{0} ",amount);

            }
            else if (unit>=200 && unit<400)
            {
                unitcost = 1.50;
                amount = unit * unitcost;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit:{0}", amount);
            }
            else if (unit >= 400 && unit < 600)
            {
                unitcost = 1.80;
                amount = unit * unitcost;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit:{0}", amount);
            }
            else if (unit >= 600)
            {
                unitcost = 2.00;
                amount = unit * unitcost;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit:{0} ", amount);
            }

            if (amount>=400)
            {
                charge = 0.15*amount;
                totalBill = amount + charge;
                Console.WriteLine("Surchage Amount: {0}",charge);
                Console.WriteLine("Net Amount Paid By the Customer: {0}",totalBill);

            }
            else if (amount <= 100)
            {
                Console.WriteLine("you have the minimum bill: 100");
            }
            
            Console.ReadKey();
        }
    }
}
