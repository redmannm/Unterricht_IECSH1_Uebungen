﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek.Klassen
{
    class VerleihVerwaltung
    {
        List<VerleihArtikel> ArtikelListe = new List<VerleihArtikel>();
        public void MediumHinzufuegen()
        {
            ConsoleKeyInfo menuKey;
            do
            {
                Console.Clear();
                Console.WriteLine("Medium hinzufügen\n" +
                                  "-----------------\n\n" +
                                  "F1  - Buch hinzufügen\n" +
                                  "F2  - Spiel hinzufügen\n" +
                                  "F3  - DVD hinzufügen\n" +
                                  "---------------------------\n" +
                                  "ESC - Zurück zum Hauptmenü");
                menuKey = Console.ReadKey();

                // Buch hinzufügen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    
                    Buch artikel = new Buch();

                    Console.Write("{0}", "Titel: ".PadRight(14));
                    artikel.Titel = Console.ReadLine();

                    Console.Write("{0}", "Autor: ".PadRight(14));
                    artikel.Author = Console.ReadLine();

                    Console.Write("{0}", "Kategorie: ".PadRight(14));
                    artikel.Kategorie = Console.ReadLine();

                    Console.Write("{0}", "Verlag: ".PadRight(14));
                    artikel.Verlag = Console.ReadLine();

                    Console.Write("{0}", "ISBN: ".PadRight(14));
                    artikel.Isbn = Console.ReadLine();

                    try
                    {
                        Console.Write("{0}", "Bestand: ".PadRight(14));
                        artikel.Bestand = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Es sind nur Ganzzahlen erlaubt.");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    ArtikelListe.Add(artikel);
                }

                // Spiel hinzufügen
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    Spiele artikel = new Spiele();
                    artikel.
                    ArtikelListe.Add(artikel);
                }

                // DVD hinzufügen
                if (menuKey.Key == ConsoleKey.F3)
                {
                    Console.Clear();
                    Dvd artikel = new Dvd();

                    ArtikelListe.Add(artikel);
                }
            } while (menuKey.Key != ConsoleKey.Escape);
            
            
            
        }
    }
}
