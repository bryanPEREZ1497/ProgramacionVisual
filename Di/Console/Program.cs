using System;
using Entidades;
using Interfaces;
using Negocio;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var persistencia = kernel.Get<IPersistencia>();
            
            IPersistencia persistencia = new Persistencia();
            Secretaria secretaria = new Secretaria(persistencia);
            Estudiante estudiante = new Estudiante("Bryan","Pérez");
            Curso curso = new Curso("Programación");

            secretaria.Matricular(estudiante,curso);  
            Console.
            ReadLine
        }
    }    
}
