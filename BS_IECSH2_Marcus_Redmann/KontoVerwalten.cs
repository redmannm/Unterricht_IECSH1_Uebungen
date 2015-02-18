using System;
using System.Collections.Generic;
using System.Text;
using BS_IECSH2_Marcus_Redmann.Konten;

namespace BS_IECSH2_Marcus_Redmann
{
    class KontenVerwalten
    {
        List<Konto> _kontoCollection = new List<Konto>();
        public List<Konto> KontoCollection
            {
                get
                {
                    return _kontoCollection;
                }
                set
                {
                    _kontoCollection = value;
                }
            }

        Konto _konto;
        public Konto Konto
        {
            get
            {
                return _konto;
            }
            set
            {
                _konto = value;
            }
        }
        

        public void KontoAnlegen()
        {
            int kontoTyp;
            

            Console.Write(" [1] - Girokonto / [2] - Sparbuch anlegen?: ");
            kontoTyp = Convert.ToInt32(Console.ReadLine());

            if (kontoTyp == 1) {
                Konto = new GiroKonto();
            } else {
                Konto = new SparKonto();
            }

            Console.Write("Konto-Inhaber eingeben: ");
            Konto.KontoInhaber = Console.ReadLine();

            Console.Write("Konto-Nummer eingeben: ");
            Konto.KontoNummer = Console.ReadLine();
            
            Console.Write("Konto Anfangsguthaben: ");
            Konto.KontoStand = Convert.ToDouble(Console.ReadLine());

            KontoCollection.Add(Konto);
        }

        public void KontoBearbeiten()
        {
            
        }

        public void KontoBuchung()
        {
            int buchungVorgang;
            string kontoNummerEingabe;
            double betrag;
            // Konto tmpKontoElement;
            int kontoIndex;


            Console.Write("Geben Sie die Kontonr. ein: ");
            kontoNummerEingabe = Console.ReadLine();

            foreach (Konto element in KontoCollection)
            {
                if (element.KontoNummer == kontoNummerEingabe)
                {
                    kontoIndex = KontoCollection.IndexOf(element);
                    //tmpKontoElement = element;
                }
                else
                {
                    Console.WriteLine("Konto nicht vorhanden!\n");
                }
            }

            Console.Write("[1] - Geld abheben\n\n" +
                          "[2] - Geld einzahlen\n\n" +
                          "[3] - Zurück\n\n");
            buchungVorgang = Convert.ToInt32(Console.ReadLine());
            if (buchungVorgang == 1)
            {
                Console.Write("Wieviel Geld möchten Sie abheben: ");
                betrag = Convert.ToDouble(Console.ReadLine());

                Konto.Abbuchen(betrag);
            }
            if (buchungVorgang == 2)
            {
                
            }
            if (buchungVorgang == 3)
            {
                return;
            }
        }
    }
}
