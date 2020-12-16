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
                Console.WriteLine("¿La operación tiene números complejos? Sí[S],No[N]");
                var respuesta = Console.ReadKey().Key;
                switch(respuesta)
                {
                  case ConsoleKey.N:
                    try
                    {
                      Console.WriteLine("Primer numero");
                      int numero1 = int.Parse(Console.ReadLine());
                      Console.WriteLine("Segundo numero");
                      int numero2 = int.Parse(Console.ReadLine());
                      Console.WriteLine("Escoja el operador");
                      string operador = Console.ReadLine();
                    }
                    catch(NoInputButEnter e)
                    {
                      Console.WriteLine(e.Message);
                    }
                    
                    var calculadora = new Calculadora();
                    var resultado = calculadora.Definir(numero1, numero2, operador);
                    Console.WriteLine("Resultado: " + resultado);

                    break;
                  
                  case ConsoleKey.S:
                    Console.WriteLine("Primer Complejo, parte real");
                    Complejo complejo1; 
                    double complejo1Real=int.Parse(Console.ReadLine());
                    Console.WriteLine("Primer Complejo, parte imaginaria");
                    double complejo1Imaginaria=int.Parse(Console.ReadLine());
                    complejo1 = new Complejo(complejo1Real,complejo1Imaginaria);
                    Console.WriteLine("Segundo Complejo, parte real");
                    Complejo complejo2; 
                    double complejo2Real=int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo Complejo, parte imaginaria");
                    double complejo2Imaginaria=int.Parse(Console.ReadLine());
                    complejo2 = new Complejo(complejo2Real,complejo2Imaginaria);
                    Console.WriteLine("Escoja el operador");
                    string operador2 = Console.ReadLine();

                    var calculadora2 = new Calculadora();
                    var resultado2 = calculadora2.Definir(complejo1,complejo2,operador2);
                    Console.WriteLine("Resultado: "+resultado2.Real+" "+resultado2.Imaginaria+"i");

                    break;
                  default:
                    break;
                }
              }while(Console.ReadKey().Key!=ConsoleKey.Escape);
        }
    }
}
