using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura
{
    public class Vehiculo
    {
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento general del vehiculo");
        }

        public  void Lavar()
        {
            Console.WriteLine("Lavando el vehiculo");
        }
        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0; //costo base de mantenimiento General
        }

        public virtual double ObtenerTiempoServicio()
        {
            return 2.0; //tiempo base de mantenimiento General en horas
        }


    }
}
