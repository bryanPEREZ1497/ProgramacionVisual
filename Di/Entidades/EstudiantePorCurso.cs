using System;

namespace Entidades 
{
    public class EstudiantePorCurso
    {
        public EstudiantePorCurso(int estudianteId, int cursoId)
        {
            EstudianteId=estudianteId;
            CursoId=cursoId;
            Id = new Random().Next();
        }

        public int EstudianteId { get; set; }
        public int CursoId { get; set; }
        public int Id { get; set; } = new Random().Next();
    }
}
