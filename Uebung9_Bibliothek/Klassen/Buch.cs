using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek.Klassen
{
    public struct Eigenschaften
    {

    }
    class Buch : VerleihArtikel
    {
        string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        string _isbn;
        public string Isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
            }
        }

        string _verlag;

        public string Verlag
        {
            get
            {
                return _verlag;
            }
            set
            {
                _verlag = value;
            }
        }


        public override string[] Ausgabe()
        {
            string[] Eigenschaften = item.Ausgabe();

            string t0 = Eigenschaften[0];
            string t1, t2, t3, t4;
            if (Eigenschaften[1].Length > 12)
                t1 = Eigenschaften[1].Substring(0, 12);
            else
                t1 = Eigenschaften[1];

            if (Eigenschaften[2].Length > 12)
                t2 = Eigenschaften[2].Substring(0, 12);
            else
                t2 = Eigenschaften[2];

            if (Eigenschaften[3].Length > 12)
                t3 = Eigenschaften[3].Substring(0, 12);
            else
                t3 = Eigenschaften[3];

            if (Eigenschaften[4].Length > 12)
                t4 = Eigenschaften[4].Substring(0, 12);
            else
                t4 = Eigenschaften[4];

            string t5 = Eigenschaften[5];
            string t6 = Eigenschaften[6];
            

            Console.WriteLine(" ╠══════════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╬══════════╬════════════════════╣");
            Console.WriteLine(" ║      {0} ║ {1}             ║ {2}             ║ {3}             ║ {4}             ║      {5} ║ {6}                ║", t0, t1, t2, t3, t4, t5, t6);
            string[] Eigenschaften;
            return Eigenschaften = new string[7]{ Id.ToString(), Titel, Author, Verlag, Kategorie, Bestand.ToString(), Isbn };
        }
    }
}
