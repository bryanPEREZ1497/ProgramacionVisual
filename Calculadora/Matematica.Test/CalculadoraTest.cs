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
        //Operaciones con complejos
        [TestMethod]
        public void SumarComplejos()
        {
            Complejo complejo1 = new Complejo(3, 2);
            Complejo complejo2 = new Complejo(1.5, 6);
            Complejo esperado = new Complejo(4.5, 8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Sumar(complejo1, complejo2);

            //Assert.AreEqual(esperado.Real, resultado.Real);
            Assert.IsTrue(esperado.Equals(resultado));
        }
        /*public void TruncarNumeros()
        {
            var numeroIngresado = 1.222222;
            var numeroEsperado = 1.22;

            var calculadora = new Calculadora();
            var resultado = calculadora.Truncar(numeroIngresado);

            Assert.AreEqual(numeroEsperado, resultado);

        }*/
        [TestMethod]
        //[ExpectedException(typeof(System.ArgumentException))]
        public void DividirPorCero()
        {
            
            var dividendo = 5;
            var divisor = 0;

            var calculadora = new Calculadora() ;
            _ = calculadora.Dividir(dividendo, divisor);
            Assert.ThrowsException<System.ArgumentException>(() => calculadora.Dividir(dividendo,divisor));
        }
        [TestMethod]
        public void DivisionDosNumeros()
        {
            var numero1 = 10;
            var numero2 = 1;
            var esperado = 10;

            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(numero1, numero2);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void MultiplicarComplejos()
        {
          Complejo complejo1 = new Complejo(-3,-5);
          Complejo complejo2 = new Complejo(7,-9);
          Complejo esperado = new Complejo(-66, -8);
        
          var miCalculadora = new Calculadora();
          var resultado = miCalculadora.Multiplicar(complejo1, complejo2);

          Assert.AreEqual(esperado.Real, resultado.Real);

        }
        [TestMethod]
        public void multiplicacionPorescalar()
        {
            var escalar = 2;
            var complejo = new Complejo(4, 6);
            var resultadoEsperado = new Complejo(8, 12);

            var micalculadora = new Calculadora();
            var resultadoObtenido = micalculadora.multiplicarConEscalar(escalar, complejo);

            Assert.AreEqual(resultadoEsperado.Real, resultadoObtenido.Real);

            Assert.AreEqual(resultadoEsperado.Imaginaria, resultadoObtenido.Imaginaria);

        }
            }
}
