//El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero).El sistema deberá informar la suma de los ingresados//


Console.WriteLine("Ingrese valores positivos: ");
float valor = 1;
float sumaValor = 0;
while (valor != 0)
{
    if (!float.TryParse(Console.ReadLine(), out valor)) ; //esto se utiliza para validar//
    {
        Console.WriteLine("El numero ingresado no es valido. Ingrese otro numero.");
        valor = 1;
    } 
    else
    {
        sumaValor += valor;
    }
}
Console.WriteLine($"La suma de los valores ingresados es : {sumaValor}");