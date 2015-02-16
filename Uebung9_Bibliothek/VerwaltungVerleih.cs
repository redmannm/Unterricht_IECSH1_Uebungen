using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Uebung9_Bibliothek.Artikel;



namespace Uebung9_Bibliothek
{
    class VerwaltungVerleih
    {
        /// <summary>
        /// Status ob derzeit Testdaten geladen sind;
        /// </summary>
        private bool testDaten = false;
        private ConsoleKeyInfo menuKey;
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
        public bool TestdatenLaden()
        {
            if ((ArtikelCollection.Count > 0) & (!testDaten))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                                                           ");
                Console.WriteLine(" Es sind Daten in der Artikelliste vorhanden.              ");
                Console.WriteLine(" Wenn Sie die Testdaten laden werden diese Daten gelöscht. ");
                Console.WriteLine(" Möchten Sie die Testdaten laden? (J/N)                    ");
                Console.WriteLine("                                                           ");
                Console.ResetColor();
                menuKey = Console.ReadKey(true);

                do
                {
                    if (menuKey.Key == ConsoleKey.J)
                    {
                        ArtikelCollection = null;
                        // 5 x je 1 Artikel anlegen
                        for (int i = 0; i < 6; i++)
                        {
                            // Test Bücher anlegen
                            for (int j = 0; j < 2; j++)
                            {
                                // Objekt für den nächsten Artikel anlegen
                                Buch artikel = new Buch();

                                // Artikel in Liste ablegen
                                artikel.Id = GetArtikelId();
                                artikel.Titel = "Buch_" + i + " " + j;
                                artikel.Author = "Autor_" + i + " " + j;
                                artikel.Kategorie = "Kategorie_" + i + " " + j;
                                artikel.Verlag = "Verlag_" + i + " " + j;
                                artikel.Isbn = "12345678901_" + i + " " + j;
                                artikel.Bestand = 5 + i;
                                ArtikelCollection.Add(artikel);
                            }

                            // Test Spiele anlegen
                            for (int j = 0; j < 2; j++)
                            {
                                // Objekt für den nächsten Artikel anlegen
                                Spiele artikel = new Spiele();

                                // Artikel im Objekt ablegen
                                artikel.Id = GetArtikelId();
                                artikel.Titel = "Spiel_" + i + " " + j;
                                artikel.Publisher = "Publisher_" + i + " " + j;
                                artikel.Kategorie = "Kategorie_" + i + " " + j;
                                artikel.Ean = "12345678901_" + i + " " + j;
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
                                artikel.Id = GetArtikelId();
                                artikel.Titel = "DVD_" + i + " " + j;
                                k += j; // <-- Laufzeit Stunden hochzählen
                                artikel.Laufzeit = DateTime.Parse("01.01.0001 " + k.ToString() + ":00");
                                artikel.Kategorie = "Kategorie_" + i + " " + j;
                                artikel.Verlag = "Verlag_" + i + " " + j;
                                artikel.Isbn = "12345678901_" + i + " " + j;
                                artikel.Bestand = 5 + i;
                                ArtikelCollection.Add(artikel);
                            }
                        }
                        testDaten = true;
                        return true;
                    }
                } while (menuKey.Key != ConsoleKey.N);
            }            
            return false;
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
                                  "ESC - Zurück zum Hauptmenü\n\n");
                menuKey = Console.ReadKey(true);

                // Buch hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F1)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Buch artikel = new Buch();

