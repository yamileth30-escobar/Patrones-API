using System;
using System.Collections.Generic;
using System.Text;
using AbstracMethod; // Para que reconozca la clase Vehiculo

namespace AbstracMethod.Factory
{
    // 1. Agregamos ": VehiculoFactory" para que herede de la base
    internal class AvionFactory : VehiculoFactory
    {
        // 2. Este método es el que fabrica el objeto real
        public override Vehiculo CrearVehiculo()
        {
            return new Avión();
        }

        // 3. Este es el método que imprime el mensaje en consola
        public override void selecionar()
        {
            Console.WriteLine("Se ha seleccionado un Avión para viajes largos.");
        }
    }
}
