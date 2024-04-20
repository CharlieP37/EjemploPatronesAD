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

        public int Health { get => health; set => health = value; }

        public int Level { get => level; set => level = value; }

        public int Experience { get => experience; set => experience = value; }

        public int Score { get => score; set => score = value; }

        public int Strength { get => strength; set => strength = value; }

        public int Agility { get => agility; set => agility = value; }

        public int Stamina { get => stamina; set => stamina = value; }

        public int Intellect { get => intellect; set => intellect = value; }

        public int Spirit { get => spirit; set => spirit = value; }

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
