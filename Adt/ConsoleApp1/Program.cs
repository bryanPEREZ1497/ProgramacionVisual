using System;
using Adt;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recorrido de árboles binarios");
            
            var Nodo3 = new Nodo();
            Nodo3.Nombre = "1.1.1";
            
            var Nodo4 = new Nodo();
            Nodo4.Nombre = "1.1.2";
            
            var Nodo5 = new Nodo();
            Nodo5.Nombre = "1.2.1";
            
            var Nodo6 = new Nodo();
            Nodo6.Nombre = "1.2.2";
            
            var Nodo1 = new Nodo();
            Nodo1.Nombre = "1.1";
            Nodo1.Izquierdo = Nodo3;
            Nodo1.Derecho = Nodo4;
            
            var Nodo2 = new Nodo();
            Nodo2.Nombre = "1.2";
            Nodo2.Izquierdo = Nodo5;
            Nodo2.Derecho = Nodo6;

            var raiz = new Nodo();
            raiz.Nombre = "1";
            raiz.Izquierdo=Nodo1;
            raiz.Derecho=Nodo2;

            AdministradorNodos an = new AdministradorNodos();
            an.RecorrerArbol(raiz);
        }
    }
}
