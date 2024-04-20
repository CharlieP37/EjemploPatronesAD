using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronesAD
{
    class SaltoComplejo : ICommand
    {
        private string accion = string.Empty;

        public SaltoComplejo(string accion)
        {
            this.accion = accion;
        }

        public void Execute()
        {
            Console.WriteLine($"Salta complejamente ({this.accion})");
        }
    }
}
