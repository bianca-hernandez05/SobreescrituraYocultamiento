using Sobreescitura;
using Sobreescritura;

namespace Sobreeescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Holiiii, que tal Bienvenido A Mantenimientos Las 3b  ");
            Console.WriteLine();

            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento(); // output: Realizando mantenimineto del coche : Cambio de aceite y revision de frenos 
            Console.WriteLine("Costo del mantenimiento del coche : $"+ miCoche.ObtenerCostoMantenimiento());
            Console.WriteLine();
       
            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento(); // output : Realizando mantenimiento de la moto : Lubricacion de cadena y revision de neumaticos
            Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());

            Console.WriteLine();    
            miCoche.Lavar(); // sale Lavar Vehiculo
            Console.WriteLine();
            Coche miCocheReal = new Coche(); //instanciar la clase que posee el ocultamiento de datos 
            miCocheReal.Lavar();    // output : Lavando el coche con cera y shampoo especial

            Console.WriteLine();
            Servicio servicioAceite = new CambioAceite();
            servicioAceite.RealizarServicio(); // output: Realizando cambio de aceite.
            Console.WriteLine("Costo del cambio de aceite : $"+ servicioAceite.CalcularCosto());
            Console.WriteLine() ;

            Servicio servicioFrenos = new ReparacionFrenos();
            Servicio servicioCambioAceite = new CambioAceite(); // instanciamos cambio de aceite para presentar el calculo del tiempo 
            servicioFrenos.RealizarServicio(); // output: Realizando reparación de frenos.
            servicioCambioAceite.RealizarServicio();
            Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalcularCosto());
            Console.WriteLine();

            //Vehiculo vehiculo = new Vehiculo();
            //vehiculo.ObtenerTiempoServicio();
            //Console.WriteLine("Duracion de servicios en un vehiculo : "+ vehiculo.ObtenerTiempoServicio() + " Hrs ");
            //Console.WriteLine();    

            Console.WriteLine("-- Duracion de los Servicio --");
            Console.WriteLine("Tiempo de la reparación de frenos en el vehiculo : " + servicioFrenos.CalcularTiempo() + " hora");
            Console.WriteLine("Tiempo del cambio de aceite en el vehiculo : "+ servicioCambioAceite.CalcularTiempo()+" - "+ " 50 minutos ") ;

            Console.WriteLine();
            Console.WriteLine("--A continuacion se Presentara el tiempo de espera de los servicios para cada vehiculo--");
            Console.WriteLine();
            Console.WriteLine("--Para el coche--");
            Vehiculo micoche = new Coche();
            micoche.ObtenerTiempoServicio();
            Console.WriteLine("Tiempo de ambos servicios es de : " + micoche.ObtenerTiempoServicio()+ " - " + " 1 Hr " + "Con 30 minutos ");
      
            Console.WriteLine();
            Console.WriteLine("--Para la moto--");
            Vehiculo mimoto = new Moto();
            mimoto.ObtenerTiempoServicio();
            Console.WriteLine("Tiempo de ambos servicios es de : " + mimoto.ObtenerTiempoServicio() + " Hr " + " - " + " 50 minutos ");

            //Servicio Ser = new Servicio(); // No se puede crear la instancia de una clase abstracta

        }
    }
}
