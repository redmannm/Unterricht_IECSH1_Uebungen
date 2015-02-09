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
            Console.WindowWidth = 120;
            Console.WindowHeight = 65;
            string message = "";
            VerleihVerwaltung verleihVerwaltung = new VerleihVerwaltung();

            
            ConsoleKeyInfo menuKey;
            do
            {
                Console.Clear();
                Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                  "========================================\n\n");
                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - TESTDATEN LADEN\n\n" +
                                  "F2  - Artikel Verwalten\n\n" +
                                  "---------------------------\n\n" +
                                  "TAB - Programm beenden\n\n");
                if (message.Length > 0)
	            {
		            Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(message);
                    message = "";
	            }

                // Menüauswahl einlesen und an 'menuKey' übergeben
                menuKey = Console.ReadKey(true);

                // Menüauswahl Artikel anlegen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    verleihVerwaltung.TestdatenLaden();
                    message = " Testdaten wurden erfolgreich in den Speicher geladen. ";
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
