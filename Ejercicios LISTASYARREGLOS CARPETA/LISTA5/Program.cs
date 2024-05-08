// Ordenar palabras alfabéticamente El usuario ingresará una lista de palabras. El programa debe guardar, ordenar estas palabras alfabéticamente y mostrarlas en la consola//

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista para almacenar las palabras ingresadas por el usuario
        List<string> palabras = new List<string>();

        // Pedir al usuario que ingrese las palabras
        Console.WriteLine("Ingresa las palabras (presiona Enter después de cada una, o deja en blanco para terminar):");

        // Leer las palabras ingresadas por el usuario y agregarlas a la lista
        string palabra;
        do
        {
            palabra = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(palabra))
            {
                palabras.Add(palabra);
            }
        } while (!string.IsNullOrWhiteSpace(palabra));

        // Ordenar la lista alfabéticamente
        palabras.Sort();

        // Mostrar las palabras ordenadas en la consola
        Console.WriteLine("Palabras ordenadas:");
        foreach (string p in palabras)
        {
            Console.WriteLine(p);
        }
    }
}