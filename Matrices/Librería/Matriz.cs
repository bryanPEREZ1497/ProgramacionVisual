using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Librería
{
    public class Matriz
    {
        public Matriz()
        { }

        public Matriz(string nombre)
        {
            Nombre = nombre;
        }

        public double[,] Numeros { get; set; }

        public string Nombre { get; set; }

        public static Matriz Multiplicar(Matriz matrizA, Matriz matrizB)
        {
            int filasMatrizA = matrizA.Numeros.GetLength(0);
            int columnasMatrizB = matrizB.Numeros.GetLength(1);

            Matriz matrizProducto = new Matriz();
            matrizProducto.Numeros = new double[filasMatrizA, columnasMatrizB];

            for (int i = 0; i < filasMatrizA; i++)
            {
                for (int j = 0; j < columnasMatrizB; j++)
                {
                    for (int k = 0; k < matrizA.Numeros.GetLength(1); k++)
                    {
                        matrizProducto.Numeros[i, j] += matrizA.Numeros[i, k] * matrizB.Numeros[k, j];
                    }
                }
            }

            return matrizProducto;
        }

        private static Matriz MutiplicarParalelamente(Matriz matrizA, Matriz matrizB)
        {
            int filasMatrizA = matrizA.Numeros.GetLength(0);
            int columnasMatrizA = matrizA.Numeros.GetLength(1);
            int columnasMatrizB = matrizB.Numeros.GetLength(1);

            Matriz matrizC = new Matriz();
            matrizC.Numeros = new double[filasMatrizA, columnasMatrizA];

            Parallel.For(0, filasMatrizA, i =>
            {
                Parallel.For(0, columnasMatrizB, j =>
                {
                    matrizC.Numeros[i, j] = 0;
                    for (int k = 0; k < filasMatrizA; k++)
                    {
                        matrizC.Numeros[i, j] += matrizA.Numeros[i, k] * matrizB.Numeros[k, j];
                    }
                });
            });
            return matrizC;
        }

        public static Matriz LlenarMatrizAutomaticamente(Matriz matriz)
        {
            var filas = matriz.Numeros.GetLength(0);
            var columnas = matriz.Numeros.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    var aleatorio = new Random();
                    matriz.Numeros[i, j] = aleatorio.Next(0, 100);
                }
            }
            return matriz;
        }

        public static Matriz LlenarMatrizUsuario(Matriz matriz)
        {
            var filas = matriz.Numeros.GetLength(0);
            var columnas = matriz.Numeros.GetLength(1);
            Console.WriteLine("Matriz " + matriz.Nombre);
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Fila {0}", i);
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Columna {0}", j);
                    matriz.Numeros[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matriz;
        }

        public static void Mostrar(List<Matriz> matrices)
        {
            Console.WriteLine();
            foreach (Matriz matriz in matrices)
            {
                Console.WriteLine();
                Console.WriteLine("Matriz {0}", matriz.Nombre);

                for (int i = 0; i < matriz.Numeros.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.Numeros.GetLength(1); j++)
                    {
                        Console.Write(matriz.Numeros[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
