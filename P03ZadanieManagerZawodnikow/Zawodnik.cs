using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieManagerZawodnikow
{
    class Zawodnik
    {
        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUr;
        public int Wzrost;
        public int Waga;

       // private int kolorWolsow;

        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string PrzedstawSie()
        {
            string napis = $"Nazywam się {Imie} {Nazwisko} i pochodzę z {Kraj}";
            return napis;
        }
    }
}
