using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritmeticas 
    /// </summary>
    internal static class aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo=8;
            CelsiusFahrenheit, FahrenheitCelsius
        }

        /// <summary>
        /// realiza a soma
        /// </summary>
        
        /// <returns>
        /// devolve a soma de dois numeros</returns>
        public static int Somar(int x, int y){
            return x+y; 
        }


        /// <summary>
        /// realiza a subtração
        /// </summary>
        
        /// <returns>
        /// devolve a subtração de dois numeros</returns>
        public static int Subtrair(int x, int y){
            return x-y;
        }

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
