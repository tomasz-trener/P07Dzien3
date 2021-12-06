using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07BibliotekaZadanie
{
    class Karta
    {
        public string Tytul;
        public string Numer;
        public int Wydanie;
        public DateTime DataZakupu;
        public Sygnatura[] Sygnatury;
        public Karta Nastepna;
        public Karta Poprzednia;
        public Cena Cena;
        public Autor[] Autor;
    }
}
