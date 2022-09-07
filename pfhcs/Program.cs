using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfhcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input how many cents you got");
            int pennies = (int)Convert.ToInt64(Console.ReadLine());

            int dollars = pennies / 100;
            pennies %= 100;

            int quarters = pennies / 25;
            pennies %= 25;

            int dimes = pennies / 10;
            pennies %= 10;

            int nickels = pennies / 5;
            pennies %= 5;

            Console.WriteLine($"your cents simplifed into the most efficient currency amount would be {pennies} pennies, {nickels} nickels, {dimes} , dimes, {quarters}, quarters, and {dollars} dollars"); 



        }
    }
}
