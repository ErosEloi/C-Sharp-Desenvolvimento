using System;

namespace calculadora_IMC
{
    class Calculadora_IMC
    {
        static void Main(string[] args)
        {
            int continuar;
            float peso, altura;
            do
            {

                Console.WriteLine("Digite seu peso: ");
                peso = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua altura: ");
                altura = float.Parse(Console.ReadLine());

                float imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc >= 18.6 && imc < 24.9)
                {
                    Console.WriteLine("Peso Ideal");
                }
                else if (imc >= 25 && imc < 29.9)
                {
                    Console.WriteLine("Levemente acima do peso");
                }
                else if (imc >= 30 && imc < 34.9)
                {
                    Console.WriteLine("Obesidade grau 1");
                }
                else if (imc >= 35 && imc < 39.9)
                {
                    Console.WriteLine("Obesidade grau 2(Severa)");
                }
                else
                {
                    Console.WriteLine("Obesidade grau 3(Mórbida)");
                }
                Console.WriteLine("Deseja fazer outra medição? Digite: (1)Sim / (2)Não");
                continuar = int.Parse(Console.ReadLine());
            } while (continuar == 1);
        }
    }
}
