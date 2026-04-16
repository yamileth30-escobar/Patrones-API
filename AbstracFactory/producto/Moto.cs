using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.producto
{
    public class Moto : ITransporte
    {
        #region
        // cuando aplicamos una interfaz 
        // obliga a la calse a tener todos los metodos 
        //abstractos que tiene la interfaz.
        // no es una abstraccion sino una implenetacion.
        #endregion
        // la logica esta en nuestros corazones 
        // la logica se impl;ementa desde el clase de la 
        //  que ejecutla la funcion 

        // es un arbitro -> impone las reglas.
        public void arrancar()
        {
            Console.WriteLine("Moto arrancando ");
        }

        public void start()
        {
            Console.WriteLine("Moto en camino");
        }

        public void stop()
        {
            Console.WriteLine("Moto estacionada");
        }
    }
}
