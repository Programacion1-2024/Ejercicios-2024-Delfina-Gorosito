// Retomando el ejercicio 1 ; al finalizar la carga de productos, se ingresan las ventas que hubo por cada código, puede haber más de 1 venta por cada articulo. El ingreso finaliza al colocar un código en 0. Informar al final los que tienen una cantidad (osea la cantidad inicial , restando las ventas que tuvo) menor o igual a 0//

Console.WriteLine("Ingrese el código del producto del 1 al 10 y 0 para terminar.");
int codigo = 1;
int NUM_PRODUCTOS = 10;
int[] cantidades = new int[NUM_PRODUCTOS];
double[] precios = new double[NUM_PRODUCTOS];
int CantidadMax = 0;
int codigoCantidadMax = 0;
double precio = 0;
int producto = 0;
int cantidad = 0;

do
{
    Console.Write("Ingrese el código del producto:");

    if (!Int32.TryParse(Console.ReadLine(), out codigo))
    {
        Console.WriteLine("Error, debe ingresar un número.");
    }
    Console.Write("Ingrese el precio del producto: ");
    if (!Double.TryParse(Console.ReadLine()?.Replace(",", "."), out precio))
    {
        Console.WriteLine("Error, debe ingresar un número");
    }
    Console.Write("Ingrese la cantidad del producto: ");
    if (!Int32.TryParse(Console.ReadLine(), out producto))
    {
        Console.WriteLine("Error, debe ingresar un número.");
    }
    else
    {
        cantidades[codigo - 1] += cantidad;
        precios[codigo - 1] = precio;
    }

} while (codigo != 0);


for (int i = 0; i < NUM_PRODUCTOS; i++)
{
    if (cantidades[i] > CantidadMax)
    {
        CantidadMax = cantidades[i];
        codigoCantidadMax = i + 1;
    }
}

Console.WriteLine($"El producto con mayor cantidad es el código {codigoCantidadMax} con {CantidadMax} unidades.");