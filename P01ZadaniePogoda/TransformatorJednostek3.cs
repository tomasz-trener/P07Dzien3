using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadaniePogoda
{
    enum JednostkaTemperatury
    {
        Celcjusz,
        Klewin,
        Farenheit
    }

    internal class TransformatorJednostek3
    {
        /// <summary>
        /// Ta metoda pozwala na konwersję jednostki z jednego typu na drugi
        /// </summary>
        /// <param name="temperatura">to jest temp do przetworzenia</param>
        /// <param name="jednDocelowa">podaj jednostkę docelową: c lub f lub k</param>
        /// <param name="jednWejsciowa">podaj jednostkę wyjsciową: c lub f lub k</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="Exception"></exception>
        public double ZamienTemperature(double temperatura, JednostkaTemperatury jednDocelowa, JednostkaTemperatury jednWejsciowa )
        {
            if (jednDocelowa == JednostkaTemperatury.Farenheit && jednWejsciowa == JednostkaTemperatury.Celcjusz)
            {
                return temperatura * 1.8 + 32;
            }

            if (jednDocelowa == JednostkaTemperatury.Klewin && jednWejsciowa == JednostkaTemperatury.Celcjusz)
            {
                return (temperatura +273.1) * 1.8;
            }

            if (jednDocelowa == JednostkaTemperatury.Celcjusz && jednWejsciowa == JednostkaTemperatury.Farenheit)
            {
                throw new NotImplementedException();
            }

            if (jednDocelowa == JednostkaTemperatury.Klewin && jednWejsciowa == JednostkaTemperatury.Farenheit)
            {
                throw new NotImplementedException();
            }

            if (jednDocelowa == JednostkaTemperatury.Celcjusz && jednWejsciowa == JednostkaTemperatury.Klewin)
            {
                throw new NotImplementedException();
            }

            if (jednDocelowa == JednostkaTemperatury.Farenheit && jednWejsciowa == JednostkaTemperatury.Klewin)
            {
                throw new NotImplementedException();
            }

            throw new Exception("Podałeś złą jednostkę");
           // return 0;

        }
    }
}
