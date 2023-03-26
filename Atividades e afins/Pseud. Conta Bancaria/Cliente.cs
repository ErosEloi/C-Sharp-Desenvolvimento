using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Cliente
    {

        public int NumeroConta;
        public double Saldo;

        public Cliente(int numeroConta)
        {
            NumeroConta = numeroConta;
        }

        public double Adicionar(double botar)
        {
            return Saldo += botar;
        }

        public double Retirar(double tirar)
        {
            return Saldo -= tirar;
        }

        


    }
}
