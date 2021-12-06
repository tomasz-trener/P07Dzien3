using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieManagerZawodnikow
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane=  wc.DownloadString(url);

           // string[] wiersze = dane.Split();

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length-1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                Zawodnik z = new Zawodnik(komorki[2], komorki[3]);
                z.Id_zawodnika = Convert.ToInt32(komorki[0]);
                z.Id_trenera = Convert.ToInt32(komorki[1]);
             //   z.Imie = komorki[2];
             //   z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUr = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);

                zawodnicy[i - 1] = z;
            }

            // teraz mogę wyświetlić dane

            for (int i = 0; i < zawodnicy.Length; i++)
            {
              //  Console.WriteLine("Nazywam sie " + zawodnicy[i].Imie + " " + zawodnicy[i].Nazwisko );
                Console.WriteLine(zawodnicy[i].PrzedstawSie());
            }

            Console.ReadKey();
        }
    }
}
