using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieZawodnicy
{
    enum TypZrodlaDanych
    {
        Lokalne,
        Zdalne,
       
    }

    class ManagerZawodnikow
    {
       // const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

        public Zawodnik[] Zawodnicy;

        private TypZrodlaDanych typ;
        private string sciezka;

        public ManagerZawodnikow(TypZrodlaDanych typ, string sciezka)
        {
            this.typ = typ;
            this.sciezka = sciezka;
        }


        public void WczytajZawodnikow() 
        {
            string dane ="";
            if (typ== TypZrodlaDanych.Zdalne)
            {
                WebClient wc = new WebClient();
                dane = wc.DownloadString(sciezka);
            }else if(typ == TypZrodlaDanych.Lokalne)
            {
                dane = File.ReadAllText(sciezka);
            }
            else
            {
                throw new NotImplementedException();
            }

            // string[] wiersze = dane.Split();

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length - 1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                Zawodnik z = new Zawodnik(komorki[2], komorki[3]);
                z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                //if(komorki[1] != "")
                if (!string.IsNullOrWhiteSpace(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);
                //   z.Imie = komorki[2];
                //   z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUr = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);

                zawodnicy[i - 1] = z;
            }

            Zawodnicy= zawodnicy;
        }

        public double PodajSredniWzrost()
        {
            double wzrost = 0;
            for (int i = 0; i < Zawodnicy.Length; i++)
                wzrost += Zawodnicy[i].Wzrost;

            return wzrost / Zawodnicy.Length;
        }

        public double PodajSredniWzrost(string kraj)
        {
            double wzrost = 0;
            int k = 0;
            for (int i = 0; i < Zawodnicy.Length; i++)
            {
                if (Zawodnicy[i].Kraj == kraj)
                {
                    wzrost += Zawodnicy[i].Wzrost;
                    k++;
                }
            }
            return wzrost / k;
        }

        public double PodajSredniaWage()
        {
            double waga = 0;
            foreach (var z in Zawodnicy)
                waga += z.Waga;

            return waga / Zawodnicy.Length;
        }

        public GrupaKraj[] PodajSredniWzrostDlaKazdegoKraju()
        {
            string[] kraje = PodajKraje();

            GrupaKraj[] wynik = new GrupaKraj[kraje.Length];

            for (int i = 0; i < kraje.Length; i++)//foreach (var k in kraje)  
            {
                double wzrost= PodajSredniWzrost(kraje[i]);

                GrupaKraj gk = new GrupaKraj(kraje[i], wzrost);
               // gk.NazwaKraju = kraje[i];
              //  gk.SredniaWartosc = wzrost;

                wynik[i] = gk;
            }
            return wynik;
        }

        private string[] PodajKraje()
        {
            List<string> kraje = new List<string>();
            foreach (var z in Zawodnicy)
                if (!kraje.Contains(z.Kraj))
                    kraje.Add(z.Kraj);

            return kraje.ToArray();
        }
    }
}
