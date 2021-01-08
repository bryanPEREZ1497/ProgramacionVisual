using System;

namespace Adt 
{
    public class CalculadoraArbol
    {
        public double Calcular(string expresionMatematica)
        {
            var raiz = new Nodo();

            CrearArbol(raiz, expresionMatematica);

            return Evaluar(raiz);
        }

        private double Evaluar(Nodo nodo)
        {
            // Toda funcion recursiva debe pernsar en 3 cosas:
            // 1) Que debo hacer cuando el nodo actual es la raiz

            // 2) Que debo hacer cuando el nodo actual es una hoja
            if (EsNumero(nodo.Nombre)) // Puede ser operador o numero
            {
                return ConvertirEnNumero(nodo.Nombre);
            }

            // 3) Que debo hacer cuando el nodo actual no es hoja ni raíz

            var izquierdo = Evaluar(nodo.Izquierdo);
            var derecho = Evaluar(nodo.Derecho);

            if (nodo.Nombre == "+")
            {
                return izquierdo + derecho;
            }
            else
            {
                throw new ArgumentException("Operador Invalido");
            }
        }

        private double ConvertirEnNumero(string nombre)
        {
            return Double.Parse(nombre);
        }

        private bool EsNumero(string valor)
        {            
            return valor=="+" || valor=="-"  ? false : true;
        }

        private void CrearArbol(Nodo nodo, string expresionMatematica)
        {
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

        private int BuscarOperador(string expresionMatematica)
        {
            var indiceMas = expresionMatematica.IndexOf('+');
            var indiceMenos = expresionMatematica.IndexOf('-');

            return indiceMas < indiceMenos ? indiceMas : indiceMenos;
        }
    }
}
