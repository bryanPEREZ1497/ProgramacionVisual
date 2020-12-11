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
        public double Sumar(double sumando1, double sumando2)
        {
            return sumando1 + sumando2;
        }
        public double Restar(double minuendo, double sustraendo )
        {
            return minuendo-sustraendo;
        }

        public double Multiplicar(double factor1, double factor2)
        {
            return factor1*factor2;
        }

        public double Dividir(double dividendo, double divisor)
        {            
            if (divisor!=0)
            {
                return dividendo / divisor;
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
