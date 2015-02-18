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
        private string message = "";
        // Speicher Artikellist
        List<ArtikelObj> _artikelCollection = new List<ArtikelObj>();

        private List<ArtikelObj> ArtikelCollection
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
                                  "F1  - Test Artikel laden\n\n" +
                                  "------------------------------\n\n" +
                                  "F2  - Artikel hinzufügen\n\n" +
                                  "F3  - Artikel bearbeiten\n\n" +
                                  "F4  - Artikel löschen\n\n" +
                                  "F5  - Artikel auflisten\n\n" +
                                  "F6  - Artikel suchen\n\n" +
                                  "---------------------------\n\n" +
                                  "ESC - Zurück zum Hauptmenü\n\n");

                if (message.Length > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(message);
                    message = "";
                    Console.ResetColor();
                }

                menuKey = Console.ReadKey(true);

                // Menüauswahl Testdaten laden
                if (menuKey.Key == ConsoleKey.F1)
                {
                    if (TestdatenLaden())
                        message = "                                                       \n" +
                                  " Testdaten wurden erfolgreich in den Speicher geladen. \n" +
                                  "                                                       ";
                    else
                        message = "                                 \n" +
                                  " Testdaten wurden NICHT geladen. \n" +
                                  "                                 ";
                }

                // Menüauswahl Artikel hinzufügen
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    ArtikelHinzufuegen();
                }

                // Menüauswahl Artikel bearbeiten
                if (menuKey.Key == ConsoleKey.F3)
                {
                    Console.Clear();
                    ArtikelBearbeiten(false);
                }

                // Menüauswahl Artikel löschen
                if (menuKey.Key == ConsoleKey.F4)
                {
                    Console.Clear();
                    ArtikelLöschen();
                }

                // Menüauswahl Artikel auflisten
                if (menuKey.Key == ConsoleKey.F5)
                {
                    Console.Clear();
                    ArtikelAuflisten();
                }

                // Menüauswahl Artikel suchen
                if (menuKey.Key == ConsoleKey.F6)
                {
                    Console.Clear();
                    ArtikelSuchen();
                }

            } while (menuKey.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// <para>Laden von Testdaten für die Entwicklungs-</para>
        /// <para>phase in den Speicher.</para>
        /// </summary>
        public bool TestdatenLaden()
        {
            if ((ArtikelCollection.Count != 0) & (!testDaten))
            //if (!testDaten)
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
                        ArtikelCollection = new List<ArtikelObj>();
                        GetTestDaten();
                        testDaten = true;
                        return true;
                    }
                    else if (menuKey.Key == ConsoleKey.N)
                    {
                        break;
                    }
                } while (true);
            }
            else
            {
                GetTestDaten();
                testDaten = true;
                return true;
            }
            return false;
        }

        private void GetTestDaten()
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
                ArtikelCollection = new List<ArtikelObj>();
                testDaten = false;
            }

            // Menüschleife Artikel hinzufügen
            do
            {
                // Bildschirm aufräumen
                Console.Clear();

                // Menü ausgeben
                Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                  "========================================\n\n");
                Console.WriteLine("Artikel hinzufügen\n" +
                                  "-----------------\n\n" +
                                  "F1  - Buch hinzufügen\n\n" +
                                  "F2  - Spiel hinzufügen\n\n" +
                                  "F3  - DVD hinzufügen\n\n" +
                                  "---------------------------\n\n" +
                                  "ESC - Zurück zum Hauptmenü\n\n");

                // Message ausgeben
                if (message.Length > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(message);
                    message = "";
                    Console.ResetColor();
                }

                // Menüauswahl abfragen
                menuKey = Console.ReadKey(true);

                // Buch hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F1)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Buch artikel = new Buch();

                    Console.WriteLine("Informationen zum Buch eingeben\n" +
                                      "-------------------------------\n\n");

                    // Artikel Eigenschaften eingeben
                    artikel.Eingabe(GetArtikelId());

                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);

                    message = "                           \n" +
                              " Buch erfolgreich angelegt \n" +
                              "                           \n";
                }

                // Spiel hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F2)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Spiele artikel = new Spiele();

                    Console.WriteLine("Informationen zum Spiel eingeben\n" +
                                      "--------------------------------\n\n");

                    // Artikel Eigenschaften eingeben
                    artikel.Eingabe(GetArtikelId());

                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);

                    message = "                            \n" +
                              " Speil erfolgreich angelegt \n" +
                              "                            \n";
                }

                // DVD hinzufügen
                //=============================
                if (menuKey.Key == ConsoleKey.F3)
                {
                    // Objekt für den nächsten Artikel anlegen
                    Dvd artikel = new Dvd();

                    Console.WriteLine("Informationen zur Dvd eingeben\n" +
                                      "------------------------------\n\n");

                    // Artikel Eigenschaften eingeben
                    artikel.Eingabe(GetArtikelId());

                    // Artikel in Liste speichern
                    ArtikelCollection.Add(artikel);

                    message = "                          \n" +
                              " DVD erfolgreich angelegt \n" +
                              "                          \n";
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }

        //private void ArtikelEingeben(Buch element)
        //{

        //    // Artikel Eingeben
        //    Console.Write("{0}", "Titel: ".PadRight(12));
        //    element.Titel = Console.ReadLine();

        //    Console.Write("{0}", "Autor: ".PadRight(12));
        //    element.Author = Console.ReadLine();

        //    Console.Write("{0}", "Kategorie: ".PadRight(12));
        //    element.Kategorie = Console.ReadLine();

        //    Console.Write("{0}", "Verlag: ".PadRight(12));
        //    element.Verlag = Console.ReadLine();

        //    Console.Write("{0}", "ISBN: ".PadRight(12));
        //    element.Isbn = Console.ReadLine();

        //    try
        //    {
        //        Console.Write("{0}", "Bestand: ".PadRight(12));
        //        element.Bestand = Convert.ToInt32(Console.ReadLine());
        //    }
        //    catch (FormatException e)
        //    {
        //        Console.BackgroundColor = ConsoleColor.Red;
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine("Es sind nur Ganzzahlen erlaubt.");
        //        Console.ResetColor();
        //    }

        //    // Artikel ID generieren
        //    element.Id = GetArtikelId();

        //    // Artikel in Liste speichern
        //    ArtikelCollection.Add(element);
        //}

        //private void ArtikelEingeben(Spiele element)
        //{
        //    throw new NotImplementedException();
        //}

        //private void ArtikelEingeben(Dvd element)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Einen Verleihartikel bearbeiten
        /// <param name="fromList"><para>bool Artikel aus Auflistungen können direkt bearbeitet
        /// werden da die Artikel-Id aus einer Auflistung übergeben wird.</para>
        /// <para>Standardwert: true</para></param>
        /// <param name="id">Artikel-Id des Artikels der bearbeitet werden soll.</param>
        /// </summary>

        private bool ArtikelBearbeiten(bool fromList = true, int id = 0)
        {

            Console.WriteLine("\n Bibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                              " ========================================\n\n");

            if (fromList == false)
            {
                Console.WriteLine(" Welchen Artikel möchten Sie bearbeiten?\n" +
                                  " ---------------------------------------\n\n");
                Console.Write(" Geben Sie die Artikel-Id. ein: ");
                id = Convert.ToInt32(Console.ReadLine());
                foreach (ArtikelObj element in ArtikelCollection)
                {
                    if (id == element.Id)
                    {
                        element.Eingabe(element.Id);
                        return true;
                    }
                }
            }
            else
            {
                ArtikelCollection[id - 1].Eingabe(id);
                return true;
            }
            return false;
        }
        //private bool ArtikelBearbeiten(int id)
        //{

        //    return true;
        //}

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
            
            Pagination paginationMaker = new Pagination();
            

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
                    
                    // Tabellen Datenzeilen ausgeben
                    List<ArtikelObj> list = paginationMaker.GetSortetList(ArtikelCollection, "Buch");
                    
                    // Bücher Seitenweise ausgeben
                    for (int i = 0; i < paginationMaker.Pages; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                                            "========================================\n");
                        Console.WriteLine("Artikelliste anzeigen\n" +
                                            "---------------------\n\n");
                        // Tabellen Header ausgeben
                        Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                        Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Autor           ║ Verlag          ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                        Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");

                        

                        

                        if ((paginationMaker.Rest > 0) & (i == paginationMaker.Pages - 1))
                            paginationMaker.Limit = paginationMaker.Rest;

                        foreach (ArtikelObj element in list.GetRange(paginationMaker.StartIndex, paginationMaker.Limit))
                        {
                            rowData = element.Ausgabe();
                            Console.WriteLine(rowData);
                        }
                        Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                        if (paginationMaker.CurrentPage != i)
                            Console.WriteLine("\n F1 - Nächste Seite | F2 - Einen Datensatz bearbeiten | ESC - Auflistung beenden\n");
                        else
                            Console.WriteLine("\n Letzte Seite | F2 - Einen Datensatz bearbeiten | ESC - Auflistung beenden\n");
                        
                        paginationMaker.GetListMenueControler();
                        //ArtikelBearbeiten(true, paginationMaker.EditId);
                    }
                }

                if (menuKey.Key == ConsoleKey.F2)
                {
                    
                //    // Pagination Variablen
                //    Total = SortedResult.Count;
                //    Pages = (Total - (Total % Limit)) / Limit;
                //    Rest = Total % Limit;
                //    if (Rest > 0)
                //        Pages += 1;

                //    // Bücher Seitenweise ausgeben
                //    for (int i = 0; i < Pages; i++)
                //    {
                //        Console.Clear();
                //        Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                //                            "========================================\n");
                //        Console.WriteLine("Artikelliste anzeigen\n" +
                //                            "---------------------\n\n");

                //        // Header Spiele
                //        Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                //        Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Publisher       ║ Kategorie       ║ Bestand  ║ EAN                ║");
                //        Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");

                //        // Limit der letzte Seite mit den restlichen Items setzen
                //        if ((Rest > 0) & (i == Pages - 1))
                //            Limit = Rest;


                //        foreach (ArtikelObj element in SortedResult.GetRange(StartIndex, Limit))
                //        {
                //            rowData = element.Ausgabe();
                //            Console.WriteLine(rowData);
                //        }
                //        Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                //        Console.WriteLine("\n F1 - Nächste Seite | F2 - Einen Datensatz bearbeiten | ESC - Auflistung beenden\n");

                //        // Startindex für die nächsten 'Limit' Ergebnisse
                //        StartIndex += Limit;
                //        CurrentPage += 1;

                //        // Listenmenü ausgeben
                //        do
                //        {
                //            menuKey = Console.ReadKey(true);
                //            if (menuKey.Key == ConsoleKey.F1)
                //            {
                //                break;
                //            }
                //            if (menuKey.Key == ConsoleKey.F2)
                //            {
                //                Console.Write(" Geben Sie die zu bearbeitende Art.-Id. ein: ");
                //                int id = Convert.ToInt32(Console.ReadLine());
                //                resStatus = ArtikelBearbeiten(true, id);
                //                Console.BackgroundColor = ConsoleColor.Green;
                //                Console.ForegroundColor = ConsoleColor.DarkGreen;
                //                Console.WriteLine(" Art.-Id: {0} erfolgreich bearbeitet ", id.ToString());
                //                Console.ResetColor();
                //            }
                //            if (menuKey.Key == ConsoleKey.Escape)
                //            {
                //                i = Pages - 1;
                //                break;
                //            }
                //        } while (true);
                //    }
                }

                if (menuKey.Key == ConsoleKey.F3)
                {
                    //List<ArtikelObj> SortedResult = new List<ArtikelObj>();

                    //// Bücher filtern
                    //foreach (ArtikelObj element in ArtikelCollection)
                    //{
                    //    if (element is Dvd)
                    //    {
                    //        SortedResult.Add(element);
                    //    }
                    //}

                    //// Pagination Variablen
                    //Total = SortedResult.Count;
                    //Pages = (Total - (Total % Limit)) / Limit;
                    //Rest = Total % Limit;
                    //if (Rest > 0)
                    //    Pages += 1;

                    //// Bücher Seitenweise ausgeben
                    //for (int i = 0; i < Pages; i++)
                    //{
                    //    Console.Clear();
                    //    Console.WriteLine("\nBibliothek Verwaltung v0.0.1 alpha 1 ;-)\n" +
                    //                        "========================================\n");
                    //    Console.WriteLine("Artikelliste anzeigen\n" +
                    //                        "---------------------\n\n");

                    //    // Header DVD's
                    //    Console.WriteLine(" ╔══════════╦═════════════════╦═════════════════╦═════════════════╦═════════════════╦══════════╦════════════════════╗");
                    //    Console.WriteLine(" ║ Art.-Id. ║ Titel           ║ Verlag          ║ Laufzeit        ║ Kategorie       ║ Bestand  ║ ISBN               ║");
                    //    Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");

                    //    // Limit der letzte Seite mit den restlichen Items setzen
                    //    if ((Rest > 0) & (i == Pages - 1))
                    //        Limit = Rest;

                    //    foreach (ArtikelObj item in SortedResult.GetRange(StartIndex, Limit))
                    //    {
                    //        rowData = item.Ausgabe();
                    //        Console.WriteLine(rowData);
                    //    }
                    //    Console.WriteLine(" ╚══════════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╩══════════╩════════════════════╝");
                    //    Console.WriteLine("\n F1 - Nächste Seite | F2 - Einen Datensatz bearbeiten | ESC - Auflistung beenden\n");

                    //    // Startindex für die nächsten 'Limit' Ergebnisse
                    //    StartIndex += Limit;
                    //    CurrentPage += 1;

                    //    // Listenmenü ausgeben
                    //    do
                    //    {
                    //        menuKey = Console.ReadKey(true);
                    //        if (menuKey.Key == ConsoleKey.F1)
                    //        {
                    //            break;
                    //        }
                    //        if (menuKey.Key == ConsoleKey.F2)
                    //        {
                    //            Console.Write(" Geben Sie die zu bearbeitende Art.-Id. ein: ");
                    //            int id = Convert.ToInt32(Console.ReadLine());
                    //            resStatus = ArtikelBearbeiten(true, id);
                    //            Console.BackgroundColor = ConsoleColor.Green;
                    //            Console.ForegroundColor = ConsoleColor.DarkGreen;
                    //            Console.WriteLine(" Art.-Id: {0} erfolgreich bearbeitet ", id.ToString());
                    //            Console.ResetColor();
                    //        }
                    //        if (menuKey.Key == ConsoleKey.Escape)
                    //        {
                    //            i = Pages - 1;
                    //            break;
                    //        }
                    //    } while (true);
                    //}
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
        private int GetArtikelId()
        {

            int lastId = 0;
            List<ArtikelObj> sortiert = ArtikelCollection.OrderBy(x => x.Id).ToList();
            if (ArtikelCollection.Count == 0)
            {
                if (sortiert.Count == 0)
                {
                    lastId = 1;
                    return lastId;
                }
            }
            else
            {
                lastId = sortiert[sortiert.Count - 1].Id + 1;
                return lastId;
            }
            return lastId;
        }

        private List<ArtikelObj> ArtikelSortieren()
        {
            List<ArtikelObj> sortiert = ArtikelCollection.OrderBy(x => x.Id).ToList();
            return sortiert;
        }
    }
}
