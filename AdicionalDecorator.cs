namespace Cafeteria
{
    // O Decorador também herda de Bebida
    public abstract class AdicionalDecorator : Bebida
    {
        protected Bebida _bebida;

        public AdicionalDecorator(Bebida bebida)
        {
            _bebida = bebida;
        }
    }
}
