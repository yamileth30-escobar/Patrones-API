using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    // 1. Agregamos ": VehiculoFactory" para que sea una fábrica oficial
    internal class CamionFactory : VehiculoFactory
    {
        // 2. Este método crea el objeto Camión
        public override Vehiculo CrearVehiculo()
        {
            return new Camión();
        }

        // 3. Este es el que usas en el Program.cs para mostrar el mensaje
        public override void selecionar()
        {
            Console.WriteLine("Se ha seleccionado un Camión para la mudanza.");
        }
    }
}
