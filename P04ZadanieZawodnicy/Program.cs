using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            ManagerZawodnikow mz = new ManagerZawodnikow(TypZrodlaDanych.Zdalne, sciezka);
            mz.WczytajZawodnikow();

            foreach (var z in mz.Zawodnicy)
                Console.WriteLine(z.PrzedstawSie());
            

            Console.WriteLine("-------");

            string napis = $"Średni wzrost wynosi: {mz.PodajSredniWzrost()} a waga wynosi {mz.PodajSredniaWage()}";
            Console.WriteLine(napis);

            Console.WriteLine("---------");

            foreach (var gk in mz.PodajSredniWzrostDlaKazdegoKraju())
                Console.WriteLine(gk.NazwaKraju + " " + string.Format("{0:0.00}", Math.Round(gk.SredniaWartosc,2)));
            

            Console.ReadKey();
            //https://github.com/tomasz-trener/P07Dzien3
        }
    }
}
