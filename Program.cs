using System.ComponentModel.Design;

Console.WriteLine("ingrese numero: " );
string numero1 = Console.ReadLine();
Console.WriteLine("ingrese otro numero: ");
string numero2 = Console.ReadLine();
Convert.ToInt16(numero1);
Convert.ToInt16(numero2);
Console.WriteLine("el total es:" +(numero1 + numero2));
//ejercicio borrador//

//ejercicio 1 bien hecho//
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

