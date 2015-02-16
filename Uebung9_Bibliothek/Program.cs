using System;
using System.Collections.Generic;
using System.Text;
using Uebung9_Bibliothek.Artikel;

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
    //};						};

    // Folgende Funktionalität sollte Ihre Software am Ende haben:
    //- neue Medien in den Bestand aufnehmen
    //- Medien aus dem Bestand löschen
    //- Medien verleihen
    //- Bestand verändern
    //- Medien aus der ausleihe zurück bekommen
    //- Informationen zu den Medien ausgeben lassen
    //- nach Medien suchen
    //- XML-Export in eine Datei


    // Als Erweiterung implementieren Sie bitte folgende Funktionalität:
    //- für jeden Kunden soll es ein Kundenkonto geben
    //- ein ausgeliehenes Medium soll einen Kunden zugeordnet werden können
    //- die Kundendaten sollen verändert und angezeigt werden können
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WindowWidth = 120;
            Console.WindowHeight = 65;
            string message = "";
            VerwaltungVerleih artikelVerwaltung = new VerwaltungVerleih();

            
            ConsoleKeyInfo menuKey;
            do
            {
                Console.Clear();
                Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                  "========================================\n\n");
                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - TESTDATEN LADEN\n\n" +
                                  "F2  - Artikel verwalten\n\n" +
                                  "F3  - Kunden verwalten\n\n" +
                                  "---------------------------\n\n" +
                                  "ESC - Programm beenden\n\n");
                if (message.Length > 0)
	            {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(message);
                    message = "";
                    Console.ResetColor();
	            }

                // Menüauswahl einlesen und an 'menuKey' übergeben
                menuKey = Console.ReadKey(true);

                // Menüauswahl Testdaten laden
                if (menuKey.Key == ConsoleKey.F1)
                {
                    if (artikelVerwaltung.TestdatenLaden())
                        message = " Testdaten wurden erfolgreich in den Speicher geladen. ";
                    else
                        message = " Testdaten wurden NICHT geladen. ";
                }

                // Menüauswahl Artikelverwaltung
                if (menuKey.Key == ConsoleKey.F2)
                {
                    artikelVerwaltung.Menue();
                }

                // Menüauswahl Kundenverwaltung
                if (menuKey.Key == ConsoleKey.F3)
                {
                    VerwaltungKunden kundenVerwaltung = new VerwaltungKunden();
                    kundenVerwaltung.Menue();
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }
    }
}
