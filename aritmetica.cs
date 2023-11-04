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
    /// <summary>
    /// Operação de multiplicação
    /// </summary>
    
    /// <returns>Devolve o resultado de multiplicação de dois numeros</returns>
        public static int Multiplicar(int x, int y){
            return x*y;
        }

        

    }

}
