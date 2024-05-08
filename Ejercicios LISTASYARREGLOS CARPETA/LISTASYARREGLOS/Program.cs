// Ingresar datos en un arreglo y mostrarlos.Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos números en un arreglo y luego mostrarlos en la consola//

class Program
{
    static void Main(string[] args)
{
    int[] numeros = new int[5];
    for (int i = 0; i < numeros.Length; i++)  //Recorremos i desde la posición 0 hasta la 4//
    {
        Console.WriteLine($"ingrese un numero");
        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int numero)) //validamos//
        {
            numeros[i] = numero;
        }
        else
        {
            Console.WriteLine("ingrese un valor valido");
            i--;
        }
    }
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine($"Elemento {i}: {numeros[i]}");
    }

}

}
