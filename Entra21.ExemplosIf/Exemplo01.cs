using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo01
    {
        public void Executar()
        {
            double valorGanho = 30.00;
            double onibus = 5.50;
            double ingresso = 12.50;
            double fini = 7.00;
            double totalGasto = valorGanho - onibus - ingresso - fini;

            if (totalGasto > valorGanho)
            {
                Console.WriteLine("Ficarei em casa");
            }
            else
            {
                Console.WriteLine("Irei assistir o filme no cinema");
            }
        }
    }
}
