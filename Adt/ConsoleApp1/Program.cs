using System;
using Adt;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estructuras de datos: Árboles");
            //Árbol binario
            Console.WriteLine("Navegación horizontal de árbol binario");
            var raiz = new Nodo("1",
                new Nodo("1.1",
                  new Nodo("1.1.1"), new Nodo("1.1.2")),
                new Nodo("1.2",
                  new Nodo("1.2.1"), new Nodo("1.2.2"))
                );
            AdministradorNodos ad = new AdministradorNodos();
            ad.NavegarHorizontalmente(raiz);

            //Árbol con  múltiples hijos
            NodoExt nodo1 = new NodoExt("1");
            nodo1.Hijos = new List<NodoExt>();
            nodo1.Hijos.Add(new NodoExt("1.1"));
            nodo1.Hijos.Add(new NodoExt("1.2"));
            nodo1.Hijos[0].Hijos = new List<NodoExt>();
            nodo1.Hijos[0].Hijos.Add(new NodoExt("1.1.2"));

            //Niveles, hojas, y nodos
            Console.WriteLine("Niveles, hojas y nodos de árbol con múltiples hijos");
            Console.WriteLine("Niveles: {0}", NodoExt.ContarNiveles(nodo1));
            Console.WriteLine("Hojas: {0}", NodoExt.ContarHojas(nodo1));
            Console.WriteLine("Nodos: {0}", NodoExt.ContarNodos(nodo1));

            //Suma
            Console.WriteLine("Escriba la operación");
            var expresion = Console.ReadLine();
            var calculadora = new CalculadoraArbol();
            Console.WriteLine("Resultado: "+calculadora.Calcular(expresion));


        }
    }
}
