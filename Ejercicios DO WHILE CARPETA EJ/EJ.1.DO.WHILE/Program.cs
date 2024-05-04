//Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo//


{
    float numero;
    do
    {
        Console.WriteLine("Por favor, ingresa un número negativo:");

        if (!float.TryParse(Console.ReadLine(), out numero)) ;
        {
            if (numero <= 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("ingrese un numero valido");
                numero = 0;
            }

        }
    }
    while (numero <= -1) ;
    Console.WriteLine("¡Has ingresado un número positivo!");
}







