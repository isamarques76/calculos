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
            Nulo=0, CelsiusFahrenheit, FahrenheitCelsius
        }
        /// <summary>
        /// Tipo de conversao de distancias
        /// </summary>
        public enum ConversoDistancia
        {
            Nulo=0, MetrosMilhas; MilhasMetros;
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
        /// <summary>
        /// Conversao de distancias
        /// </summary>
        /// <param name="conversao">A conversao a efetuar</param>
        /// <param name="distancia">A distancia a converter</param>
        /// <returns>O resultado da conversao</returns>
        public static double ConverterDistancias(ConversoDistancia conversao, double distancia){
            if (conversao == ConversoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213712;
            }
            else if (conversao == ConversoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }
            return -1;
        }


    }


}