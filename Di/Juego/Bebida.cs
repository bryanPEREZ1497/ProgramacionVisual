namespace Juego
{
    abstract class Bebida
    {        
        public string Tipo { get; set; }
        public abstract string Preparar();       
        
    }
}
