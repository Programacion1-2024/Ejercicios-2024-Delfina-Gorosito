//calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró; luego el sistema solicitará que ingrese el costo de cada uno de esos productos consumidos; al terminar informará el total adeudado//

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese cuántos productos compró:");
        int cantidadProductos = int.Parse(Console.ReadLine());

        double totalAdeudado = 0;
        int contador = 0;

        while (contador < cantidadProductos)
        {
            contador++;

            Console.WriteLine("Ingrese el costo del producto #" + contador + ":");
            double costoProducto = double.Parse(Console.ReadLine());

            totalAdeudado += costoProducto;
        }

        Console.WriteLine("Total adeudado por el cliente: $" + totalAdeudado);
    }
}