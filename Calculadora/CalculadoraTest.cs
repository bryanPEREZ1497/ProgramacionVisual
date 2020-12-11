using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Negocio;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SumaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 3.1;
            var esperado = 21.1;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Sumar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void RestaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 2;
            var esperado = 16;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Restar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void MultiplicacionDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 2;
            var esperado = 36;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Multiplicar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void DivisionDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 6;
            var esperado = 3;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Dividir(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void SumarComplejos()
        {
            var complejo1 = new Complejo(3,2);
            var complejo2 = new Complejo(1.5,6);
            var esperado= new Complejo(4.5,8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Sumar(complejo1, complejo2);

            Assert.AreEqual(esperado,resultado);
        }
    }
}
