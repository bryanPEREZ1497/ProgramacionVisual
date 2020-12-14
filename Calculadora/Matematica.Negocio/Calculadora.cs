using System;
using System.Reflection;

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
        public Complejo Definir(Complejo a, Complejo b, string operador)
        {
            switch (operador)
            {
                case "+":
                    return this.Sumar(a, b);
                case "-":
                    return this.Restar(a, b);
                    
                case "*":
                    return this.Multiplicar(a, b);
                    
                /*case "/":
                    return this.Dividir(a, b);
                 */   
                default:
                    return this.Sumar(a,b);
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
            if (b==0)
            {
                throw new System.ArgumentException();
            }
            
            return a/b;
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

        public Complejo Sumar(Complejo a, Complejo b) 
        {
            var real = a.Real + b.Real;
            var imaginaria = a.Imaginaria + b.Imaginaria;
            return new Complejo(real, imaginaria);
        }

        public Complejo Restar(Complejo a, Complejo b) 
        {
            var real = a.Real - b.Real;
            var imaginaria = a.Imaginaria - b.Imaginaria;
            return new Complejo(real, imaginaria);
        }

        public Complejo Multiplicar(Complejo a, Complejo b) 
        {
          double real;
          double imaginaria;
          double[] numeros = new double[4];
          double factor;
          int contador = 0;
          PropertyInfo[] PropertiesA = a.GetType().GetProperties();
          PropertyInfo[] PropertiesB = b.GetType().GetProperties();
          foreach(var numeroA in PropertiesA)
          {
            foreach(var numeroB in PropertiesB)
            {
              factor = (double)numeroA.GetValue(a,null)* (double)numeroB.GetValue(b, null);
              numeros[contador]=factor;
              contador++;
            }
          }
          real = numeros[0]-numeros[3];
          imaginaria = numeros[1]+numeros[2];
          return new Complejo(real,imaginaria);
        }
        
        public Complejo multiplicarConEscalar(double escalar, Complejo complejo)
        {
            var parteReal = escalar * complejo.Real;
            var parteImaginaria = escalar * complejo.Imaginaria;

            return new Complejo(parteReal, parteImaginaria);
        }
    }
}
