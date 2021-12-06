using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlSerwisu = "https://www.google.pl/search?q=pogoda";

            ManagerPogody mp = new ManagerPogody(urlSerwisu);
           
           // mp.UstawSerwis(urlSerwisu);

            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();
                int temp = mp.PodajTemperature(miasto, JednostkaTemperatury.Farenheit);

                Console.WriteLine(temp);
            }

           // Console.ReadKey();
        }
    }
}
