using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronesAD
{
    class EscudoEnergia : ICommand
    {
        private string _accion = string.Empty;

        public EscudoEnergia(string accion)
        {
            this._accion = accion;
        }

        public void Execute()
        {
            Console.WriteLine($"Activación de escudo de energia ({this._accion})");
        }
    }
}
