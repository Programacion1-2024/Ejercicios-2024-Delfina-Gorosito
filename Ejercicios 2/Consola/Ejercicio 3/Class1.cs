//calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada; de unas 5 compras; Informar el total adeudado//


double Totaladecuado = 0;
int cantidadCompras = 5;

Console.WriteLine($"ingrese los datos para {{cantidadCompras}} compras: ");
for (int i = 0; i < cantidadCompras; i++)
{
    Console.WriteLine($"Compra {i + 1}:");//el signo $ es una forma de concatenar string sin el +//
    Console.Write("Costo unitario: ");
    if (!double.TryParse(Console.ReadLine(), out double costoUnitario) || costoUnitario < 0)
    {
        Console.WriteLine("Reitente ingresar un costo unitario válido.");
        i--;
    }
    else
    {
        Console.Write("Cantidad comprada: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidadComprada) || cantidadComprada < 0)
        {
            Console.WriteLine("Por favor ingrese una cantidad válida.");
            i--;
        }
        else
        {
            double subtotal = costoUnitario * cantidadComprada;
            Console.WriteLine($"Subtotal de esta compra: {subtotal} ");
            Totaladecuado += subtotal;
        }
    }
    Console.WriteLine($"Total adeudado por las {cantidadCompras} compras: {Totaladecuado} ");
}
  