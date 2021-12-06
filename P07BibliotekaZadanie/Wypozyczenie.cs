using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07BibliotekaZadanie
{
    class Wypozyczenie
    {
        public Czytelnik Czytelnik;
        public DateTime PrzewidywanaDataZwrotu;
        public DateTime RzeczywistaDataZwrotu;
        public string Uwagi;
        public Wypozyczenie Przedluzenie;
    }
}
