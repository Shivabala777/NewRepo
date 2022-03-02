using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of laptops sold on current month");
            int NumberOfLaptops=int.Parse(Console.ReadLine());
            Console.WriteLine("Total sales amount on current month");
            int SalesAmount=int.Parse(Console.ReadLine());
            int BasicSalary = 5000;
            int CommissionAmount = NumberOfLaptops * 1000;
            int Bonus = (SalesAmount * 2) / 100;
            int GrossSalary = BasicSalary + CommissionAmount + Bonus;
            Console.WriteLine("Basic Salary " + BasicSalary);
            Console.WriteLine("Commission Amount " + CommissionAmount);
            Console.WriteLine("2% Sales Bonus for " + SalesAmount + " is " + Bonus);
            Console.WriteLine("Gross Salary " + GrossSalary);
            Console.ReadKey();

        }
    }
}
