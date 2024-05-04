//el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetireste ingreso hasta que el usuario ingrese la clave correcta: 667788//

const string claveCorrecta = "667788";  //Defino la clave correcta//

string nombreUsuario;
string claveIngresada;  //Variables para almacenar nombre y clave del usuario//

do
{
    Console.Write("Ingrese nombre de usuario: ");
    nombreUsuario = Console.ReadLine();

    Console.Write("Ingrese clave: ");
    claveIngresada = Console.ReadLine();
} while (claveIngresada != claveCorrecta);

Console.WriteLine("Bienvenido al sistema, " + nombreUsuario + ".");
Console.ReadKey(); //Mantenerlo abierta hasta que el usuario presione una tecla//
