namespace Cafeteria
{
    public abstract class Bebida
    {
        public virtual string Descricao { get; protected set; } = "Bebida desconhecida";
        public abstract double Custo();
    }

    // O Café Expresso (o objeto real que vamos "decorar")
    public class CafeExpresso : Bebida
    {
        public CafeExpresso()
        {
            Descricao = "Café Expresso";
        }

        public override double Custo()
        {
            return 5.00; // Preço do café puro
        }
    }
}
