using System;

namespace Juego
{
    class Espada : IArma
    {
        public void Dañar(string personaje)
        {
            Console.WriteLine("{0} corta carne",personaje);
        }        
    }
}
