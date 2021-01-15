using System;
using System.IO;
using System.Collections.Generic;
using Interfaces;
using Entidades;

namespace DatosOtro
{

    class Persistencia2:IPersistencia 
    {

        public bool Grabar(Estudiante estudiante)
        {
          //TODO
          File.AppendAllLines("Estudiante.txt", new List<string>{estudiante.Nombre});
          return true;
        }

        public bool Grabar(Curso curso)
        {
          //TODO
          File.AppendAllLines("Curso.txt",new List<string>{curso.Nombre});
          return true;
        }

        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
          File.AppendAllLines("EstudiantePorCurso.txt",new List<string>{estudiantePorCurso.CursoId.ToString()});
          return true;
        }
    }
}
