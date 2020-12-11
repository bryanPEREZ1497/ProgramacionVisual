namespace Matematica.Negocio
{
    public class Complejo
    {
        public double x;
        public double y;

        public Complejo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Real { get; internal set; }
        public int Imaginaria { get; internal set; }
    }
}