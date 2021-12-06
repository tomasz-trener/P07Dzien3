using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06SkrotoweZapisyOdwoloywaniaSieDoObiektow
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f = new Firma()
            {
                Pracownicy = new Pracownik[3]
                {
                    new Pracownik()
                    {
                        Imie = "Jan",
                        Nazwisko = "Kowalski",
                        Pensja = 4000,
                        Faktury = new List<Faktura>()
                        {
                            new Faktura()
                            {
                                DataUtworzenia = DateTime.Now,
                                Numer = 2134,
                                Towary = new Towar[3]
                                {
                                    new Towar()
                                    {
                                        Cena = 50,
                                        Kategoria = Kategoria.Czarne
                                    },
                                    new Towar(),
                                    new Towar()
                                }
                            },
                            new Faktura()
                            {
                                DataUtworzenia = DateTime.Now,
                                Numer = 5555
                            }
                        }
                        
                    },
                    new Pracownik(),
                    new Pracownik()
                }
            };

             
        }
    }
}
