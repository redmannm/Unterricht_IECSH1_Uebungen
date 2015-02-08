using System;
using System.Collections.Generic;
using System.Text;
using Uebung9_Bibliothek.Klassen;

namespace Uebung9_Bibliothek
{
    //Erstellen Sie Anwendung für eine Bibliothek in dieser Anwendung soll der Bestand der unterschiedlichen "Artikel" (Bücher, Zeitungen, DVD's, Blue-Ray's, PC- und Konsolenspiele) verwaltet werden können.

    //- Bezeichnung,
    //- ISBN,
    //- Art,
    //- Autor bzw. Publisher
    //- Status
    //- Bestand

    //Es soll möglich sein neue Medien in den Bestand aufzunehmen.
    //Es soll möglich sein Medien zu verleihen und wieder zurück zu nehmen.
    //Es soll möglich sein den Bestand anzupassen.

    //VerleihArtikel:
    //- ISBN
    //- Titel
    //- Kategorie
    //- Verlag
    //- Bestand

    //Eingabe() {

    //};

    //Buch : VerleihArtikel		Spiele : VerleihArtikel		DVD's : VerleihArtikel
    //- Author					- EAN						- Laufzeit
    //Eingabe() { 				Eingabe() {
    //  Base.Eingabe();			  Base.Eingabe();
    //  Frage nach Author;		  Frage nach EAN;
    //};							};
    class Program
    {
        
        static void Main(string[] args)
        {
            VerleihVerwaltung verleihVerwaltung = new VerleihVerwaltung();
            
            ConsoleKeyInfo menuKey;
            do
            {
                Console.Clear();
                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - TESTDATEN LADEN\n\n" +
                                  "F2  - Artikel Verwalten\n\n" +
                                  "---------------------------\n\n" +
                                  "TAB - Programm beenden");
                menuKey = Console.ReadKey(true);

                // Menüauswahl Artikel anlegen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    verleihVerwaltung.TestdatenLaden();
                }

                // Menüauswahl Testdaten laden
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    verleihVerwaltung.Menue();
                }
            } while (menuKey.Key != ConsoleKey.Tab);
        }
    }
}
