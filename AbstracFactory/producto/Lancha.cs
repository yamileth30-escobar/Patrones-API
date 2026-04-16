using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.producto
{
    public  class Lancha : ITransporte
    {
        public void arrancar()
        {
            Console.WriteLine("Lancha arrancando ");
            Console.WriteLine("Tiene 4 flotadores");
        }

        public void start()
        {
            Console.WriteLine("Lancha en camino");
        }

        public void stop()
        {
            Console.WriteLine("Lancha estacionada");
        }
    }
}
