﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung8.Klassen
{
    class Mitarbeiter : Personen, IEnumerable<Mitarbeiter>
    {
        int steuerKlasse;
        public int SteuerKlasse
        {
            get
            {
                return steuerKlasse;
            }
            set
            {
                steuerKlasse = value;
            }
        }

        int kinder;
        public int Kinder
        {
            get
            {
                return kinder;
            }
            set
            {
                kinder = value;
            }
        }

        double bruttoLohn;
        public double BruttoLohn
        {
            get
            {
                return bruttoLohn;
            }
            set
            {
                bruttoLohn = value;
            }
        }

        bool testDatenGeladen;

        private bool TestDatenGeladen
        {
            get
            {
                return testDatenGeladen;
            }
            set
            {
                testDatenGeladen = value;
            }
        }

        
        List<Mitarbeiter> li_MaDaten = new List<Mitarbeiter>();
        public Mitarbeiter()
        {
            TestDatenGeladen = false;
        }

        public override void Anlegen()
        {
            if (TestDatenGeladen)
                li_MaDaten.Clear();
            // Ausgabe vorbereiten
            Console.WriteLine("Mitarbeiter anlegen\n" +
                              "-------------------\n\n" +
                              "Persönliche Daten\n\n");
            Console.Write("{0}", "Familienname:".PadRight(14));
            Name = Console.ReadLine();

            Console.Write("{0}", "Vorname:".PadRight(14));
            Vorname = Console.ReadLine();

            do
            {
                try
                {
                    Console.Write("{0}", "Geb.-Datum:".PadRight(14));
                    GebDat = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.Write("\n");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Das Datumsformat ist nicht richtig. Bitte in diesem Format eingeben: (DD.MM.JJJJ).");
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n");
                }
            } while (true);

            Console.Write("{0}", "Konfession:");

            Console.Write("{0}", "Straße:".PadRight(14));
            Strasse = Console.ReadLine();

            Console.Write("{0}", "Nummer:".PadRight(14));
            Hausnummer = Console.ReadLine();

            Console.Write("{0}", "PLZ:".PadRight(14));
            Plz = Console.ReadLine();

            Console.Write("{0}", "Ort:".PadRight(14));
            Ort = Console.ReadLine();

            Console.WriteLine("{0}", "\n\nLohndaten:\n");

            Console.Write("{0}", "Bruttolohn:".PadRight(14));
            BruttoLohn = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0}", "Kinder:".PadRight(14));
            Kinder = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}", "Lohn-St.-Klasse:".PadRight(14));
            SteuerKlasse = Convert.ToInt32(Console.ReadLine());
            
            Mitarbeiter ma = new Mitarbeiter
            {
                Name = this.Name,
                Vorname = this.Vorname,
                GebDat = this.GebDat,
                Strasse = this.Strasse,
                Hausnummer = this.Hausnummer,
                Plz = this.Plz,
                Ort = this.Ort,
                Konfession = this.Konfession,
                Status = true
            };
            li_MaDaten.Add(ma);
        }

        //public override void Anlegen(List<Mitarbeiter> _testMaDaten)
        //{
        //    foreach (Mitarbeiter item in _testMaDaten)
        //    {
                
        //    }
        //}
        public void getList()
        {
            int pos = 0;

            Console.Write("Mitarbeiter-Liste anzeigen\n" +
                          "--------------------------\n\n");
            Console.Write("================================================================================\n" + 
                          "| Pos. | Famielienname       | Vorname             | Geb.-Datum   | Bruttolohn |\n" +
                          "================================================================================\n");

            foreach (Mitarbeiter item in li_MaDaten)
	        {
                pos++;
		        Console.Write("| {0} | {1} | {2} | {3} | {4} |\n", pos.ToString().PadRight(4), item.Name.PadRight(19), item.Vorname.PadRight(19), item.GebDat.ToShortDateString().PadRight(12), item.BruttoLohn.ToString().PadRight(10));
                Console.Write("--------------------------------------------------------------------------------\n"); 
	        }
            Console.ReadKey();
        }
        public void getTestData()
        {
            if (li_MaDaten.Count > 0)
                li_MaDaten.Clear();
            // Testdaten 
            Mitarbeiter ma1 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma2 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma3 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma4 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma5 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma6 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma7 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma8 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma9 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma10 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma11 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };
            Mitarbeiter ma12 = new Mitarbeiter
            {
                Name = "Redmann",
                Vorname = "Marcus",
                GebDat = System.DateTime.Parse("11.10.1974"),
                Strasse = "Willhelm-Raabe-Weg",
                Hausnummer = "13",
                Plz = "24159",
                Ort = "Kiel",
                Konfession = 1,
                Status = true
            };

            li_MaDaten.Add(ma1);
            li_MaDaten.Add(ma2);
            li_MaDaten.Add(ma3);
            li_MaDaten.Add(ma4);
            li_MaDaten.Add(ma5);
            li_MaDaten.Add(ma6);
            li_MaDaten.Add(ma7);
            li_MaDaten.Add(ma8);
            li_MaDaten.Add(ma9);
            li_MaDaten.Add(ma10);
            li_MaDaten.Add(ma11);
            li_MaDaten.Add(ma12);
            // Testdaten ende
            TestDatenGeladen = true;
        }
        IEnumerator<Mitarbeiter> IEnumerable<Mitarbeiter>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
