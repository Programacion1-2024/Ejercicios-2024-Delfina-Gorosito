//El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5.//

Console.WriteLine("ingrese 5 valores enteros: ");

int suma = 0;
for (int i = 1; i < 5; i++) ;
{
    Console.WriteLine($"Valor {i}:");
    if (int.TryParse(Console.ReadLine(), out int numero)) ;
    {
        suma += numero;
    } 
    else
    {
                Console.WriteLine("Ingreso invalido. Ingrese un numero válido");
                 int--;
            
        
        Console.WriteLine($"La suma de los 5 numeros es: {suma}");
    }
}