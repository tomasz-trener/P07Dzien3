using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07BibliotekaZadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta k = new Karta()
            {
                Autor = new Autor[2]
                {
                    new Autor()
                    {
                        Imie = "L",
                        Nazwisko = "Taranloga",
                        DrugieImie = "A"
                    },
                    new Autor()
                    {
                        Imie = "I",
                        Nazwisko = "Tichy",
                    },
                },
                Wydanie = 1,
                Cena = new Cena()
                {
                    Wartosc = 17.5,
                    Uwagi = "Zakup z 18..."
                },
                Sygnatury = new Sygnatura[4]
                {
                    new Sygnatura(),
                    new Sygnatura()
                    {
                        Aktywna =false,
                        Numer= 012371,
                        Uwagi = "Zgloszona utrawa...",
                        Wypozyczenia = new Wypozyczenie[4]
                        {
                            new Wypozyczenie(),
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty = "B2354"
                                },
                                Przedluzenie = new Wypozyczenie()
                                {
                                    RzeczywistaDataZwrotu = new DateTime(2000,3,15)
                                }
                            },
                            new Wypozyczenie(),
                            new Wypozyczenie(),
                        }
                    } ,
                    new Sygnatura(),
                    new Sygnatura(),
                }
            };
        }
    }
}
