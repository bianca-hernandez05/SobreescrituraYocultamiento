using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescitura
{
   public class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparacion de frenos.");
        }
        public override double CalcularCosto()
        {
            return 100.0; // costo de la reparacion de frenos
        }

        public override double CalcularTiempo()
        {
            return 1.0; // Tiempo de la reparación de frenos en horas
        }


    }
}
