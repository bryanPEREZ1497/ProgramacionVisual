using System;
using System.Collections.Generic;
using Librería;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplicación de matrices");
            /*Matriz matrizA = new Matriz();
            matrizA.Nombre="A";
            matrizA.Numeros=new double[2,3]{{1, 4, 2}, {2, 5, 1}};

            Matriz matrizB = new Matriz();
            matrizB.Nombre="B";
            matrizB.Numeros=new double[3,3]{{3, 4, 2}, {3, 5, 7}, {1, 2, 1}};

            Matriz matrizC = Matriz.Multiplicar(matrizA,matrizB);
            matrizC.Nombre = "Producto";*/
            
            /*Matriz matrizA = new Matriz();
            matrizA.Nombre="A";
            matrizA.Numeros=new double[1,3]{{1, 2, 3}};

            Matriz matrizB = new Matriz();
            matrizB.Nombre="B";
            matrizB.Numeros=new double[3,1]{{1}, {2}, {3}};
            
            Matriz matrizC = Matriz.Multiplicar(matrizA,matrizB);
            matrizC.Nombre = "Producto";
            
            var matrices = new List<Matriz>();
            matrices.Add(matrizA);
            matrices.Add(matrizB);
            matrices.Add(matrizC);

            foreach(Matriz matriz in matrices)
            {
              Console.WriteLine("Matriz {0}",matriz.Nombre);
              for (int i = 0; i < matriz.Numeros.GetLength(0); i++) 
              {
                for (int j = 0; j < matriz.Numeros.GetLength(1); j++) 
                {
                  Console.Write(matriz.Numeros[i, j] + " ");
                }
                Console.WriteLine();
              }

            }*/
            
            /*var sw = Stopwatch.StartNew();

            Program.ObtenerTamañoParalelo();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();
            sw.Restart();
            Program.ObtenerTamaño();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();*/
        

          Console.WriteLine("Matriz A: Filas");
          var AFilas=int.Parse(Console.ReadLine());
          Console.WriteLine();
          Console.WriteLine("Matriz A: Columnas");
          var AColumnas=int.Parse(Console.ReadLine());
          Console.WriteLine();
          Console.WriteLine("Matriz B: Filas");
          var BFilas=int.Parse(Console.ReadLine());
          Console.WriteLine();
          Console.WriteLine("Matriz B: Columnas");
          var BColumnas=int.Parse(Console.ReadLine());

          Matriz matrizA = new Matriz("A");
          matrizA.Numeros= new double[AFilas,AColumnas];

          Matriz matrizB = new Matriz("B");
          matrizB.Numeros= new double[BFilas,BColumnas];

          matrizA=Matriz.LlenarMatrizUsuario(matrizA);
          matrizB=Matriz.LlenarMatrizUsuario(matrizB);

          //var sw = Stopwatch.StartNew();
          
          Matriz matrizC = Matriz.Multiplicar(matrizA,matrizB);
          matrizC.Nombre = "Producto";

          var matrices = new List<Matriz>();
          matrices.Add(matrizA);
          matrices.Add(matrizB);
          matrices.Add(matrizC);

          Console.WriteLine();

          Matriz.Mostrar(matrices);
                    
          /*long tiempoTras = sw.ElapsedMiliseconds();
          sw1.StartNew();
          multiplicarMatricesParalelo
          long timepo2 = sw.ElapsedMiliseconds()
          Console.WriteLine(tiempo2)

          sw.Stop()
          sw1.Stop()*/
       }
        /*private static void ObtenerTamañoParalelo()
        {
            long totalSize = 0;
            string ruta = @"C:\Users\bryan.perez04\Documents";
            if (! Directory.Exists(ruta) ){
                Console.WriteLine("The directory does not exist.");
                return;
            }

            String[] files = Directory.GetFiles(ruta);
            Parallel.For(0, files.Length,
            index => 
            { FileInfo fi = new FileInfo(files[index]);
                long size = fi.Length;
                Interlocked.Add(ref totalSize, size);
            } );
            Console.WriteLine("Directory '{0}':", ruta);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }
        private static void ObtenerTamaño()
        {
            long totalSize = 0;
            string ruta = @"C:\Users\bryan.perez04\Documents";
            if (! Directory.Exists(ruta) ){
                Console.WriteLine("The directory does not exist.");
                return;
            }

            String[] files = Directory.GetFiles(ruta);
            for(int index=0; index<files.Length;index++)
            {
                FileInfo fi = new FileInfo(files[index]);
                long size = fi.Length;
                Interlocked.Add(ref totalSize, size);
            }
            Console.WriteLine("Directory '{0}':", ruta);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }*/

    }
}
