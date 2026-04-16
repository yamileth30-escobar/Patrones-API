using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    // 1. LA CLASE PADRE 
    public abstract class VehiculoFactory
    {
        public abstract ITransporte MedioDeTransporte();

        public ITransporte selecionar()
        {
            ITransporte transporte = MedioDeTransporte();
            transporte.start();
            transporte.stop();
            transporte.arrancar();
            return transporte;
        }
    } 

    // 2. LA FÁBRICA DE CAMIONES 
    public class CamionFactory : VehiculoFactory
    {
        public override ITransporte MedioDeTransporte()
        {
            return new Camión();
        }
    }

    // 3. LA FÁBRICA DE AVIONES 
    public class AvionFactory : VehiculoFactory
    {
        public override ITransporte MedioDeTransporte()
        {
            return new Avión();
        }
    }
}