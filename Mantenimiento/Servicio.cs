using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescitura
{
    public abstract class Servicio
    {
        public abstract void RealizarServicio();
        public abstract double CalcularCosto(); //No hay implementacion , por tanto como es abstracto no hay instancia
        public abstract double CalcularTiempo(); // Metodo abstracto para calcular el tiempo
    }
}
