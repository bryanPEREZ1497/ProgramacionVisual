using System;
using System.IO;
using System.Collections.Generic;
using Entidades;

namespace Interfaces 
{
    public interface IPersistencia 
    {

        public bool Grabar(Estudiante estudiante);

        public bool Grabar(Curso curso);

        public bool Grabar(EstudiantePorCurso estudiantePorCurso);

    }
}

