// Ingresar datos en una lista y mostrarlos. Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos números en una lista y luego mostrarlos en la consola//


List<int> datos = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("ingrese un numero entero");
    if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int nuevoDato))
    {
        datos.Add(nuevoDato);
    }
    else
    {
        Console.WriteLine("ingrese un numero correcto");
            i--;
    }
    Console.WriteLine("Los datos ingresados son:");
    foreach (int dato in datos)
    {
        Console.WriteLine(dato.ToString());
    }
}