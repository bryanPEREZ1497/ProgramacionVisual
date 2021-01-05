using System;
using System.Collections.Generic;

namespace Adt
{
    public class AdministradorNodos 
    {

      //List<string> Nodos = new List<string>();
      public void RecorrerArbol(Nodo Nodo)
      {
        if(Nodo==null) return;

        Console.WriteLine(Nodo.Nombre);
        RecorrerArbol(Nodo.Izquierdo);
        RecorrerArbol(Nodo.Derecho);
      }
    }
}
