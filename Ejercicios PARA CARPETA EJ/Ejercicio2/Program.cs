//Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados//

Console.WriteLine("Ingrese valores positivos: ");
float valor = 1;
float calcularPromedio = 0;
while (valor != 0)
{
    if (!float.TryParse(Console.ReadLine(), out valor)) ; //esto se utiliza para validar//
    {
        Console.WriteLine("El numero ingresado no es valido. Ingrese otro numero.");
        valor = 1;
    }
    else
    {
        calcularPromedio += valor;
    }
}
Console.WriteLine($"El promedio de los valores ingresados es : {calcularPromedio}");