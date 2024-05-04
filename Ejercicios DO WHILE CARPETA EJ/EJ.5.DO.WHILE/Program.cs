// Siguiendo con el ejercicio anterior, al ingresar uno mayor a 3 cifras se mostrará elpromedio de los ingresados//

double sumaNumeros = 0;
double numero;
int contador = 0;

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
                contador++;
            }
        }
        else
        {
            Console.WriteLine("ingrese un numero valido");
            numero = 0;
        }
   
  
    } while (numero > 999);
    double promedioNumeros = (double) sumaNumeros / contador;
    Console.WriteLine($" El ingreso del número es correcto, El promedio de los números  ingresados es: {promedioNumeros}");
}