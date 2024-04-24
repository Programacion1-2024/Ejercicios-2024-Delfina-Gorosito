//calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.//

Console.WriteLine("Ingrese costo unitario y cantidad comprada: ");
float costoUnitario = 1;
float cantidadComprada = 1;

while (costoUnitario != 0)
{
    if (!float.TryParse(Console.ReadLine(), out costoUnitario)) ; //esto se utiliza para validar//
    {
        Console.WriteLine("El costo ingresado no es valido. Ingrese otro numero.");
        costoUnitario = 1;
    }
    else
    {
        cantidadComprada += costoUnitario;
    }
}
Console.WriteLine($"El total de los datos ingresados  es : {cantidadComprada}");