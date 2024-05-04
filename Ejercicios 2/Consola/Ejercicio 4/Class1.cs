//De una lista de 8 números indicar cual es el mayor//

Console.WriteLine("ingrese 8 numeros enteros: ");
int Max = 0;
for (int i = 1; i < 8; i++) ;
{
    Console.WriteLine($"Numero {i}:");
    if (int.TryParse(Console.ReadLine(), out int numero)) ;
    {
        if (numero {i} > Max);
           numero = Max;
    }
    else
    {
        Console.WriteLine("Ingreso invalido. Ingrese un numero válido");
        i--;
    }
}
Console.WriteLine($"El mayor de los numeros es: {Max}");
