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
            
            while ((jahr < 0) || (jahr > 9999)) {
                if (jahr != -1) {
                    Console.WriteLine("Die Eingabe war kein zulässiger Wert.");
                    Console.Write("Geben Sie einen Wert zwischen 0 und 9999 ein:");
                    Console.Error.WriteLine("Test");
                }
                jahr = Convert.ToInt32(Console.ReadLine());
            }
            
            //if ()
            letzterTagVorjahr = new DateTime(jahr,12,31);
            Console.WriteLine(letzterTagVorjahr.ToString());
            Console.ReadLine();

            

        }
    }
}
