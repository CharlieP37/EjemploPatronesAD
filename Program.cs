// See https://aka.ms/new-console-template for more information

using EjemploPatronesAD;
using System.Resources;

string? Input = "";

Console.WriteLine("Prueba de patrón de diseño PROTOTIPOS");
Console.WriteLine("Carlos Pop - 1069920\nDiego Gil - \nDiego Calel - \n");
Console.WriteLine("Personaje default:");

Player DefaultPlayer = new Player();

Console.WriteLine("\n");

while (Input != "3" || Input == null)
{
    Console.WriteLine("Ingrese 1 para hacer un salto complejo, 2 para activar un escudo de energia o 3 para salir.");
    Console.Write("Solicitud: ");
    Input = Console.ReadLine();

    if (Input == "1") 
    {
        Console.Write("Indique a qué dirección desea saltar: ");
        var i = Console.ReadLine();
        DefaultPlayer.DoAction(() => new SaltoComplejo(i).Execute());

    }
    else if (Input == "2") 
    {
        Console.Write("Indique qué tipo de escudo de energía desea activar:");
        var i = Console.ReadLine();
        DefaultPlayer.DoAction(() => new EscudoEnergia(i).Execute());
    }

}