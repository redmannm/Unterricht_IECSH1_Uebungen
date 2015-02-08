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


        public override string[] GetProbertys()
        {
            string[] Eigenschaften;
            return Eigenschaften = new string[7]{ Id.ToString(), Titel, Author, Verlag, Kategorie, Bestand.ToString(), Isbn };
        }
    }
}
