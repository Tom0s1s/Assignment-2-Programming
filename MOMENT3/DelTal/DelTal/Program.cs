using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelTal
{
    internal class Program
    {
        static void Main(string[] args)
        { //Mata in värde
            Console.Write("Mata in ett heltal: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            // om tal är delbart med 7
            if (tal % 7 == 0)
            {

                Console.Write($"Ditt tal: {tal} är jämt och delbart med 7!");
            }
            else 
                
                //om tal inte är jämt delbart, visa också rest.
                {
                int rest = tal % 7;
                Console.Write($"Ditt tal: {tal} är ej jämt delbart med 7, resten blir {rest}: ");
            }
        }
    }
}
