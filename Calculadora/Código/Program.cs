using System;
using Matematica.Negocio;
namespace Matematica.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Primer número");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Segundo úumero");
                int numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escoja el operador");
                string operador = Console.ReadLine();

                var calculadora = new Calculadora();
                var resultado = calculadora.Definir(numero1, numero2, operador);
                Console.WriteLine("Resultado: " + resultado);
            } while (Console.ReadKey().Key!=ConsoleKey.Escape);
        }
    }
}
