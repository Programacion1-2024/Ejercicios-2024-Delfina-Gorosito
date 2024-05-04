//El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos; el sistema informará cuántos nombres  han ingresado//

class Program
{
    static void Main(string[] args)
    {
        List<string> nombres = new List<string>();  // Lista para almacenar los nombres ingresados

        Console.WriteLine("Ingrese los nombres (deje vacío para terminar):");

        while (true)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))  // Verificar si el nombre es vacío o solo espacios en blanco
            {
                break;  // Si se ingresa un nombre vacío, salimos del bucle
            }

            nombres.Add(nombre);  // Agregar el nombre a la lista
        }

        int cantidadNombres = nombres.Count;  // Obtener la cantidad de nombres ingresados
        Console.WriteLine($"Se han ingresado {cantidadNombres} nombres.");
    }
}