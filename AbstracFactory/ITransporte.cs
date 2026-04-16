using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod
{
    public  interface ITransporte
    {
        #region explicacion interfaz
        // los metodoas abstractos de una interfaz 
        // nos permiten definir que hacer 
        // pero no como hacerlo 
        // permitir definir comportamientos 

        // metodos en comun estos metodos en comun 
        // una implmentacion por que las interfaz no se 
        // puede abstraer 
        // no se puede abstraer por que no tiene logica 
        #endregion

        public void arrancar();
        public void stop();
        public void start();

 
    }
}

// arrancar 
// detener
// moverse