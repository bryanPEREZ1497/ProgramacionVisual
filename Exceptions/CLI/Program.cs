using System;
using Logic;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Número del mes");
          try
          {
            int numeroMes = int.Parse(Console.ReadLine());
            Console.WriteLine(NombreMes(numeroMes));
          }
          catch(SoloHayDoceMeses e)
          {
            Console.WriteLine(e.Message);
          }

          catch(FormatException e)
          {
            Console.WriteLine("No escribiste nada: "+e.Message);
          }
        }
        public static string NombreMes(int numeroMes)
        {
          switch(numeroMes)
          {
            case 1:
              return "Enero";
            case 2:
              return "Febrero";
            case 3:
              return "Marzo";
            case 4:
              return "Abril";
            case 5:
              return "Mayo";
            case 6:
              return "Junio";
            case 7:
              return "Julio";
            case 8:
              return "Agosto";
            case 9:
              return "Septiembre";
            case 10:
              return "Octubre";
            case 11:
              return "Noviembre";
            case 12:
              return "Diciembre";
            default:
              throw new SoloHayDoceMeses("Solo hay doce meses");
          }
        }
    }
}
