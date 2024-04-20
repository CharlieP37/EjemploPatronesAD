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
            clone.health = this.health;
            clone.level = this.level;
            clone.experience = this.experience;
            clone.score = this.score;
            clone.strength = this.strength;
            clone.agility = this.agility;
            clone.stamina = this.stamina;
            clone.intellect = this.intellect;
            clone.spirit = this.spirit;
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
