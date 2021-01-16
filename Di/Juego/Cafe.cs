namespace Juego
{
    public class Cafe : Bebida
    {
        public override string Preparar()
        {
            return string.Format("Calentar agua, añadir {0}, limones y azúcar al gusto", Tipo);
        }
    }
}
