using System;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Thread hilo1 = new Thread(MetodoAEjecutar);     
          Thread hilo2 = new Thread(MetodoAEjecutar);     
          Console.WriteLine("Cultura de hilo principal es: {0}",Thread.CurrentThread.CurrentCulture)
          Console.WriteLine("Voy a ejecutar el hilo1");
          hilo1.start();//Aquí llama o ejecuta el metodo
          Console.WriteLine("Voy a ejecutar el hilo2");
          hilo2.start();//Aquí llama o ejecuta el metodo

          Thread.Sleep(1000);

          Console.WriteLine("el hilo1 se junta");
          hilo1.Join();
          Console.WriteLine("el hilo2 se junta");
          hilo2.Join();*/

          Thread corredor1 = new Thread(Carrera.Corredor);
          Thread corredor2 = new Thread(Carrera.Corredor);
          Thread corredor3 = new Thread(Carrera.Corredor);
          Thread corredor4 = new Thread(Carrera.Corredor);
          corredor1.Start("Bryan");
          corredor2.Start("Andres");
          corredor3.Start("Ana");
          corredor4.Start("Joss");
          corredor1.Join();
          corredor2.Join();
          corredor3.Join();
          corredor4.Join();
        }
        static void MetodoAEjecutar()
        {
            var hiloActual = Thread.CurrentThread;
            //hiloActual.CurrentThread=
            Console.WriteLine("Hilo actual {0}: ",hiloActual.ManagedThreadId;
            Console.WriteLine("Cultura {0}: ",hiloActual.CurrentCulture;
            var random = new Random();
            for(int i = 0; i<10; i++)
            {
              Console.WriteLine("hilo {0} indice {1}",hiloActual.ManagedThreadId,i);
              Thread.Sleep(random.Next(100,500));

            }

        }
    }

    class Carrera 
    {
        static void Corredor(object obj)
        {
          var nombre = (string) obj;
          var hiloActual = Thread.CurrentThread;
          var pasos=0;
          var random = new Random();
          while(pasos<1000)
          {
            pasos += random.Next(0,4);
            Console.WriteLine("Corredor {0} dio {1} pasos",nombre,pasos);
            Thread.Sleep(10);
          }
          Console.WriteLine("El corredor {0} llegó a la meta",nombre);
        }
    }
}
