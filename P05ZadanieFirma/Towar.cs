using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieFirma
{
    enum Kategoria
    {
        Czerwone,
        Czarne,
        Niebieskie,
        Zolte
    }
    class Towar
    {
        public double Cena;
        public Kategoria Kategoria;
    }
}
