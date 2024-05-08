using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograma
{
    /*
        Consigna: 
            Determina si una palabra o frase es un isograma.

            Un isograma (también conocido como "palabra sin patrón") es una palabra o frase sin una letra repetida; sin embargo, se permite que aparezcan espacios y guiones varias veces.

            Ejemplos de isogramas:

            lumberjacks
            background
            downstream
            six-year-old

            La palabra isogramas, sin embargo, no es un isograma porque la s se repite.

            TIPS: Funciones ToCharArray, IndexOf y LastIndexOf de la clase String
    */

    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {   //Convertir la palabra en Minuscula y elima los espacios y guiones  
            string palabraLimpia = word.ToLower().Replace(" ", "").Replace("-", "");

            // Verificar si la palabra contiene letras repetidas
            for (int i = 0; i < palabraLimpia.Length; i++)
            { //Recorro el largo de la palabra y toma con la primer letra y la compara y si la salida es distinta es false
                if (palabraLimpia.IndexOf(palabraLimpia[i]) != palabraLimpia.LastIndexOf(palabraLimpia[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}