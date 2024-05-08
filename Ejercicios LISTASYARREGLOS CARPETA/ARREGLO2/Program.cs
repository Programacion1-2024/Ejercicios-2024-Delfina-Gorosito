// Calcular promedio de notas utilizando un arreglo.Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas notas y mostrarlo en la consola. Utiliza un arreglo para almacenar las notas//


class Program
{
    static void Main(string[] args)
    {
        int promedioNotas = 0;
        int sumaNotas = 0;

        int[] numeros = new int[5];
        for (int i = 0; i < numeros.Length; i++)  //Recorremos i desde la posición 0 hasta la 4//
        {
            Console.WriteLine($"ingrese un numero");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int numero)) //validamos//
            {
                numeros[i] = numero;
                sumaNotas = numeros[i];
            }
            else
            {
                Console.WriteLine("ingrese un valor valido");
                i--;
            }
        }
        for (int i = 0; i < numeros.Length; i++)
        {
            promedioNotas = (Int32) sumaNotas /5;
            Console.WriteLine($"El promedio de las notas ingresados son: {promedioNotas}");
            Console.WriteLine($"Elemento {i}: {numeros[i]}");
        }
        
    }

}
