using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung1
{
    class Program
    {
        // Übung 1:
        //
        // Erstellen Sie eine Anwendung um die Zahlen 543 und 246 zu vergleichen
        // und die größere von beiden Auszugeben.
        static void Main(string[] args)
        {
            int zahl1 = 543;
            int zahl2 = 246;

            if (zahl1 > zahl2)
                Console.WriteLine("Die 'Zahl1: {0}' ist größer als die 'Zahl2: {1}'", zahl1, zahl2);

            Console.ReadLine();
        }
    }
}
