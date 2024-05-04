// Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados//

int contadorNegativos = 0; 
int sumaNegativos = 0;
int numero;

{

    do
    {
        Console.WriteLine("Por favor, ingresa un número negativo:");

        if (!int.TryParse(Console.ReadLine(), out numero))
        {
            numero = -1;
        }
        if (numero < 0)
        {
            sumaNegativos += numero;
            contadorNegativos++;

        }
    }

    while (numero > 0);

    if (contadorNegativos > 0)
    {
        double promedioNegativos = (double)sumaNegativos / contadorNegativos;
        Console.WriteLine($"El promedio de los números negativos ingresados es: {promedioNegativos}");
    }
    else
    {
        Console.WriteLine("No se ingresaron números negativos.");
    }

}

