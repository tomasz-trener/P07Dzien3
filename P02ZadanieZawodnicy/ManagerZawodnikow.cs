using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieZawodnicy
{
    class ManagerZawodnikow
    {
        const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        public string[] PodajZawodnikow(string kraj)
        {
            string dane = new WebClient().DownloadString(url);

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> imionaNazwiska = new List<string>();

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                {
                    imionaNazwiska.Add(komorki[2] + " " + komorki[3]);
                }
            }

            return imionaNazwiska.ToArray(); 

        }
    }
}
