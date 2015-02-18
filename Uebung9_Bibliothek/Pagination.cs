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
        private int _total;

        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }
        private int _limit;

        public int Limit
        {
            get
            {
                return _limit;
            }
            set
            {
                _limit = value;
            }
        }
        private int _pages;

        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                _pages = value;
            }
        }
        private int _rest;

        public int Rest
        {
            get
            {
                return _rest;
            }
            set
            {
                _rest = value;
            }
        }
        private int _startIndex;

        public int StartIndex
        {
            get
            {
                return _startIndex;
            }
            set
            {
                _startIndex = value;
            }
        }
        private int _currentPage;

        public int CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;
            }
        }

        private int _editId;

        public int EditId
        {
            get
            {
                return _editId;
            }
            set
            {
                _editId = value;
            }
        }

        private List<ArtikelObj> _sortedResult = new List<ArtikelObj>();

        public List<ArtikelObj> SortedResult
        {
            get
            {
                return _sortedResult;
            }
            set
            {
                _sortedResult = value;
            }
        }

        public Pagination()
        {
            _limit = 10;
        }

        public List<ArtikelObj> GetSortetList(List<ArtikelObj> _artikelCollection, string type)
        {
            if (type == "Buch")
            {
                foreach (ArtikelObj element in _artikelCollection)
                {
                    if (element is Buch)
                    {
                        SortedResult.Add(element);
                    }
                }   
            }

            if (type == "Spiele")
            {
                foreach (ArtikelObj element in _artikelCollection)
                {
                    if (element is Spiele)
                    {
                        SortedResult.Add(element);
                    }
                } 
            }

            if (type == "Dvd")
            {
                foreach (ArtikelObj element in _artikelCollection)
                {
                    if (element is Dvd)
                    {
                        SortedResult.Add(element);
                    }
                } 
            }
            CalculatePageingVars();
            return SortedResult;
        }

        public void CalculatePageingVars(){
            // Pagination Variablen
            Total = SortedResult.Count;
            Pages = (Total - (Total % Limit)) / Limit;
            Rest = Total % Limit;
            if (Rest > 0)
                Pages += 1;
        }

        public void SetNextRange()
        {
            // Startindex für die nächsten 'Limit' Ergebnisse
            StartIndex += Limit;
            CurrentPage += 1;
        }

        

        public void GetListMenueControler()
        {
            // Listenmenü ausgeben
            do
            {
                ConsoleKeyInfo menuKey = Console.ReadKey(true);
                if (menuKey.Key == ConsoleKey.F1)
                {
                    //if (CurrentPage != Pages)
                    //{
                        SetNextRange();
                    //}
                    
                    return;
                }
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Console.Write(" Geben Sie die zu bearbeitende Art.-Id. ein: ");
                    EditId = Convert.ToInt32(Console.ReadLine());
                }
                if (menuKey.Key == ConsoleKey.Escape)
                {
                    //i = Pages - 1;
                    return;
                }
            } while (true);
        }
    }
}
