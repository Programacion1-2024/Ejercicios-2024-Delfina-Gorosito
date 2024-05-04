//Se necesita calcular el promedio de 8 números ingresados por el usuario//

Console.WriteLine("ingrese 8 valores enteros: ");


int suma = 0;
for (int i = 1; i < 8; i++) ;
{
    Console.WriteLine($"Numero {i}:");
    if (int.TryParse(Console.ReadLine(), out int numero)) ;
    {
        suma += numero;
    }
    else
    {
        Console.WriteLine("Ingreso invalido. Ingrese un numero válido");
        i--;
    }
}
double promedio = (double) suma / 8; 
Console.WriteLine($"La suma de los 5 numeros es: {suma}"); Console.WriteLine($"el promedio de los 8 numeros es: {promedio}");