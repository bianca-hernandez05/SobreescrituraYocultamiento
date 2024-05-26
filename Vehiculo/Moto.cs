using Sobreescritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescitura
{
     public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto : Lubricacion de cadena Y revision de neumaticos.");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 100.0; // Costo del mantenimiento de la moto
        }

        public override double ObtenerTiempoServicio()
        {
            return 0.5/60; // Tiempo de mantenimiento de la moto convertido a hora 
        }

    }
}
