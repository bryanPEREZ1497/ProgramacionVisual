using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Librería;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            Program.ObtenerTamañoParalelo();
            Console.WriteLine("Tiempo del proceso paralelo: "+sw.ElapsedMilliseconds);
            sw.Stop();
            sw.Restart();
            Program.ObtenerTamaño();
            Console.WriteLine("Tiempo del proceso: "+sw.ElapsedMilliseconds);
            sw.Stop();


            /*Console.WriteLine("Multiplicación de matrices");
            Console.WriteLine();
            Console.WriteLine("Llene la matriz:");


            Console.WriteLine("Matriz A: Filas");
            var AFilas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Matriz A: Columnas");
            var AColumnas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Matriz B: Filas");
            var BFilas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Matriz B: Columnas");
            var BColumnas = int.Parse(Console.ReadLine());

            Matriz matrizA = new Matriz("A");
            matrizA.Numeros = new double[AFilas, AColumnas];

            Matriz matrizB = new Matriz("B");
            matrizB.Numeros = new double[BFilas, BColumnas];

            matrizA = Matriz.LlenarMatrizUsuario(matrizA);
            matrizB = Matriz.LlenarMatrizUsuario(matrizB);

            var sw = Stopwatch.StartNew();

            Matriz matrizC = Matriz.Multiplicar(matrizA, matrizB);
            matrizC.Nombre = "Matriz C";
            long tiempoTranscurrido = sw.ElapsedMilliseconds;
            Console.WriteLine("El tiempo transcurrido al procesar Multiplicar es :{0}", tiempoTranscurrido);

            var sw1 = Stopwatch.StartNew();

            Matriz matrizD = Matriz.Multiplicar(matrizA, matrizB);
            matrizD.Nombre = "Matriz D";
            long tiempo2 = sw1.ElapsedMilliseconds;
            Console.WriteLine("El tiempo transcurrido al procesar MultiplicarParalelamente es :{0}", tiempo2);

            sw.Stop();
            sw1.Stop();

            var matrices = new List<Matriz>();
            matrices.Add(matrizA);
            matrices.Add(matrizB);
            matrices.Add(matrizC);

            Console.WriteLine();

            Matriz.Mostrar(matrices);*/
        }

        private static void ObtenerTamañoParalelo()
        {
            long totalSize = 0;
            string ruta = @"C:\Users\bryan.perez04\Documents";
            if (!Directory.Exists(ruta))
            {
                Console.WriteLine("El directorio no existe");
                return;
            }

            String[] files = Directory.GetFiles(ruta);
            Parallel.For(0, files.Length,
            index =>
            {
                FileInfo fi = new FileInfo(files[index]);
                long size = fi.Length;
                Interlocked.Add(ref totalSize, size);
            });
            Console.WriteLine("Directory '{0}':", ruta);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }

        private static void ObtenerTamaño()
        {
            long totalSize = 0;
            string ruta = @"C:\Users\bryan.perez04\Documents";
            if (!Directory.Exists(ruta))
            {
                Console.WriteLine("The directory does not exist.");
                return;
            }

            String[] files = Directory.GetFiles(ruta);
            for (int index = 0; index < files.Length; index++)
            {
                FileInfo fi = new FileInfo(files[index]);
                long size = fi.Length;
                Interlocked.Add(ref totalSize, size);
            }
            Console.WriteLine("Directory '{0}':", ruta);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }

    }
}
