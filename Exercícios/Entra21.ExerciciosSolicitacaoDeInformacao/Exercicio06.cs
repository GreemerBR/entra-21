using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio06
    {
        /* Calcule a quantidade de litros de água ingeridos em determinado período e o valor
         * pago. Para tal deve-se solicitar ao usuário a média da quantidade de litros ingeridos
         * por dia, a quantidade de anos e o valor pago pela água.
         * Exemplo:
         * Quantidade de litros: 3
         * Quantidade de anos consumidos: 17
         * Valor por Litro: R$ 9.75
         * Quantidade de Litros consumidos: 18.615 L
         * Valor Total Pago: R$ 181.496, 25Calcule a quantidade de litros de água ingeridos em determinado período e o valor
         * pago. Para tal deve-se solicitar ao usuário a média da quantidade de litros ingeridos
         * por dia, a quantidade de anos e o valor pago pela água.
         * Exemplo:
         * Quantidade de litros: 3
         * Quantidade de anos consumidos: 17
         * Valor por Litro: R$ 9.75
         * Quantidade de Litros consumidos: 18.615 L
         * Valor Total Pago: R$ 181.496, 25
         */
        public void Executar()
        {
            Console.Write("Informe a quantidade média diária de água ingerida em Litros: ");
            double quantidadeMediaIngerida = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe por quantos anos essa quantidade de água foi ingerida: ");
            int quantidadeAnos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Infoorme o valor pago pelo Litro de água: R$ ");
            double valorLitroAgua = Convert.ToDouble(Console.ReadLine());

            double quantidadeTotalAguaConsumida = quantidadeMediaIngerida * 365 * quantidadeAnos;
            double valorTotalPago = quantidadeTotalAguaConsumida * valorLitroAgua;

            Console.Clear();
            Console.WriteLine("A quantidade total de água consumida foi de " + quantidadeTotalAguaConsumida + " L. " +
                "\nE o valor total pago foi de R$ " + valorTotalPago);
        }
    }
}
