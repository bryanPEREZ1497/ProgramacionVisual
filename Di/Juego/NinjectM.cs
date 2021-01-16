using System;
using Ninject;
using Ninject.Modules;

namespace Juego
{
    class NinjectM : NinjectModule 
    {
        public override void Load()
        {
            //this.Bind<IArma>().To<Espada>();
            //this.Bind<IArma>().To<Varita>();
        }        
              
    }
}
