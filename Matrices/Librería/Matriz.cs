using System;
using System.Collections.Generic;

namespace Librería
{
    public class Matriz 
    {
      public Matriz()
      {}

      public Matriz(string nombre)
      {
        Nombre = nombre;
      }

      public double[,] Numeros {get;set;}
      
      public string Nombre {get;set;}

      public static Matriz Multiplicar(Matriz matrizA, Matriz matrizB)
      {
        int filasMatrizA=matrizA.Numeros.GetLength(0);
        int columnasMatrizB=matrizB.Numeros.GetLength(1);
        
        Matriz matrizProducto = new Matriz();
        matrizProducto.Numeros=new double[filasMatrizA,columnasMatrizB];

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

      public static Matriz LlenarMatriz(Matriz matriz)
      {
        var filas = matriz.Numeros.GetLength(0);
        var columnas = matriz.Numeros.GetLength(1);

        for (int i = 0; i < filas; i++) 
        {
            for (int j = 0; j < columnas; j++) 
            {
              var aleatorio = new Random();
              matriz.Numeros[i,j]=aleatorio.Next(0,100);
            }
        }
         return matriz;
      }

      public static Matriz LlenarMatrizUsuario(Matriz matriz)
      {
        var filas = matriz.Numeros.GetLength(0);
        var columnas = matriz.Numeros.GetLength(1);
        Console.WriteLine("Matriz "+matriz.Nombre);
        for (int i = 0; i < filas; i++) 
        {
            Console.WriteLine("Fila {0}",i);
            for (int j = 0; j < columnas; j++) 
            {
              Console.WriteLine("Columna {0}",j);
              matriz.Numeros[i,j]=int.Parse(Console.ReadLine());
            }
        }
         return matriz;
      }


      /*public static int[,] MultiplicarMatricesParalelamente([,]matrizA, matrizBi, matrizC)
      {
        matrizA.Numeros.GetLength(1);
        matrizB.Numeros.GetLength(1);
        matrizA.Numeros.GetLength(0);
        
        Parallel.For(0, matARows, i =>
        {
            for (int j = 0; j < matBCols; j++)
            {
                double temp = 0;
                for (int k = 0; k < matACols; k++)
                {
                    temp += matA[i, k] * matB[k, j];
                }
                result[i, j] = temp;
            }
        });
        Parallel.For(0,)
      }*/
      public static void Mostrar(List<Matriz> matrices)
      {
        nsole.WriteLine();
        foreach(Matriz matriz in matrices)
        {
            Console.WriteLine();
            Console.WriteLine("Matriz {0}",matriz.Nombre);
              
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
