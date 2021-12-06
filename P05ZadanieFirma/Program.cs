using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieFirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f = new Firma();
            f.Pracownicy = new Pracownik[3];

            f.Pracownicy[0] = new Pracownik();
            f.Pracownicy[0].Imie = "Jan";
            f.Pracownicy[0].Nazwisko = "Kowalski";
            f.Pracownicy[0].Pensja = 4000;
            //....
            f.Pracownicy[0].Faktury = new List<Faktura>();

            Faktura faktura1 = new Faktura();
            faktura1.DataUtworzenia = DateTime.Now;
            faktura1.Numer = 2134;

            f.Pracownicy[0].Faktury.Add(faktura1);

            Faktura faktura2 = new Faktura();
            faktura2.DataUtworzenia = DateTime.Now;
            faktura2.Numer = 5555;
            f.Pracownicy[0].Faktury.Add(faktura2);

            faktura2.Towary = new Towar[3];
            faktura2.Towary[0].Kategoria = Kategoria.Czarne;
            faktura2.Towary[0].Cena = 50;

            
        }
    }
}
