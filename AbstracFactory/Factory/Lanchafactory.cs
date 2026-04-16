using AbstracMethod.producto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    internal class Lanchafactory : VehiculoFactory
    {
        public override ITransporte MedioDeTransporte()
        {
            return new Lancha ();
        }
    }
}
