using Sobreescritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescitura
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento del coche : Cambio de aceite y revision de frenos.");
        }

        //Ocultamiento de datos 
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y Shampoo especial.");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 150.0; // Costo del mantenimiento del coche 
        }

        public override double ObtenerTiempoServicio()
        {
            return 1.3; // Tiempo de mantenimiento del coche en horas
        }

    }
}
