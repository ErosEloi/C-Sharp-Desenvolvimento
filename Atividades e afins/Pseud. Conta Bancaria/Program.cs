using System;
using System.Globalization;
using System.Net.Mail;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarações importantes
            int op, escolha, cont, senha;
            Cliente var = new Cliente(121212);

            //"Tela de login"
            Console.WriteLine("Olá cliente: " + var.NumeroConta);
            Console.Write("Digite sua senha: ");
            senha = int.Parse(Console.ReadLine());

            //Validação da senha
           if (senha != 2022)
            {
                do
                {
                    Console.WriteLine("Senha Incorreta!");
                    Console.Write("Digite a senha novamente: ");
                    senha = int.Parse(Console.ReadLine());
                    Console.WriteLine("=======================================================");
                } while (senha != 2022);
            }
            //Operações na conta
            Console.WriteLine("Numero da conta: " + var.NumeroConta);
            Console.WriteLine("Saldo: " + var.Saldo);

            Console.WriteLine("Desja fazer deposito/saque? (1) para sim / (2) para não");
            op = int.Parse(Console.ReadLine());


            if (op == 1)
            {

                do
                {
                    //Escolha da operção
                    Console.WriteLine();
                    Console.WriteLine("Digite a operação: (1) para Deposito / (2) para Saque");
                    escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)
                    {
                        //Operação - Deposito
                        Console.WriteLine();
                        Console.Write("Digite o valor do deposito: ");
                        double botar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        var.Adicionar(botar);
                        Console.WriteLine("Saldo: " + var.Saldo.ToString(CultureInfo.InvariantCulture));
                    }
                    else if (escolha == 2)
                    {
                        //Operação - Saldo
                        Console.WriteLine();
                        Console.Write("Digite o valor de Saque: ");
                        double tirar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
                        //Validação - Saldo
                        if (tirar > var.Saldo)
                        {
                            Console.WriteLine("Saldo insuficiente!");
                        }
                        else
                        {
                            Console.WriteLine();
                            var.Retirar(tirar);
                            Console.WriteLine("Valor do saque: " + tirar);
                            Console.WriteLine("Valor restante na conta: " + var.Saldo);
                        }
                    }

                    //Loop de uso
                    Console.WriteLine();
                    Console.WriteLine("Deseja continuar?");
                    cont = int.Parse(Console.ReadLine());

                } while (cont == 1);
            }
            else
            {
                //Encerramento
                Console.WriteLine("Acesso encerrado");

            }


        }
    }
}
