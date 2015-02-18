using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung4
{
    class Program
    {
        //Aufgabe 4:
        //Erstellen Sie ein Programm, das mit dem gegebenen letzten Tag des Vorjahres alle Sonntage ausgibt, die auf den ersten eines Monats fallen. 
        //Verwenden sie Zahlen von 1 (Montag) bis 7 (Sonntag) für die Tage und 1 (Januar) bis 12 (Dezember) für die Monate.
        static void Main(string[] args)
        {
            DateTime letzterTagVorjahr;
            int jahr = -1;
            Console.WriteLine("\nÜbung 4:\n\nErmitteln von Sonntagen eines Jahres,\n" +
                "die auf den ersten eines Monats fallen.");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Geben Sie das zu ermittelnde Jahr ein: ");
            
            while ((jahr < 1) || (jahr > 9999)) {
                //if (jahr != -1) {
                //    Console.WriteLine("Die Eingabe war kein zulässiger Wert.");
                //    Console.Write("Geben Sie einen Wert zwischen 1 und 9999 ein:");
                //    jahr = 0;
                //}
                try
                {
                    jahr = Convert.ToInt32(Console.ReadLine());
                } catch(System.FormatException) {
                    Console.WriteLine("Die Eingabe war kein zulässiger Wert.");
                    Console.Write("Geben Sie einen Wert zwischen 1 und 9999 ein:");
                    jahr = -1;
                }
            }
            
            //if ()
            letzterTagVorjahr = new DateTime(jahr,12,31);
            Console.WriteLine(letzterTagVorjahr.ToString());
            Console.ReadLine();

            

        }
    }
}
