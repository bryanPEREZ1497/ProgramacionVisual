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

                case "raiz":                    
                    return this.Raiz(a,b);

                case "^":
                    return this.Potencia(a, b);

                default:
                    throw new ArgumentException("Operador inválido");
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
                    throw new ArgumentException("Operador inválido");
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
            if (b == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero");
            }

            return a / b;
        }
        public double Raiz(double a, double b)
        {
            if (a >= 0)
            {
                //return Math.Sqrt(a);
                return Math.Pow(a, 1 / b);
            }
            throw new ArgumentException("La cantidad subradical no puede ser menor a cero");
        }
        public double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
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
            foreach (var numeroA in PropertiesA)
            {
                foreach (var numeroB in PropertiesB)
                {
                    factor = (double)numeroA.GetValue(a, null) * (double)numeroB.GetValue(b, null);
                    numeros[contador] = factor;
                    contador++;
                }
            }
            real = numeros[0] - numeros[3];
            imaginaria = numeros[1] + numeros[2];
            return new Complejo(real, imaginaria);
        }

        public Complejo MultiplicarConEscalar(double escalar, Complejo complejo)
        {
            var parteReal = escalar * complejo.Real;
            var parteImaginaria = escalar * complejo.Imaginaria;

            return new Complejo(parteReal, parteImaginaria);
        }


        /*public String [] DividirComplejos(Complejo primerComplejo, Complejo segundoComplejo)
        {
            string[] resultados = new string[2];

            var dividendoParteReal = (primerComplejo.getX() * segundoComplejo.getX()) - (primerComplejo.getY() * (segundoComplejo.getY()*-1));
            var dividendoParteImaginaria = (primerComplejo.getX() * (segundoComplejo.getY()*-1)) + (primerComplejo.getY() * segundoComplejo.getX());

            var divisorParteReal = (segundoComplejo.getX() * segundoComplejo.getX());
            var divisorParteImaginaria = (-1)*((-1)*(segundoComplejo.getY() * segundoComplejo.getY()));

            var divisorTotal = divisorParteReal + divisorParteImaginaria;

            resultados[0] = dividendoParteReal.ToString() + "/" + divisorTotal.ToString();
            resultados[1] = dividendoParteImaginaria.ToString() + "/" + divisorTotal.ToString();

            return resultados;
        }*/
    }
}
