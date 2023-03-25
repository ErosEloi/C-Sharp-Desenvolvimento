using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstoqueUnitario
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public double ValorTotal()
        {
            return Valor * Quantidade;
        }

        public double Adicionar(int botar)
        {
            return Quantidade += botar;
        }

        public double Retirar(int tirar)
        {
            return Quantidade -= tirar;
        }

        public override string ToString()
        {
            return "Produto: " +Nome +" Valor: " +Valor +" Quantidade: " +Quantidade +" Valor total: "+ValorTotal().ToString();
        }
    }

}
