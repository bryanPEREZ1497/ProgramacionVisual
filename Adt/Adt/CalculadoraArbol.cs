using System;

namespace Adt
{
    public class CalculadoraArbol
    {
        public double Calcular(string expresionMatematica)
        {
            var raiz = new Nodo();

            CrearArbol(raiz, expresionMatematica);

            return Sumar(raiz);
        }

        public double Sumar(Nodo nodo)
        {
            double total=0;
            if (nodo.Izquierdo == null && nodo.Derecho == null)
            {   
                return double.Parse(nodo.Nombre);
            }
            total+=Sumar(nodo.Izquierdo);
            total+=Sumar(nodo.Derecho);
            return total;            
        }

        public void CrearArbol(Nodo nodo, string expresionMatematica)
        {
            //22
            if (BuscarOperador(expresionMatematica) == -1)
            {
                nodo.Nombre = expresionMatematica;
                return;
            }
            //22+2
            var indiceOperador = BuscarOperador(expresionMatematica);//[2] = +

            var operandoIzquierdo = expresionMatematica.Substring(0, indiceOperador);

            nodo.Nombre = expresionMatematica[indiceOperador].ToString();
            nodo.Izquierdo = new Nodo(operandoIzquierdo);

            nodo.Derecho = new Nodo();

            CrearArbol(nodo.Derecho, expresionMatematica.Substring(indiceOperador + 1));

        }

        public int BuscarOperador(string expresionMatematica)
        {
            var indiceMas = expresionMatematica.IndexOf('+');
            if (indiceMas != -1)
            {
                return indiceMas;

            }
            var indiceMenos = expresionMatematica.IndexOf('-');
            if (indiceMenos != -1)
            {
                return indiceMenos;

            }

            return -1;
        }



        /*public double Sumar(Nodo nodo)
        {
            
            // Toda funcion recursiva debe pernsar en 3 cosas:
            // 1) Que debo hacer cuando el nodo actual es la raiz

            // 2) Que debo hacer cuando el nodo actual es una hoja
            if (EsNumero(nodo.Nombre)) // Puede ser operador o numero
            {
                return ConvertirEnNumero(nodo.Nombre);
            }

            // 3) Que debo hacer cuando el nodo actual no es hoja ni raíz

            var izquierdo = Sumar(nodo.Izquierdo);
            var derecho = Sumar(nodo.Derecho);

            if (nodo.Nombre == "+")
            {
                return izquierdo + derecho;
            }
            else
            {
                throw new ArgumentException("Operador Invalido");
            }
        }
        

        public double ConvertirEnNumero(string nombre)
        {
            return Double.Parse(nombre);
        }

        public bool EsNumero(string valor)
        {
            return valor == "+" || valor == "-" ? false : true;
        }
        

        
        public void CrearArbol(Nodo nodo, string expresionMatematica)
        {   
            if (expresionMatematica.Length==1)
            {
                nodo.Nombre= expresionMatematica.Substring(0,1);
                return;
            }
            var indiceOperador = (int) BuscarOperador(expresionMatematica);
            if(indiceOperador==-1)
            {
              nodo.Nombre=expresionMatematica;
              return;
            }
            string operandoIzquierdo = expresionMatematica.Substring(0, indiceOperador);

            nodo.Nombre = expresionMatematica[indiceOperador].ToString();
            nodo.Izquierdo = new Nodo(operandoIzquierdo);
            
            nodo.Derecho = new Nodo();
            CrearArbol(nodo.Derecho, expresionMatematica.Substring(indiceOperador+1));
        }

        public int BuscarOperador(string expresionMatematica)
        {
            var indiceMas = expresionMatematica.IndexOf('+');
            var indiceMenos = expresionMatematica.IndexOf('-');

            return indiceMas < indiceMenos ? indiceMas : indiceMenos;
        }
        */
    }
}
