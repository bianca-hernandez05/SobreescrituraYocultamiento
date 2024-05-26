using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescitura
{
    public class CambioAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }
        public override double CalcularCosto()
        {
            return 50.0; // costo del cambio de aceite
        }

        public override double CalcularTiempo()
        {
            return 0.5 / 60; // Tiempo del cambio de aceite en horas
        }

    }
}
