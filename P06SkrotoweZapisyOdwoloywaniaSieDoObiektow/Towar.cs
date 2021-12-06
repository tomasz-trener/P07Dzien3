using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06SkrotoweZapisyOdwoloywaniaSieDoObiektow
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
