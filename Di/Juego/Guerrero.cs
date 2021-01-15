using System;
using Ninject;

namespace Juego
{
    class Guerrero
    {
        readonly IArma arma;
        
        public Guerrero( IArma arma)
        {
            if(arma == null) throw new ArgumentNullException("arma");
            this.arma=arma;
            
        }

        public void Pelear()
        {
            this.arma.Dañar();
        }        
        
 
    }
}
