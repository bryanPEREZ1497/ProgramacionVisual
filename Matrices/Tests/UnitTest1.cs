using Microsoft.VisualStudio.TestTools.UnitTesting;
using Librería;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Matriz matrizA = new Matriz();
            matrizA.Nombre="A";
            matrizA.Numeros=new double[1,3]{{1, 2, 3}};

            Matriz matrizB = new Matriz();
            matrizB.Nombre="B";
            matrizB.Numeros=new double[3,1]{{1}, {2}, {3}};
            
            Matriz resultadoEsperado = new Matriz();
            resultadoEsperado.Numeros=new double[1,1]{{14}};

            Matriz resultado = Matriz.Multiplicar(matrizA,matrizB);

            Assert.AreEqual(resultadoEsperado, resultado);

        }
    }
}
