using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronesAD
{
    public interface Prototype <T>
    {
        public T Fullclone();

        public T PartialClone();
    }
}
