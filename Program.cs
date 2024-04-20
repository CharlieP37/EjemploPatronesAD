// See https://aka.ms/new-console-template for more information

using EjemploPatronesAD;
using System.Resources;

string? Input = "";

List<Player> playerlist = new List<Player>();

Console.WriteLine("Prueba de patrón de diseño PROTOTIPOS");
Console.WriteLine("Carlos Pop - 1069920\nDiego Gil - \nDiego Calel - \n");
Console.WriteLine("Personaje default:");

Player DefaultPlayer = new Player();

DefaultPlayer.Name = "Default";
DefaultPlayer.Health = 100;
DefaultPlayer.Level = 1;
DefaultPlayer.Experience = 0;
DefaultPlayer.Score = 0;
DefaultPlayer.Strength = 1;
DefaultPlayer.Agility = 1;
DefaultPlayer.Stamina = 1;
DefaultPlayer.Intellect = 1;
DefaultPlayer.Spirit = 1;

Console.WriteLine("Nombre: " + DefaultPlayer.Name);
Console.WriteLine("Salud: " + DefaultPlayer.Health);
Console.WriteLine("Nivel: " + DefaultPlayer.Level);
Console.WriteLine("Experiencia: " + DefaultPlayer.Experience);
Console.WriteLine("Score: " + DefaultPlayer.Score);
Console.WriteLine("Fuerza: " + DefaultPlayer.Strength);
Console.WriteLine("Agilidad: " + DefaultPlayer.Agility);
Console.WriteLine("Resistencia: " + DefaultPlayer.Stamina);
Console.WriteLine("Intelecto: " + DefaultPlayer.Intellect);
Console.WriteLine("Espiritu: " + DefaultPlayer.Spirit);

playerlist.Add(DefaultPlayer);

Console.WriteLine("\n");

while (Input != "3" || Input == null)
{
    Console.WriteLine("Ingrese 1 para crear un nuevo juegador, 2 para realizar una acción con un jugador o 3 para salir.");
    Console.Write("Solicitud: ");
    Input = Console.ReadLine();

    if (Input == "1") 
    {
        Console.WriteLine("Indique los sigueintes atributos del personaje que desea cambiar o dejar");
        Console.WriteLine("Deje el campo vació para no hacer cambio");

        Player newplayer = DefaultPlayer.Fullclone();

        Console.WriteLine("Nombre: " + newplayer.Name);

        var i = Console.ReadLine();

        if (i != "" || i != null)
        {
            newplayer.Name = i;
        }

        Console.WriteLine("Salud: " + newplayer.Health);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try 
            {
                newplayer.Health = Convert.ToInt32(i);
            } 
            catch 
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Nivel: " + newplayer.Level);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Level = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Experiencia: " + newplayer.Experience);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Experience = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Score: " + newplayer.Score);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Score = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Fuerza: " + newplayer.Strength);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Strength = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Agilidad: " + newplayer.Agility);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Agility = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Resistencia: " + newplayer.Stamina);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Stamina = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Intelecto: " + newplayer.Intellect);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Intellect = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        Console.WriteLine("Espiritu: " + newplayer.Spirit);

        i = Console.ReadLine();

        if (i != "" || i != null)
        {
            try
            {
                newplayer.Spirit = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Error, no se pudo cambiar correctamente el valor del atributo.");
            }
        }

        playerlist.Add(newplayer);

        Console.WriteLine("Nuevo jugador: ");
        Console.WriteLine("Nombre: " + newplayer.Name);
        Console.WriteLine("Salud: " + newplayer.Health);
        Console.WriteLine("Nivel: " + newplayer.Level);
        Console.WriteLine("Experiencia: " + newplayer.Experience);
        Console.WriteLine("Score: " + newplayer.Score);
        Console.WriteLine("Fuerza: " + newplayer.Strength);
        Console.WriteLine("Agilidad: " + newplayer.Agility);
        Console.WriteLine("Resistencia: " + newplayer.Stamina);
        Console.WriteLine("Intelecto: " + newplayer.Intellect);
        Console.WriteLine("Espiritu: " + newplayer.Spirit);

    }
    else if (Input == "2")
    {

        Input = "";

        while (Input != "1" && Input != "2" || Input == null)
        {
            Console.WriteLine("Ingrese 1 para hacer un salto complejo, 2 para activar un escudo de energia.");
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
    }

}