                    // Artikel Eigenschaften eingeben
                    artikel.Eingabe(GetArtikelId());
                    
                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);
                }

                // Spiel hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F2)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Spiele artikel = new Spiele();

                    // Artikel Eigenschaften eingeben
                    artikel.Eingabe(GetArtikelId());

                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);
                }

                // DVD hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F3)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Dvd artikel = new Dvd();

                    // Artikel Eigenschaften eingeben
                    artikel.Eingabe(GetArtikelId());

                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }

        private void ArtikelEingeben(Buch item)
        {

            // Artikel Eingeben
            Console.Write("{0}", "Titel: ".PadRight(12));
            item.Titel = Console.ReadLine();

            Console.Write("{0}", "Autor: ".PadRight(12));
            item.Author = Console.ReadLine();

            Console.Write("{0}", "Kategorie: ".PadRight(12));
            item.Kategorie = Console.ReadLine();

            Console.Write("{0}", "Verlag: ".PadRight(12));
            item.Verlag = Console.ReadLine();

            Console.Write("{0}", "ISBN: ".PadRight(12));
            item.Isbn = Console.ReadLine();

            try
            {
                Console.Write("{0}", "Bestand: ".PadRight(12));
                item.Bestand = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Es sind nur Ganzzahlen erlaubt.");
                Console.ResetColor();
            }

            // Artikel ID generieren
            item.Id = GetArtikelId();

            // Artikel in Liste speichern
            ArtikelCollection.Add(item);
        }

        private void ArtikelEingeben(Spiele item)
        {
            throw new NotImplementedException();
        }

        private void ArtikelEingeben(Dvd item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Einen Verleihartikel bearbeiten
        /// </summary>
        private bool ArtikelBearbeiten(int id = -1)
        {
            return true;
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
            ConsoleKeyInfo menuKey;
            string rowData;
            bool resStatus;

            // Pagination
            int total;
            int limit = 10;
            int pages;
            int rest;
            int startIndex = 0;
            int currentPage = 0;

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
                    List<VerleihArtikel> buecher = new List<VerleihArtikel>();
                    
                    // Bücher filtern
                    foreach (VerleihArtikel item in ArtikelCollection)
                    {
                        if (item is Buch)
                        {
                            buecher.Add(item);
                        }
                    }

                    // Pagination Variablen
                    total = buecher.Count;
                    pages = (total - (total % limit)) / limit;
                    rest = total % limit;
                    if (rest > 0)
                        pages += 1;

                    // Bücher Seitenweise ausgeben
                    for (int i = 0; i < pages; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                            "========================================\n");
                        Console.WriteLine("Artikelliste anzeigen\n" +
                                            "---------------------\n\n");
                        // Tabellen Header für Bücher ausgeben
                        Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                        Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Autor           ║ Verlag          ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                        Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                        // Limit der letzte Seite mit den restlichen Items setzen
                        if ((rest > 0) & (i == pages - 1))
                            limit = rest;
                        // Tabellen Datenzeilen ausgeben
                        foreach (VerleihArtikel item in buecher.GetRange(startIndex, limit))
                        {
                            rowData = item.Ausgabe();
                            Console.WriteLine(rowData);
                        }
                        Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                        Console.WriteLine("\n F1 - Nächste Seite | F2 - Einen Datensatz bearbeiten | ESC - Auflistung beenden\n");
                        // Startindex für die nächsten 'limit' Ergebnisse
                        startIndex += limit;
                        currentPage += 1;
                        do
                        {
                            menuKey = Console.ReadKey(true);
                            if (menuKey.Key == ConsoleKey.F1)
                            {
                                break;
                            }
                            if (menuKey.Key == ConsoleKey.F2)
                            {
                                Console.Write(" Geben Sie die zu bearbeitende Art.-Id. ein: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                resStatus = ArtikelBearbeiten(id);
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(" Art.-Id: {0} erfolgreich bearbeitet ", id.ToString());
                                Console.ResetColor();
                            }
                            if (menuKey.Key == ConsoleKey.Escape)
                            {
                                i = pages - 1;
                                break;
                            }
                        } while (true);
                    }
                }

                if (menuKey.Key == ConsoleKey.F2)
                {
                    // Header Spiele
                    //Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    //Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Publisher       ║ Kategorie       ║ Bestand  ║ EAN                ║");
                    //Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    //foreach (VerleihArtikel item in sortiert)
                    //{
                    //    if (item is Spiele)
                    //    {
                    //        rowData = item.Ausgabe();
                    //        Console.WriteLine(rowData);
                    //    }
                    //}
                    //Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                }

                if (menuKey.Key == ConsoleKey.F3)
                {
                    // Header DVD's
                    //Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    //Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Verlag          ║ Laufzeit        ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                    //Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    //foreach (VerleihArtikel item in sortiert)
                    //{
                    //    if (item is Dvd)
                    //    {
                    //        rowData = item.Ausgabe();
                    //        Console.WriteLine(rowData);
                    //    }
                    //}
                    //Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
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
        /// Ermittelt anhand der letzten Artikel Id eine neu und gibt sie zurück.
        /// </summary>
        /// <returns>int Gibt eine neue Artikel Id zurück</returns>
        private int GetArtikelId() {
            int lastId;
            List<VerleihArtikel> sortiert = ArtikelCollection.OrderBy(x => x.Id).ToList();
            
            if (sortiert.Count == 0)
                lastId = 0;
            else
                lastId = sortiert[sortiert.Count - 1].Id;
            lastId += 1;
            return lastId;
        }

        private List<VerleihArtikel> ArtikelSortieren()
        {
            List<VerleihArtikel> sortiert = ArtikelCollection.OrderBy(x => x.Id).ToList();
            return sortiert;
        }
    }
}
