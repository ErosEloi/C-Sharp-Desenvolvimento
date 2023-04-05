using GestaoDeContratos.Entities;
using GestaoDeContratos.Entities.Enums;
using System;
using System.Globalization;

namespace GestaoDeContratos
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("digite o departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Entre com os dados do funcionario: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nivel (Junior / Pleno / Senior): ");
            WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salário base: ");
            double salario = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(nome, nivel, salario, dept);

            Console.WriteLine();

            Console.Write("Digite o numero de contratos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<= n; i++)
            {
                Console.Write($"Entre com os dados do contrato {i}");

                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Carga-Horaria: ");
                int cargaHora = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valorHora, cargaHora);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Digite o mes e o ano para calcular o ganho: ");
            string MonthAndYear = Console.ReadLine();
            int Month = int.Parse(MonthAndYear.Substring(0, 2));
            int Year = int.Parse(MonthAndYear.Substring(3));

            Console.WriteLine("Nome: " +worker.Name);
            Console.WriteLine("Departamento: " +worker.Department.Name);
            Console.WriteLine("Ganhos em " + MonthAndYear + ": " + worker.Income(Year, Month));

        }
    }
}
