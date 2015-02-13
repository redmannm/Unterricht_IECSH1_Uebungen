using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek.Klassen
{
    //VerleihArtikel:
    //- ISBN
    //- Titel
    //- Kategorie
    //- Verlag
    //- Bestand

    //Eingabe() {

    //};

    abstract class VerleihArtikel
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        string _titel;
        public string Titel
        {
            get
            {
                return _titel;
            }
            set
            {
                _titel = value;
            }
        }

        string _kategorie;
        public string Kategorie
        {
            get
            {
                return _kategorie;
            }
            set
            {
                _kategorie = value;
            }
        }

        int    _bestand;
        public int Bestand
        {
            get
            {
                return _bestand;
            }
            set
            {
                _bestand = value;
            }
        }

        public abstract string Ausgabe();

        public abstract void Eingabe();

        /// <summary>
        /// Artikel Id ermitteln.
        /// </summary>
        /// <returns>int Eine neue Artikel Id</returns>
        protected int ArtikelIdCounter()
        {
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
