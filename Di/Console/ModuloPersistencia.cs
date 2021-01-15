using System;
using Entidades;
using Interfaces;
using Negocio;
using DatosOtro;

namespace Console
{    
    class ModuloPersistencia : NinjectMOdule
    {
        public override void Load()
        {
            this.Bind<>(IPersistencia).To<Persistencia2>()
        }
    }
}
