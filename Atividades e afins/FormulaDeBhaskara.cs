using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PrimeiroProjeto
{
    internal class FormulaDeBhaskara
    {
        static void Main (string[] args)
        {
            //Coleta e declaração de variável
            
            Console.WriteLine("Digite a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite c: ");
            double c = double.Parse(Console.ReadLine());



            // Calculo da Função
            double delta = (Math.Pow(b, 2)) - (4 * a * c);
            double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
            double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            //Resposta ao usúario
            Console.WriteLine("Delta vai ser: " +delta);
            Console.WriteLine("x1 vai ser: " +x1);
            Console.WriteLine("x2 vai ser: " +x2);

        }
    }
}
