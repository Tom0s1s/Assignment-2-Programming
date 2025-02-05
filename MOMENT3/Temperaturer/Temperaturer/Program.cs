using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Copy code från uppgiften, Ange temp för 3 städer
            Console.Write("Ange temperatur för Östersund: ");
            int ostersund = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange temperatur för Åmål: ");
            int amal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange temperatur för Arboga: ");
            int arboga = Convert.ToInt32(Console.ReadLine());

            //Kollar vilken stad som blev kallast! 
            if (ostersund < amal && ostersund < arboga)
            {
                Console.WriteLine("Det är kallast i Östersund");
            }
            else if (amal < ostersund && amal < arboga)
            {
                Console.WriteLine("Det är kallast i Åmål");
            }
            else
            {
                Console.WriteLine("Det är kallast i Arboga");
            }
        }
    }
}
