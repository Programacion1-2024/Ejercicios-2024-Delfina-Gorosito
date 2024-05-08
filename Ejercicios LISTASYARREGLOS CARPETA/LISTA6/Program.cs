// Filtrar números pares en una lista. El usuario ingresará números enteros uno por uno. El programa debe solicitar al usuario que ingrese los números hasta que ingrese el número 0 para finalizar. Luego, debe mostrar los números ingresados de mayor a menor en la consola. Si se ingresa un valor no válido, se mostrará un mensaje de error//

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista para almacenar los números ingresados por el usuario
        List<int> numeros = new List<int>();

        // Pedir al usuario que ingrese los números
        Console.WriteLine("Ingresa números enteros (presiona Enter después de cada uno, o ingresa 0 para finalizar):");

        int numero;
        bool entradaValida;

        // Leer los números ingresados por el usuario y agregarlos a la lista
        do
        {
            string input = Console.ReadLine();
            entradaValida = int.TryParse(input, out numero);

            if (entradaValida)
            {
                if (numero != 0)
                {
                    numeros.Add(numero);
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero válido.");
            }
        } while (numero != 0 || !entradaValida);

        // Ordenar la lista de números de mayor a menor
        numeros.Sort((a, b) => b.CompareTo(a));

        // Mostrar los números ordenados en la consola
        Console.WriteLine("Números ingresados de mayor a menor:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}