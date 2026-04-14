namespace Cafeteria
{
    // Decorador de Chantilly
    public class Chantilly : AdicionalDecorator
    {
        public Chantilly(Bebida bebida) : base(bebida) { }

        public override string Descricao => _bebida.Descricao + ", Chantilly";

        public override double Custo()
        {
            return _bebida.Custo() + 2.50; // Soma 2.50 ao que já existia
        }
    }

    // Decorador de Chocolate
    public class Chocolate : AdicionalDecorator
    {
        public Chocolate(Bebida bebida) : base(bebida) { }

        public override string Descricao => _bebida.Descricao + ", Chocolate";

        public override double Custo()
        {
            return _bebida.Custo() + 3.00; // Soma 3.00 ao que já existia
        }
    }
}
