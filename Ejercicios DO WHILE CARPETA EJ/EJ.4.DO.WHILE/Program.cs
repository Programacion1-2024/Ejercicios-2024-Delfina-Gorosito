// ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras. Mostrar la suma total de todos los ingresados antes del corte//

double sumaNumeros = 0;
double numero;

{
    do
    {
        Console.WriteLine(" Ingresa un número:");

        if (!double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
        {

            if (numero < 999)
            {
                Console.WriteLine("error");
                sumaNumeros += numero;
                
            }
        }
        else
        {
            Console.WriteLine("ingrese un numero valido");
            numero = 0;
        }


    } while (numero > 999);
    sumaNumeros += numero;
    Console.WriteLine("La suma total de todos los números ingresados es: " + sumaNumeros);
}


