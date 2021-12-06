using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            string kraj = "pol";
            string[] imionaNazwiska= mz.PodajZawodnikow(kraj);

            const string sciezka = @"c:\dane\";
            File.WriteAllLines($"{sciezka}{kraj}.txt", imionaNazwiska);
        }
    }
}
