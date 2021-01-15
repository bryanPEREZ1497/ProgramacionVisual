using System;
using System.IO;
using System.Collections.Generic;
using Entidades;
using IPersistencia;

namespace PersistenciaBryan 
{
    class Persistencia:IPersistencia 
    {

        public bool Grabar(Estudiante estudiante)
        {
          
          File.AppendAllLines("Estudiante.txt",new List<string>{estudiante.ToString()});
          return true;
        }

        public bool Grabar(Curso curso)
        {
          
          File.AppendAllLines("Curso.txt",new List<string>{curso.ToString()});
          return true;
        }

        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
          File.AppendAllLines("EstudiantePorCurso.txt",new List<string>{estudiantePorCurso.ToString()});
          return true;
        }
    }
}
