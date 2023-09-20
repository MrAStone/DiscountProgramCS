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
            Console.WriteLine(finalCost(7, 30, "STONE"));
            Console.WriteLine(finalCost(10, 35, "TAKE10"));
            Console.WriteLine(finalCost(20, 29, ""));
        }
        static string CostToPay(int numItems,double totalCost,string discountCode)
        {
            if(totalCost > 30)
            {
                totalCost = totalCost * 0.95;

            }
            Console.WriteLine(totalCost);
            if(numItems > 10) {
                totalCost = totalCost * 0.9;
            }
            Console.WriteLine(totalCost);
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
            Console.WriteLine(totalCost);
            return Math.Round(totalCost, 2).ToString("£0.00");

        }
        static double CostDiscount(double totalCost)
        {
            if (totalCost > 30)
            {
                return 0.95;

            }
            return 1;
        }
        static double itemDiscount(double totalItems) { 
        if (totalItems > 10)
            {
                return 0.9;
            }
            return 1;

        }
        static double codeDiscount(string discountCode)
        {
            if (discountCode == "TAKE10")
            {
                return 0.9;
            }
            if (discountCode == "SEPT15")
            {
                return 0.85;
            }
            if (discountCode == "STONE")
            {
                return 0.6;
            }
            return 1;
        }
        static string finalCost(int numItems, double totalCost, string discountCode)
        {
            totalCost = totalCost * CostDiscount(totalCost);
            Console.WriteLine(totalCost);
            totalCost = totalCost * itemDiscount(numItems);
            Console.WriteLine(totalCost);
            totalCost = totalCost * codeDiscount(discountCode);
            Console.WriteLine(totalCost);
            return totalCost.ToString("£0.00");
        }
    }
}
