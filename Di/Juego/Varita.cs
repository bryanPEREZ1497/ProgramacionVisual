using System;

namespace Juego
{
    class Varita : IArma
    {
        public void Dañar(string personaje)
        {
            Console.WriteLine("{0} conjurar el encantamiento abadaquedabra",personaje);
        }        

    }
}
