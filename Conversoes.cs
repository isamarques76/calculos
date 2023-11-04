using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal static class Conversoes
    {
        /// <summary>
        /// conversao de temperaturas
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo=8;
            CelsiusFahrenheit, FahrenheitCelsius
        }
        /// <summary>
        /// Conversao de temperaturas
        /// </summary>
        /// <param name="conversao"> a conversao a efetuar</param>
        /// <param name="temperatura">a temperatura a converter</param>
        /// <returns></returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura*1.00+32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura-32)/1.8000);

            }
            return -1;

        }


    }


}