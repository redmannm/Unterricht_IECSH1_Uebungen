using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung3
{
    class Program
    {
        //Aufgabe 3:

        // Schreiben Sie ein Programm, das zu einer eingelesenen Integer-Zahl ermittelt, wie oft mit dieser 
        // Zahl eine Division durch 5 durchgeführt werden kann. Die ermittelte Anzahl wird ausgegeben.
        // Frage: warum ist die Verwendung einer Fußgesteuerten Schleife für diese Aufgabe ungünstig?
        static void Main(string[] args)
        {

            int count = 0;
            int gegebeneZahl;
            int groessteTeilbareZahl = 0;
            int rest;
            Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
            gegebeneZahl = Convert.ToInt32(Console.ReadLine());
            groessteTeilbareZahl = gegebeneZahl - (gegebeneZahl % 5);
            rest = gegebeneZahl % 5;
            Console.WriteLine("Die größte durch 5 Teilbare Zahl ist: " + groessteTeilbareZahl);
            Console.WriteLine("--------------------------------------\n");
            while (groessteTeilbareZahl > 0) // Schleife solange ausführen bis groessteTeilbareZahl größer 0 ist.
            {
                Console.WriteLine(groessteTeilbareZahl -= 5); // 5 von groessteTeilbareZahl abziehen
                count++; // Zähler hochzählen
            }
            Console.WriteLine("\nDie Zahl {0} ist {1} mal durch 5 teilbar. Es bleibt ein Rest von {2}.", gegebeneZahl, count, rest);
            Console.ReadLine();
        }
    }
}