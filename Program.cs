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
    Console.WriteLine("Ingrese 1 para hacer una copia completa, 2 para una copia parcial o 3 para salir.");
    Console.Write("Solicitud: ");
    Input = Console.ReadLine();

    if (Input == "1") 
    {

    }
    else if (Input == "2") 
    {
        
    }

    DefaultPlayer.Action(() => new SaltoComplejo("Arriba").Execute());

}