using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EjemploPatronesAD
{
    public class Player : Prototype<Player>
    {
        string name;
        int health;
        int level;
        int experience;
        int score;
        int strength;
        int agility;
        int stamina;
        int intellect;
        int spirit;

        public string Name { get => name; set => name = value; }

        int Health { get => health; set => health = value; }

        int Level { get => level; set => level = value; }

        int Experience { get => experience; set => experience = value; }

        int Score { get => score; set => score = value; }

        int Strength { get => strength; set => strength = value; }

        int Agility { get => agility; set => agility = value; }

        int Stamina { get => stamina; set => stamina = value; }

        int Intellect { get => intellect; set => intellect = value; }

        int Spirit { get => spirit; set => spirit = value; }

        public Player Fullclone()
        {
            Player clone = (Player)this.MemberwiseClone();
            clone.name = new string(this.name);
            clone.health = new int(this.health);
            clone.level = new int(this.level);
            clone.experience = new int(this.experience);
            clone.score = new int(this.score);
            clone.strength = new int(this.strength);
            clone.agility = new int(this.agility);
            clone.stamina = new int(this.stamina);
            clone.intellect = new int(this.intellect);
            clone.spirit = new int(this.spirit);
            return clone;
        }

        public Player PartialClone()
        {
            return (Player)this.MemberwiseClone();
        }

        public void DoAction(Action X)
        {
            X.DynamicInvoke();
        }

    }
}
