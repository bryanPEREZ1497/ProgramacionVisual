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

            /*var guerrero = new Guerrero("Guerrero", new Espada());
            guerrero.Pelear();
            var hechicero = new Hechicero("Hechicero", new Varita());
            hechicero.Pelear();*/            

            IKernel kernel = new StandardKernel();
            var guerrero = kernel.Get<Guerrero>();
            kernel.Bind<IArma>().To<IArma>();
            guerrero.Pelear();
            

        }
    }
}
