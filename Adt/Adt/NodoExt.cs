using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adt
{
    public class NodoExt
    {

        public NodoExt(string nombre)
        {
          Nombre = nombre;
        }
        public object Contenido { get; set; }

        public string Nombre {get;set;}

        public List<NodoExt> Hijos { get; set; }
        
        public static int ContarNodos(NodoExt nodo)
        {
            if (nodo == null)
                return 0;
            
            if (nodo.Hijos == null) 
                return 1;

            int nietos = 0;

            for (int i=0; i < nodo.Hijos.Count(); i++)
            {
                nietos += ContarNodos(nodo.Hijos[i]);
            }
            return nietos+1;
        }

        public static int ContarHojas(NodoExt nodo)
        {
            if (nodo == null)
                return 0;

            int hojas = 0;
            
            if (nodo.Hijos == null) 
                return 1;

            for (int i=0; i < nodo.Hijos.Count(); i++)
            {
                hojas += ContarHojas(nodo.Hijos[i]);
            }
            return hojas;
        }

    
        public static int ContarNiveles(NodoExt nodo)
        {
            if (nodo.Hijos.Count() == 0)
                return 0;

            int niveles = 0;
            for (int iterador = 0; iterador < nodo.Hijos.Count(); iterador++)
            {
                if (nodo.Hijos.Count()>0)
                {
                    niveles = ContarHojas(nodo.Hijos[iterador]);
                    niveles++;
                }
            }
            return niveles;
        }
    }
}
