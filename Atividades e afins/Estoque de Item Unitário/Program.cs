using System;
using System.Runtime.InteropServices;

namespace EstoqueUnitario
{
    class Program
    {
        static void Main(string[] args)
        {

            int op, encerrar;

            Produto item = new Produto();

            do
            {

                Console.WriteLine("Entre com os dados do produto");
                Console.Write("Digite o nome do produto: ");
                item.Nome = Console.ReadLine();

                Console.Write("Digite o valor: ");
                item.Valor = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade: ");
                item.Quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write(item);

                Console.WriteLine();
                Console.WriteLine("Deseja adicionar ou retirar o produto? (1) para adicionar / (2) para retirar / (3) sem alteração");
                op = int.Parse(Console.ReadLine());


                if (op == 1)
                {
                    Console.WriteLine();
                    Console.Write("Digite o numero para adicionar ao estoque: ");
                    int botar = int.Parse(Console.ReadLine());
                    item.Adicionar(botar);
                    Console.WriteLine();
                    Console.Write("Dados Atualizados! " + item);
                }
                else if (op == 2)
                {
                    Console.WriteLine();
                    Console.Write("Digite o numero para retirar do estoque: ");
                    int tirar = int.Parse(Console.ReadLine());
                    item.Retirar(tirar);

                    Console.WriteLine();
                    Console.Write("Dados Atualizados! " + item);
                }

                Console.WriteLine();
                Console.WriteLine("Deseja encerrar o programa? (1) para não / (2) para sim");
                encerrar = int.Parse(Console.ReadLine());

            } while (encerrar != 2);
        }
    }
}
