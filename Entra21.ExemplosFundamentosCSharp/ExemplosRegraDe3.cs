using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class ExemplosRegraDe3
    {
        public void Executar()
        {
            // Como descobrir o percentual de algo
            int quantidadeTotalArquivos = 3120;
            int quantidadeParcial = 300;

            double percentual = quantidadeParcial * 100.0 / quantidadeTotalArquivos;

            // Como descobrir a quantidade parcial
            int quantidadeTotalAlunos = 23;
            double percentualAlunosJogamLol = 21.7391304348;

            int quantidadeAlunosJogamLol = Convert.ToInt32(quantidadeTotalAlunos * percentualAlunosJogamLol / 100);

            // Como descobrir a quantidade total
            int quantidadeViajaramParaFora = 22;
            double percentualViajaramParaFora = 95.652173913;

            int quantidadeTotal = Convert.ToInt32(quantidadeViajaramParaFora * 100 / percentualViajaramParaFora);
        }
    }
}
