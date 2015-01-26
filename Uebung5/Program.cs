using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung5
{
    class Program
    {
        // Übung 5:
        // Primzahlen sind Zahlen aus dem Zahlenbereich der natürlichen Zahlen größer oder gleich 2,
        // die außer sich selbst und der Zahl 1 keine weiteren Teiler besitzen. Alle natürlichen Zahlen
        // lassen sich in Faktoren von Primzahlen zerlegen. Erstellen Sie einen Algorithmus, welcher die
        // Primzahlen von 2 bis n mithilfe des Siebs des Eratosthenes ermittelt. Bei dieser Methode
        // werden alle Zahlen gestrichen, die sich aus anderen Zahlen zusammensetzen.
        // - Schreiben Sie die Zahlen von 1 bis zur gewünschten Zahl der Größe nach geordnet in
        //   ein Array.
        // - Sie starten mit der kleinsten natürlichen Primzahl, der Zahl 2.
        // - Setzen Sie alle Arrayinhalte, die ein Vielfaches der Zahl 2 sind, auf 0.
        // - Ist das gesamte Array durchlaufen, wird von der Zahl 2 aus die nächstgrößere Zahl
        //   gesucht (3).
        // - Alle Arrayinhalte, die ein Vielfaches dieser Zahl sind, werden anschließend auf 0
        //   gesetzt.
        // - Führen Sie diese Schritte so lange durch, bis das Quadrat der aktuellen Zahl größer als
        //   die letzte Zahl des Arrays ist.
        //In allen Arrayelementen größer 1, deren Inhalt nicht auf 0 gesetzt wurden, befinden
        //sich die gesuchten Primzahlen.
        static void Main(string[] args)
        {
        }
    }
}
