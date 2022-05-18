using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo07
    {
        public void Executar()
        {
            double saldo = 3000;
            bool horarioEsgotado = false;
            double valorSaque = 2000;

            if ((valorSaque <= saldo) && (horarioEsgotado == false))
            {
                double novoSaldo = saldo - valorSaque;
                Console.WriteLine(@"Saque realizado: R$ " + valorSaque +
                    "Saldo anterior: R$ " + saldo + 
                    "Novo saldo: R$ " + novoSaldo);
                saldo = novoSaldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
