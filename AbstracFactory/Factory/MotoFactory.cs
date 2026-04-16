using AbstracMethod.producto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    internal class MotoFactory : VehiculoFactory
    {
        public override ITransporte MedioDeTransporte()
        {
            return new Moto();
        }
    }
}
