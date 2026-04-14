using System;

namespace Cafeteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Cafeteria do Padrão Decorator\n");

            // Cria um café simples
            Bebida meuPedido = new CafeExpresso();
            Console.WriteLine($"Pedido inicial: {meuPedido.Descricao} | Custo: R$ {meuPedido.Custo():F2}");

            // Adiciona o Chantilly no café
            meuPedido = new Chantilly(meuPedido);
            Console.WriteLine($"Adicionando Chantilly: {meuPedido.Descricao} | Custo: R$ {meuPedido.Custo():F2}");

            // Adiciona o chocolate 
            meuPedido = new Chocolate(meuPedido);
            Console.WriteLine($"Adicionando Chocolate: {meuPedido.Descricao} | Custo: R$ {meuPedido.Custo():F2}");

            Console.WriteLine("\nResumo Final do Pedido");
            Console.WriteLine($"Produto: {meuPedido.Descricao}");
            Console.WriteLine($"Total a Pagar: R$ {meuPedido.Custo():F2}");
        }
    }
}
