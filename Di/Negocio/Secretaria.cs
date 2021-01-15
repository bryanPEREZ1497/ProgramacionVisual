using System;
using Entidades;
using Interfaces;

namespace Negocio 
{

    class Secretaria
    { 
        public IPersistencia Persistencia {get;set;}
        public Secretaria(IPersistencia persistencia)
        {
            Persistencia = persistencia;
        }
        
        public string Matricular(Estudiante estudiante, Curso curso)
        {
            Persistencia.Grabar(estudiante);
            Persistencia.Grabar(curso);
            Persistencia.Grabar(new EstudiantePorCurso{
                EstudianteId=estudiante.Id,
                CursoId=curso.Id
                });

            return string.Format("El estudiante {0} {1} se matriculó en el curso {3}", 
                estudiante.Nombre,
                estudiante.Apellido, 
                curso.Nombre
                );    
        }
    }
}
