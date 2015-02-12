﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Uebung9_Bibliothek.Klassen
{
    class VerleihVerwaltung
    {
        /// <summary>
        /// Status ob derzeit Testdaten geladen sind;
        /// </summary>
        private bool testDaten = false;
        
        // Speicher Artikellist
        List<VerleihArtikel> _artikelCollection = new List<VerleihArtikel>();

        private List<VerleihArtikel> ArtikelCollection
        {
            get
            {
                return _artikelCollection;
            }
            set
            {
                _artikelCollection = value;
            }
        }
        
        /// <summary>
        /// <para>Laden von Testdaten für die Entwicklungs-</para>
        /// <para>phase in den Speicher.</para>
        /// </summary>
        public void TestdatenLaden()
        {
            // 5 x je 1 Artikel anlegen
            for (int i = 0; i < 6; i++)
            {
                // Test Bücher anlegen
                for (int j = 0; j < 2; j++)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Buch artikel = new Buch();

                    // Artikel in Liste ablegen
                    artikel.Id = ArtikelIdCounter();
                    artikel.Titel = "Buch_" + i;
                    artikel.Author = "Autor_" + i;
                    artikel.Kategorie = "Kategorie_" + i;
                    artikel.Verlag = "Verlag_" + i;
                    artikel.Isbn = "12345678901_" + i;
                    artikel.Bestand = 5 + i;
                    ArtikelCollection.Add(artikel);
                }

                // Test Spiele anlegen
                for (int j = 0; j < 2; j++)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Spiele artikel = new Spiele();

                    // Artikel im Objekt ablegen
                    artikel.Id = ArtikelIdCounter();
                    artikel.Titel = "Spiel_" + i;
                    artikel.Publisher = "Publisher_" + i;
                    artikel.Kategorie = "Kategorie_" + i;
                    artikel.Ean = "12345678901_" + i;
                    artikel.Bestand = 5 + i;
                    ArtikelCollection.Add(artikel);
                }

                // Test DVD's anlegen
                int k = 3 + i;
                for (int j = 0; j < 2; j++)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Dvd artikel = new Dvd();

                    // Artikel im Objekt ablegen
                    artikel.Id = ArtikelIdCounter();
                    artikel.Titel = "DVD_" + i;
                    k += j; // <-- Laufzeit Stunden hochzählen
                    artikel.Laufzeit = DateTime.Parse("01.01.0001 " + k.ToString() + ":00");
                    artikel.Kategorie = "Kategorie_" + i;
                    artikel.Verlag = "Verlag_" + i;
                    artikel.Isbn = "12345678901_" + i;
                    artikel.Bestand = 5 + i;
                    ArtikelCollection.Add(artikel);
                }
            }
            testDaten = true;
        }

        /// <summary>
        /// Menü der Verleihverwaltung
        /// </summary>
        public void Menue()
        {
            ConsoleKeyInfo menuKey;
            do
            {
                Console.Clear();
                Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                  "========================================\n\n");
                Console.WriteLine("Artikel verwalten\n" +
                                  "-----------------\n\n" +
                                  "F1  - Artikel hinzufügen\n\n" +
                                  "F2  - Artikel bearbeiten\n\n" +
                                  "F3  - Artikel löschen\n\n" +
                                  "F4  - Artikel auflisten\n\n" +
                                  "F5  - Artikel suchen\n\n" +
                                  "---------------------------\n\n" +
                                  "ESC - Zurück zum Hauptmenü");
                
                menuKey = Console.ReadKey(true);

                // Menüauswahl Artikel hinzufügen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    ArtikelHinzufuegen();
                }

                // Menüauswahl Artikel bearbeiten
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    ArtikelBearbeiten();
                }

                // Menüauswahl Artikel löschen
                if (menuKey.Key == ConsoleKey.F3)
                {
                    Console.Clear();
                    ArtikelLöschen();
                }

                // Menüauswahl Artikel auflisten
                if (menuKey.Key == ConsoleKey.F4)
                {
                    Console.Clear();
                    ArtikelAuflisten();
                }

                // Menüauswahl Artikel suchen
                if (menuKey.Key == ConsoleKey.F5)
                {
                    Console.Clear();
                    ArtikelSuchen();
                }
                
                
            } while (menuKey.Key != ConsoleKey.Escape);
        }

        // TODO: Dateneingabemaske von Methode 'ArtikelHinzufuegen' noch gestalten
        /// <summary>
        /// Einen Verleihartikel hinzufügen
        /// </summary>
        private void ArtikelHinzufuegen()
        {
            // Testdaten löschen
            if (testDaten)
            {
                ArtikelCollection = null;
                testDaten = false;
            }

            // Feld zum speichern der gedrückten Menütaste
            ConsoleKeyInfo menuKey;

            // Menüschleife Artikel hinzufügen
            do
            {
                // Bildschirm aufräumen
                Console.Clear();
                Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                  "========================================\n\n");
                Console.WriteLine("Artikel hinzufügen\n" +
                                  "-----------------\n\n" +
                                  "F1  - Buch hinzufügen\n\n" +
                                  "F2  - Spiel hinzufügen\n\n" +
                                  "F3  - DVD hinzufügen\n\n" +
                                  "---------------------------\n\n" +
                                  "ESC - Zurück zum Hauptmenü");
                menuKey = Console.ReadKey(true);

                // Buch hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F1)
                {
                    // Bildschirm aufräumen
                    Console.Clear();

                    // Objekt für den nächsten Artikel anlegen
                    Buch artikel = new Buch();

                    // TODO: PadRight() kleiner machen

                    // Artikel Eingeben
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

                    // Artikel ID generieren
                    artikel.Id = ArtikelIdCounter();
                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);
                }

                // Spiel hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F2)
                {
                    // Bildschirm aufräumen
                    Console.Clear();

                    // Objekt für den nächsten Artikel anlegen
                    Spiele artikel = new Spiele();

                    // Artikel Eingeben
                    Console.Write("{0}", "Titel: ".PadRight(14));
                    artikel.Titel = Console.ReadLine();

                    Console.Write("{0}", "Publisher: ".PadRight(14));
                    artikel.Publisher = Console.ReadLine();

                    Console.Write("{0}", "Kategorie: ".PadRight(14));
                    artikel.Kategorie = Console.ReadLine();

                    Console.Write("{0}", "EAN: ".PadRight(14));
                    artikel.Ean = Console.ReadLine();

                    do
                    {
                        try
                        {
                            Console.Write("{0}", "Bestand: ".PadRight(14));
                            artikel.Bestand = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Es sind nur Ganzzahlen erlaubt.");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (true);

                    // Artikel ID generieren
                    artikel.Id = ArtikelIdCounter();
                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);
                }

                // DVD hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F3)
                {
                    // Bildschirm aufräumen
                    Console.Clear();

                    // Objekt für den nächsten Artikel anlegen
                    Dvd artikel = new Dvd();

                    // Artikel Eingeben
                    Console.Write("{0}", "Titel: ".PadRight(10));
                    artikel.Titel = Console.ReadLine();

                    do
                    {
                        try
                        {
                            Console.Write("{0}", "Laufzeit: ".PadRight(10));
                            artikel.Laufzeit = DateTime.Parse("01.01.0001 " + Console.ReadLine() + ":00");
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Geben Sie die Laufzeit des Videos in (SS:MM) an.");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (true);

                    Console.Write("{0}", "Kategorie: ".PadRight(10));
                    artikel.Kategorie = Console.ReadLine();

                    Console.Write("{0}", "Verlag: ".PadRight(10));
                    artikel.Verlag = Console.ReadLine();

                    Console.Write("{0}", "ISBN: ".PadRight(10));
                    artikel.Isbn = Console.ReadLine();

                    do
                    {
                        try
                        {
                            Console.Write("{0}", "Bestand: ".PadRight(10));
                            artikel.Bestand = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Es sind nur Ganzzahlen erlaubt.");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (true);

                    // Artikel ID generieren
                    artikel.Id = ArtikelIdCounter();
                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Einen Verleihartikel bearbeiten
        /// </summary>
        private void ArtikelBearbeiten()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Einen Verleihartikel löschen
        /// </summary>
        private void ArtikelLöschen()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Eine Auflistung aller Artikel 
        /// </summary>
        private void ArtikelAuflisten()
        {
            List<VerleihArtikel> sortiert = ArtikelCollection.OrderBy(x => x.Id).ToList();
            ConsoleKeyInfo menuKey;
            string rowData;

            // Pagination
            int limit;
            int total = sortiert.Count;


            Console.Clear();
            Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                              "========================================\n");
            Console.WriteLine("Artikelliste anzeigen\n" +
                              "---------------------\n\n");

            do
            {
                Console.WriteLine("Welche Art von Medien wollen Sie auflisten?\n" +
                                  "-------------------------------------------\n\n" +
                                  "F1  - Bücher\n\n" +
                                  "F2  - Spiele\n\n" +
                                  "F3  - DVD's\n\n" +
                                  "---------------------------\n\n" +
                                  "ESC - Zurück zur Artikelverwaltung");

                menuKey = Console.ReadKey(true);

                if (menuKey.Key == ConsoleKey.F1)
                {
                    // Header Buch
                    Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Autor           ║ Verlag          ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                    Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    foreach (VerleihArtikel item in sortiert)
                    {
                        if (item is Buch)
                        {
                            rowData = item.Ausgabe();
                            Console.WriteLine(rowData);
                        }
                    }
                    Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                    Console.WriteLine("F1 - Nächste Seite")
                }

                if (menuKey.Key == ConsoleKey.F2)
                {
                    // Header Spiele
                    Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Publisher       ║ Kategorie       ║ Bestand  ║ EAN                ║");
                    Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    foreach (VerleihArtikel item in sortiert)
                    {
                        if (item is Spiele)
                        {
                            rowData = item.Ausgabe();
                            Console.WriteLine(rowData);
                        }
                    }
                    Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                }

                if (menuKey.Key == ConsoleKey.F3)
                {
                    // Header DVD's
                    Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Verlag          ║ Laufzeit        ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                    Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    foreach (VerleihArtikel item in sortiert)
                    {
                        if (item is Dvd)
                        {
                            rowData = item.Ausgabe();
                            Console.WriteLine(rowData);
                        }
                    }
                    Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Einen bestimmten Artikel suchen
        /// </summary>
        private void ArtikelSuchen()
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// Artikel Id ermitteln.
        /// </summary>
        /// <returns>int Eine neue Artikel Id</returns>
        private int ArtikelIdCounter() {
            int lastId;
            List<VerleihArtikel> sortiert = ArtikelCollection.OrderBy(x => x.Id).ToList();
            
            if (sortiert.Count == 0)
                lastId = 0;
            else
                lastId = sortiert[sortiert.Count - 1].Id;
            return lastId + 1;
        }
    }
}
