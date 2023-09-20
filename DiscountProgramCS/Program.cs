using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountProgramCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CostToPay(7, 30, "STONE"));
            Console.WriteLine(CostToPay(10, 35, "TAKE10"));
            Console.WriteLine(CostToPay(20, 29, ""));
        }
        static string CostToPay(int numItems,double totalCost,string discountCode)
        {
            if(totalCost > 30)
            {
                totalCost = totalCost * 0.95;

            }
            if(numItems > 10) {
                totalCost = totalCost * 0.9;
            }
            if (discountCode == "TAKE10")
            {
                totalCost *= 0.9;
            }
            if (discountCode == "SEPT15")
            {
                totalCost *= 0.85;
            }
            if (discountCode == "STONE")
            {
                totalCost *= 0.6;
            }
            return Math.Round(totalCost, 2).ToString("£0.00");

        }
    }
}
