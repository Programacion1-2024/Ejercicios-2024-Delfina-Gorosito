
//ejercicio 1 //
Console.Write("ingrese un numero: ");
int numero1, numero2;
if (!Int32.TryParse(Console.ReadLine(), out numero1))
{
    Console.WriteLine("Error, debe ingresar un numero correcto");
 }
else
{
    Console.Write("ingrese otro numero: ");
    if (!Int32.TryParse(Console.ReadLine(), out numero2))
}
else
 {
    Console.WriteLine("la suma de los dos numeros es:" + (numero1 + numero2));
}

}

