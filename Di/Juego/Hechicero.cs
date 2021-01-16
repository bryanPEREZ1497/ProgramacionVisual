using System;

namespace Juego
{
    class Hechicero:IPersonaje
    {
        readonly IArma arma;
         public string Nombre { get; set; }

        public Hechicero(IArma arma)
        {
            
            this.arma = arma;

        }

        public void Pelear()
        {
            this.arma.Dañar(Nombre);
        }
       


    }
}

