using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EjemploPatronesAD
{
    public interface ICommand
    {
        void Execute();
    }

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
