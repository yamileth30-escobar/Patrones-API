using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.producto
{
    public  class Carro : ITransporte
    {
        public void arrancar()
        {
            Console.WriteLine("Carro arrancando ");
            Console.WriteLine("Un Camaro del 24 blanco");
        }

        public void start()
        {
            Console.WriteLine("Carro en camino");
        }

        public void stop()
        {
            Console.WriteLine("Carro estacionada");
        }
    }
}
