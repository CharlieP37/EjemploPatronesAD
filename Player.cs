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
        public Player Fullclone()
        {
            Player clone = (Player)this.MemberwiseClone();
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
