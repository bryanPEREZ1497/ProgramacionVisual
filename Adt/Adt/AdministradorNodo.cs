using System;
using System.Collections.Generic;

namespace Adt
{
    public class AdministradorNodos 
    {
      public void RecorrerArbol(Nodo Nodo)
      {
        if(Nodo==null) return;

        Console.WriteLine(Nodo.Nombre);
        RecorrerArbol(Nodo.Izquierdo);
        RecorrerArbol(Nodo.Derecho);
      }
      public void NavegarHorizontalmente(Nodo nodo)
        {
            if(nodo == null)return;
            List<Nodo> cola = new List<Nodo>();
            cola.Add(nodo);
            while(cola.Count!=0)
            {
              Nodo cabeza = cola[0];
              Console.WriteLine(cola[0].Nombre);
              if(cola[0].Izquierdo!=null)cola.Add(cabeza.Izquierdo);
              if(cola[0].Derecho!=null)cola.Add(cabeza.Derecho);
              cola.RemoveAt(0);
            }
        }
    }
}
