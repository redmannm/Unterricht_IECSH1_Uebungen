using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


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
            for (int i = 0; i < 5; i++)
            {
                // Test Bücher anlegen
                for (int j = 0; j < 1; j++)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Buch artikel = new Buch();

                    // Artikel in Liste ablegen
                    artikel.Titel = "Buch_" + i;
                    artikel.Author = "Autor_" + i;
                    artikel.Kategorie = "Kategorie_" + i;
                    artikel.Verlag = "Verlag_" + i;
                    artikel.Isbn = "12345678901_" + i;
                    artikel.Bestand = 5 + i;
                    ArtikelCollection.Add(artikel);
                }

                // Test Spiele anlegen
                for (int j = 0; j < 1; j++)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Spiele artikel = new Spiele();

                    // Artikel im Objekt ablegen
                    artikel.Titel = "Spiel_" + i;
                    artikel.Publisher = "Publisher_" + i;
                    artikel.Kategorie = "Kategorie_" + i;
                    artikel.Ean = "12345678901_" + i;
                    artikel.Bestand = 5 + i;
                    ArtikelCollection.Add(artikel);
                }

                // Test DVD's anlegen
                int k = 3 + i;
                for (int j = 0; j < 1; j++)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Dvd artikel = new Dvd();

                    // Artikel im Objekt ablegen
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
                Console.WriteLine("Bibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                  "========================================\n\n");
                Console.WriteLine("Artikel verwalten\n" +
                                  "-----------------\n\n" +
                                  "F1  - Artikel hinzufügen\n\n" +
                                  "F2  - Artikel bearbeiten\n\n" +
                                  "F3  - Artikel löschen\n\n" +
                                  "F4  - Artikel auflisten\n\n" +
                                  "F5  - Artikel suchen\n\n" +
                                  "---------------------------\n\n" +
                                  "TAB - Zurück zum Hauptmenü");
                
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
                    Console.ReadKey();
                }

                // Menüauswahl Artikel suchen
                if (menuKey.Key == ConsoleKey.F5)
                {
                    Console.Clear();
                    ArtikelSuchen();
                }
                
                
            } while (menuKey.Key != ConsoleKey.Tab);
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
            
            Console.Clear();
            Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                              "========================================\n");
            Console.WriteLine("Artikelliste anzeigen\n" +
                              "---------------------\n\n");

            ConsoleKeyInfo menuKey;
            string artikelArt;
            string rowData;
            do
            {
                Console.Clear();
                Console.WriteLine("Bibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                  "========================================\n\n");
                Console.WriteLine("Welche Art von Medien wollen Sie auflisten?\n" +
                                  "-------------------------------------------\n\n" +
                                  "F1  - Bücher\n\n" +
                                  "F2  - Spiele\n\n" +
                                  "F3  - DVD's\n\n" +
                                  "---------------------------\n\n" +
                                  "TAB - Zurück zum Hauptmenü");

                menuKey = Console.ReadKey(true);

                if (menuKey.Key == ConsoleKey.F1)
                {
                    // Header Buch
                    Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Autor           ║ Verlag          ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                    Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    artikelArt = "Uebung9_Bibliothek.Klassen.Buch";
                    break;
                }

                if (menuKey.Key == ConsoleKey.F2)
                {
                    // Header Spiele
                    Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Publisher       ║ Kategorie       ║ Bestand  ║ EAN                ║");
                    Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    artikelArt = "Uebung9_Bibliothek.Klassen.Spiele";
                    break;
                }

                if (menuKey.Key == ConsoleKey.F3)
                {
                    // Header DVD's
                    Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Verlag          ║ Laufzeit        ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                    Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
                    artikelArt = "Uebung9_Bibliothek.Klassen.Dvd";
                    break;
                }

            } while (true);
            
            foreach (VerleihArtikel item in ArtikelCollection)
            {

                if (item.GetType().ToString() == artikelArt)
                {
                    rowData = item.Ausgabe();
                    Console.WriteLine(rowData);
                }
                if (item.GetType().ToString() == artikelArt)
                {
                    rowData = item.Ausgabe();
                    Console.WriteLine(rowData);
                }
                if (item.GetType().ToString() == artikelArt)
                {
                    rowData = item.Ausgabe();
                    Console.WriteLine(rowData);
                }
            }

            if (artikelArt == "Uebung9_Bibliothek.Klassen.Spiele") 
            {
                // Footer Spiele
                Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
            }
            else if (artikelArt == "Uebung9_Bibliothek.Klassen.Buch" || artikelArt == "Uebung9_Bibliothek.Klassen.Dvd")
            {
                // Footer Buch und DVD's
                Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
            }
            

            

            Console.ReadKey();
        }

        /// <summary>
        /// Einen bestimmten Artikel suchen
        /// </summary>
        private void ArtikelSuchen()
        {
            throw new NotImplementedException();
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
                                  "TAB - Zurück zum Hauptmenü");
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
                    Console.Write("{0}", "Titel: ".PadRight(14));
                    artikel.Titel = Console.ReadLine();

                    do
                    {
                        try
                        {
                            Console.Write("{0}", "Laufzeit: ".PadRight(14));
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

                    Console.Write("{0}", "Kategorie: ".PadRight(14));
                    artikel.Kategorie = Console.ReadLine();

                    Console.Write("{0}", "Verlag: ".PadRight(14));
                    artikel.Verlag = Console.ReadLine();

                    Console.Write("{0}", "ISBN: ".PadRight(14));
                    artikel.Isbn = Console.ReadLine();

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

                    int artikelMaxIndex = 0;
                    int letzteArtikelId = 0;
                    if (ArtikelCollection.Count == 0)
                    {
                        artikelMaxIndex = ArtikelCollection.Count - 1;
                        letzteArtikelId = ArtikelCollection[artikelMaxIndex].Id;
                    }
                    artikel.Id = letzteArtikelId + 1;

                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);
                }
            } while (menuKey.Key != ConsoleKey.Tab);
        }
    }
}
