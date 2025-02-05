using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvåtal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dec till tal 1
            Console.WriteLine("Mata in tal 1: ");
            decimal tal1 = Convert.ToDecimal(Console.ReadLine());
            //dec till tal 2
            Console.WriteLine("Mata in tal 2: ");
            decimal tal2 = Convert.ToDecimal(Console.ReadLine());
            //Kolla vilken som är störst 
            if (tal1 > tal2)
            {
                Console.WriteLine($"Tal 1 var störst: {tal1}");
            }
            else if (tal2 > tal1) 
            { 
                Console.WriteLine($"Tal 2 var störst: {tal2}");

            }
            else   
            { 
                Console.WriteLine("Båda talen är lika.");
            }
        }
    }
}
