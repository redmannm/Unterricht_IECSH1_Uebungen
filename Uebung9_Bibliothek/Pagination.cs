using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uebung9_Bibliothek;
using Uebung9_Bibliothek.Artikel;

namespace Uebung9_Bibliothek
{
    public class Pagination
    {
        public int total;
        public int limit;
        public int pages;
        public int rest;
        public int startIndex;
        public int currentPage;

        public int editId;

        public List<ArtikelObj> sortedResult = new List<ArtikelObj>();

        public Pagination()
        {
            limit = 10;
        }

        public List<ArtikelObj> GetSortetList(List<ArtikelObj> _artikelCollection, string type)
        {
            if (type == "Buch")
            {
                foreach (ArtikelObj element in _artikelCollection)
                {
                    if (element is Buch)
                    {
                        sortedResult.Add(element);
                    }
                }   
            }

            if (type == "Spiele")
            {
                foreach (ArtikelObj element in _artikelCollection)
                {
                    if (element is Spiele)
                    {
                        sortedResult.Add(element);
                    }
                } 
            }

            if (type == "Dvd")
            {
                foreach (ArtikelObj element in _artikelCollection)
                {
                    if (element is Dvd)
                    {
                        sortedResult.Add(element);
                    }
                } 
            }
            CalculatePageingVars();
            return sortedResult;
        }

        public void CalculatePageingVars(){
            // Pagination Variablen
            total = sortedResult.Count;
            pages = (total - (total % limit)) / limit;
            rest = total % limit;
            if (rest > 0)
                pages += 1;
        }

        public void setNextRange()
        {
            // Startindex für die nächsten 'limit' Ergebnisse
            startIndex += limit;
            currentPage += 1;
        }

        

        public void GetListMenueControler()
        {
            // Listenmenü ausgeben
            do
            {
                ConsoleKeyInfo menuKey = Console.ReadKey(true);
                if (menuKey.Key == ConsoleKey.F1)
                {
                    //if (currentPage != pages)
                    //{
                        setNextRange();
                    //}
                    
                    return;
                }
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Console.Write(" Geben Sie die zu bearbeitende Art.-Id. ein: ");
                    editId = Convert.ToInt32(Console.ReadLine());
                }
                if (menuKey.Key == ConsoleKey.Escape)
                {
                    //i = pages - 1;
                    return;
                }
            } while (true);
        }
    }
}
