using System;
using Ninject;

namespace Juego
{
    class Guerrero:IPersonaje
    {
        readonly IArma arma;
        public string Nombre { get; set; }
        
        public Guerrero( IArma arma)
        {            
            this.arma=arma;
            
        }

        public void Pelear()
        {
            this.arma.Dañar(Nombre);
        }        
        
        
 
    }
}
