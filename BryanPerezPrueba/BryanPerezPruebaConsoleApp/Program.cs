using System;
using System.Threading;

namespace BryanPerezPruebaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            #departamentos en el edificio=12*8=96,

            #1-6 personas en cada depar=x,

            #personas en el edificio=96*x

            */

            Thread hilo1 = new Thread(ContarNumeroDePersonas);
            Thread hilo2 = new Thread(ContarNumeroDePersonas);

            Console.WriteLine("Voy a ejecutar el hilo1");
            hilo1.Start();

            Console.WriteLine("Voy a ejecutar el hilo2");
            hilo2.Start();

            Thread.Sleep(1000);

            Console.WriteLine("el hilo1 se junta");
            hilo1.Join();
            Console.WriteLine("el hilo2 se junta");
            hilo2.Join();
        }

        static void ContarNumeroDePersonas()
        {

            var hiloActual = Thread.CurrentThread;

            Console.WriteLine("Hilo actual {0}: ", hiloActual.ManagedThreadId);


            int total = 0;
            for (int i = 1; i <= 96; i++)
            {
                var personas = new Random().Next(1, 6);
                Console.WriteLine("Hilo {0} Departamento {1} Personas {2}", hiloActual.ManagedThreadId, i, personas);
                total += personas;

                Thread.Sleep(200);
            }
            Console.WriteLine("Número de personas en el edificio: " + total);

        }
    }
}
