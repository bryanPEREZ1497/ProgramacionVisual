namespace Matematica.Negocio
{
    public class Complejo
    {              

        public Complejo(double real, double imaginaria)
        {
            this.Real = real;
            this.Imaginaria = imaginaria;
        }

        public double Real { get;  set; }
        public double Imaginaria { get;  set; }
    }
}
