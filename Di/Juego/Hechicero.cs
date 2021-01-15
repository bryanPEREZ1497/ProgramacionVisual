using System;

namespace Juego
{
    class Hechicero
    {
        readonly IArma arma;

        public Hechicero(IArma arma)
        {
            if (arma == null) throw new ArgumentNullException("arma");
            this.arma = arma;

        }

        public void Pelear()
        {
            this.arma.Dañar();
        }


    }
}

