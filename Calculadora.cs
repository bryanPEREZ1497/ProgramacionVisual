using System;

namespace Matematica.Negocio
{
    public class Calculadora
    {
        public double Definir(double a, double b, string operador)
        {
            switch (operador)
            {
                case "+":
                    return this.Sumar(a, b);
                case "-":
                    return this.Restar(a, b);
                    
                case "*":
                    return this.Multiplicar(a, b);
                    
                case "/":
                    return this.Dividir(a, b);
                    
                default:
                    return 0;
            }
        } 
        public double Sumar(double a, double b)
        {
            return a + b;
        }
        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {            
            if (b!=0)
            {
                return a / b;
            }
            
            return 0;
        }
        public double Raiz(double a)
        {
            if (a>=0)
            {
                return Math.Sqrt(a);
            }
            return 0;
        }
        public double AlCuadrado(double a)
        {
            return Math.Pow(a,2);
        }

        /*public Complejo Sumar(Complejo a, Complejo b) 
        {
            var real = a.Real + b.Real;
            var imaginaria = a.Imaginaria + b.Imaginaria;
            return new Complejo(real, imaginaria);
        }*/
    }
}
