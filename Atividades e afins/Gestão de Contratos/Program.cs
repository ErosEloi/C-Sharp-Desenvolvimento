using GestãoDeContratos.Entities;
using GestãoDeContratos.Entities.Enums;
using System;
using System.Globalization;

namespace GestãoDeContratos
{
    class Program
    {
        static void Main(String[] args)
        {
            
            Console.WriteLine();
            Console.Write("Digite o departamento: ");
            string departament = Console.ReadLine();
            Department d1 = new Department(departament);
            Console.WriteLine();

            Console.Write("Digite o nome do funcionario: ");
            string name = Console.ReadLine();

            Console.Write("Digite o nivel de cargo: (Junior/Pleno/Senior)");
            string nivel = Console.ReadLine();
            WorkerLevel level = Enum.Parse<WorkerLevel>(nivel);

            Console.Write("Digite seu salario base: ");
            double salary = double.Parse(Console.ReadLine()) ;

            Worker n1 = new Worker(name, level,salary);
            Console.WriteLine(n1);


            Console.Write("Digite o numero de contratos: ");
            int n = int.Parse(Console.ReadLine());

            List<HourContract> dados = new List<HourContract>();

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Digite os dados do contrato");
                Console.WriteLine("Data: ");
                DateTime data = DateTime.Parse( Console.ReadLine());

                Console.Write("Valor por hora: ");
                double ValorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                dados.Add(new HourContract(data, ValorHora, horas));
            }
        }
    }
}
