using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_de_Armstrong
{
    /*
        Consigna: 
            Un número de Armstrong es un número que es la suma de sus propios dígitos, cada uno elevado a la potencia del número de dígitos.

            Por ejemplo:
                9 es un número de Armstrong, porque9 = 9^1 = 9
                10 no es un número de Armstrong, porque10 != 1^2 + 0^2 = 1
                153 es un número de Armstrong porque:153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
                154 no es un número de Armstrong porque:154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190

            Escribe un código para determinar si un número es un número de Armstrong.
    */

    public static class ArmstrongNumbers
    {

        public static bool IsArmstrongNumber(int number)
        {
            // Convertir el número a una cadena para facilitar el manejo de los dígitos
            string numberStr = number.ToString();
            int numDigits = numberStr.Length;
            int sum = 0;

            // Calcular la suma de los dígitos elevados a la potencia del número de dígitos
            foreach (char digitChar in numberStr)
            {
                //int digit = digitChar - '0'; // Convertir el carácter del dígito a un entero
                int digit = Int32.Parse(digitChar.ToString());
                sum += (int)Math.Pow(digit, numDigits);
            }

            // Comparar la suma con el número original
            return sum == number;
        }
    }
}

//toma un número, calcula la suma de sus dígitos elevados a la potencia del número total de dígitos, y luego compara esa suma con el número original. Si coinciden, es un número de Armstrong.