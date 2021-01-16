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

            /*var guerrero = new Guerrero(new Espada());
            guerrero.Nombre="Guerrero";
            guerrero.Pelear();
            var hechicero = new Hechicero(new Varita());
            hechicero.Nombre="Hechicero";
            hechicero.Pelear(); 
            var combate = new Lucha(guerrero,hechicero);
            combate.Ganador();*/

            var nm = new NinjectM();
            nm.Load();         

            var kernel = new StandardKernel(nm);
            //var kernel = new StandardKernel();

            var guerrero = kernel.Get<Guerrero>();
            kernel.Bind<IArma>().To<Espada>();
            guerrero.Pelear();    
            

        }
    }
}
