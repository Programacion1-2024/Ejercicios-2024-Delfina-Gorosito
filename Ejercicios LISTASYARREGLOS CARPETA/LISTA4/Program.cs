// Calcular promedio de notas utilizando una lista.Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas notas y mostrarlo en la consola. Utiliza una lista para almacenar las notas//

int promedioNotas = 0;
int sumaNotas = 1;
for (int i = 0; i < 5; i++)
{
    List<int> notas = new List<int>();
    Console.WriteLine("ingrese nota");
    if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int nuevaNota))  //validamos
    {
        notas[i] = nuevaNota;
    }
    else
    {
        Console.WriteLine("ingrese un numero correcto");
        i--;
    }
    {
        foreach (int nota in notas)   //recorro las notas 

            nuevaNota = sumaNotas;  //se guardan en sumaNotas
        {

            {
                Console.WriteLine(notas.ToString());
            }

            {
                promedioNotas = (int)sumaNotas / 5;
                Console.WriteLine($"El promedio de las notas ingresados son: {promedioNotas}");
                Console.WriteLine($"Las notas ingresadas son: {i} {notas[i]}");

            }
        }
    }
}