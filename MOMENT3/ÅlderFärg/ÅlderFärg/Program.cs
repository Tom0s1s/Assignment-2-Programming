using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÅlderFärg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int till string
            Console.Write("Mata in ålder :) : ");
            int ålder = Convert.ToInt32(Console.ReadLine());

            // om string till rätt int
            string färg;

            // string till färg 
            if (ålder >= 0 && ålder <= 12)
            {
                färg = "vit";
            }
            else if (ålder >= 13 && ålder <= 18)
            {
                färg = "grön";
            }
            else if (ålder >= 19 && ålder <= 25)
            {
                färg = "röd";
            }
            else if (ålder >= 26 && ålder <= 99)
            {
                färg = "blå";
            }
            else
            {
                färg = "Grå :(";
            }

            // int till färg
            Console.WriteLine($"färg: {färg}");
        }
    }
}
