using System;

namespace Juego
{
    class Lucha 
    {
        IPersonaje personaje1;
        IPersonaje personaje2;

        public Lucha(IPersonaje p1, IPersonaje p2)
        {
            personaje1=p1;
            personaje2=p2;
        }

        public void Ganador()
        {            
            var aleatorio = new Random().Next(0,1);
            if (aleatorio ==0)
            {
                Console.WriteLine("Gana "+personaje1.Nombre);
                return;
            }
            Console.WriteLine("Gana "+personaje2.Nombre);            
        }       
              
    }
}
