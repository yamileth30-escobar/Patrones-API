using AbstracMethod.producto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    public class CarroFactory : VehiculoFactory
    {
        public override ITransporte MedioDeTransporte()
        {
            return new Carro();
        }
    }
}

// las clases que implementa una interfaz 
// la vamos a tomar como una familia de clases 
// carro -> Itransporte -> carrro Itraspotre