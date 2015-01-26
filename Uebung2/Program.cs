using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uebung 2
            // 
            // Für eine Nachricht soll von einem Programm automatisch die Anrede formuliert werden-
            // Folgende Variablen existieren:
            // - string name: Name;
            // - char geschlecht: Geschlecht;
            // - DateTime uhrzeit: Uhrzeit;
            //
            // Die Anrede soll je nach Tageszeit mit "Guten Morgen" (0-9:59 Uhr), "Guten Tag" (10:00-17:59), "Guten Abend" (18:00 - 23:59) beginnen 
            // und anschließend mit "Herr xxx" bzw. "Frau xxx" fortgesetzt werden. Für xxx soll der entsprechende Name eingesetzt werden.
            string name;
            string geschlecht;
            DateTime uhrzeit = DateTime.Now;
            string anredeTxt;

            Console.WriteLine("Geben Sie Ihren Namen ein: ");
            name = Console.ReadLine();
            Console.WriteLine("Geben Sie Ihr Geschlecht ein (M/W): ");
            geschlecht = Console.ReadLine();
            Console.WriteLine("Geben Sie eine Fließkommazahl ein: ");
            
            if (uhrzeit.Hour >= 0 && uhrzeit.Hour <= 9)
                anredeTxt = "Guten Morgen ";
            else if (uhrzeit.Hour >= 10 && uhrzeit.Hour <= 17)
                anredeTxt = "Guten Tag ";
            else
                anredeTxt = "Guten Abend ";

            if (geschlecht.ToUpper() == "M")
                anredeTxt += "Herr ";
            else
                anredeTxt += "Frau ";

            Console.WriteLine(anredeTxt + name);
            Console.ReadLine();
        }
    }
}
