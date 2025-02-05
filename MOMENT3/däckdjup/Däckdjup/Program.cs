using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Däckdjup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ta mönsterdjup
            Console.WriteLine("Vad har du för mönsterdjup på dina sommardäck? :)");

            // konvertar mösterdjup till siffra
            if (double.TryParse(Console.ReadLine(), out double däck))
            {
                double gräns = 1.6; // Lagliga gränsen för mönsterdjup
                double skillnad = däck - gräns;

                // IF-ELSE för att kontrollera om däcket är lagligt
                if (däck >= gräns)
                {
                    Console.WriteLine("Ser bra ut! Du kan köra vidare.");
                    Console.WriteLine($"Du har {skillnad:F1} mm kvar tills däcket blir olagligt.");
                }
                else
                {
                    Console.WriteLine("Det är olagligt, byt däck omedelbart!");
                }
            }
            else
            {
                Console.WriteLine("Det kan inte stämma :(");
            }
        } 
    } 
}