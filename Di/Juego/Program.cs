using System;
using Ninject;

namespace Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Juego de lucha");

            /*
            //Inyección de dependencias manual
            var guerrero = new Guerrero(new Espada());
            guerrero.Nombre="Guerrero";
            guerrero.Pelear();
            var hechicero = new Hechicero(new Varita());
            hechicero.Nombre="Hechicero";
            hechicero.Pelear(); 
            var combate = new Lucha(guerrero,hechicero);
            combate.Ganador();
            */

            //Inyección de dependencias con Ninject
            var kernel = new StandardKernel();
            kernel.Bind<IArma>().To<Espada>();
            var guerrero = kernel.Get<Guerrero>();
            guerrero.Nombre = "Guerrero";
            guerrero.Pelear();

            var kernel2 = new StandardKernel();
            kernel2.Bind<IArma>().To<Varita>();
            var hechicero = kernel2.Get<Hechicero>();
            hechicero.Nombre = "Hechicero";
            hechicero.Pelear();

            var combate = new Lucha(guerrero, hechicero);
            combate.Ganador();
        }
    }
}
