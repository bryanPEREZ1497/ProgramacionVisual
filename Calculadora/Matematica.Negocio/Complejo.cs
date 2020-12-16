using System;
using System.Diagnostics.CodeAnalysis;

namespace Matematica.Negocio
{
    public class Complejo:IEquatable<Complejo> 
    {              
        public Complejo(double real, double imaginaria)
        {
            this.Real = real;
            this.Imaginaria = imaginaria;
        }

        public double Real { get;  set; }
        public double Imaginaria { get;  set; }

        public bool Equals([AllowNull] Complejo other)
        {
            return Real == other.Real && Imaginaria == other.Imaginaria;
        }
    }

    /*public bool Equals([AllowsNull] Complejo other)
    {
      return Real==other.Real&&Imaginaria==other.Imaginaria;
    }*/
}
