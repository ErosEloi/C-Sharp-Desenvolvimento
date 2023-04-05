using OrdemPedidos.Entities;
using OrdemPedidos.Entities.Enums;
using System;

namespace OrdemPedidos
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Digite o nome do cliente: ");
            String ClientName = Console.ReadLine();

            Console.Write("Digite o email do cliente: ");
            String ClientEmail = Console.ReadLine();

            Console.Write("Digte a data de nascimento: ");
            DateTime BirthdateClient = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do pedido: ");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(ClientName, ClientEmail, BirthdateClient);

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("Digite os itens do pedido: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do item #{i}");
                Console.Write("Nome: ");
                string ProductName = Console.ReadLine();
                Console.Write("Preço: ");
                double ProductPrice = double.Parse(Console.ReadLine());

                Product product = new Product(ProductName, ProductPrice);

                Console.Write("Quantidade: ");
                int QuantifyProduct = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(QuantifyProduct, ProductPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Resumo de compras: ");
            Console.WriteLine(order);
        }
    }
}