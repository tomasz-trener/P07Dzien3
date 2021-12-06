using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadaniePogoda
{
    class ManagerPogody
    {
       // const string urlSerwisu = "https://www.google.pl/search?q=pogoda";


        string urlSerwisu;
        const string ciag = "°C";
        TransformatorJednostek3 tj = new TransformatorJednostek3();
        public ManagerPogody()
        {
            urlSerwisu = "https://www.google.pl/search?q=pogoda";
        }

        public ManagerPogody(string urlSerwisu)
        {
            // mogę to samo co metodach 

            // urlSerwisu = "https://www.google.pl/search?q=pogoda";

            this.urlSerwisu = urlSerwisu;
        }

        //public void UstawSerwis(string urlSerwisu)
        //{
        //    this.urlSerwisu = urlSerwisu;
        //}

        public int PodajTemperature(string miasto, JednostkaTemperatury jednDocelowa)
        {
            string url = $"{urlSerwisu} {miasto}";

            string dane = new WebClient().DownloadString(url);

            // File.WriteAllText(@"c:\dane\pogoda.html", dane);

            int idx = dane.IndexOf(ciag);
            int aktualnyIdx = idx - 1;
            while (dane[aktualnyIdx] != '>')
                aktualnyIdx--;

            string wynik = dane.Substring(aktualnyIdx + 1, idx - aktualnyIdx + 1);

            int temp= Convert.ToInt32(wynik.Substring(0, wynik.Length - 2));

            double wynikTemp= tj.ZamienTemperature(temp, jednDocelowa, JednostkaTemperatury.Celcjusz);
            return Convert.ToInt32(wynikTemp);
        }





    }
}
