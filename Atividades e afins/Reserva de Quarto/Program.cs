using System;

namespace RegistroDeQuartos
{
    class Program
    {
        static void Main(String[] args)
        {

            Cliente[] vect = new Cliente[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n ; i++)
            {
                
                Console.Write("Digite seu nome: ");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite seu email: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[quarto] = new Cliente(name, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
