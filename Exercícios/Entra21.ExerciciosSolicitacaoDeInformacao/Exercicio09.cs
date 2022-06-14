using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio09
    {
        /* Solicitar nome do carro, valor do carro, valor de cada parcela e a quantidade de
         * meses em que o carro foi financiado, ao final deve ser apresentado:
         * a. Nome do carro;
         * b. Valor do carro;
         * c. Valor de cada parcela;
         * d. Quantidade de parcelas;
         * e. Valor total do financiamento;
         * f. Diferença entre o valor total do financiamento e valor do carro.
         */
        public void Executar()
        {
            Console.Write("Informe o nome do carro:");
            string nomeCarro = Console.ReadLine();
            Console.Write("Informe o valor do carro: R$ ");
            double valorCarro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de cada parcela: R$ ");
            double valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a quantidade de meses em que o carro foi financiado: ");
            int mesesFinanciados = Convert.ToInt32(Console.ReadLine());

            double valorTotalFinanciado = valorParcela * mesesFinanciados;
            double diferencaValor = valorTotalFinanciado - valorCarro;

            Console.Clear();
            Console.WriteLine("Nome do carro: " + nomeCarro);
            Console.WriteLine("Valor do carro: R$ " + valorCarro);
            Console.WriteLine("Valor de cada parcela: R$ " + valorParcela);
            Console.WriteLine("Quantidade de parcelas: " + mesesFinanciados);
            Console.WriteLine("Valor total financiado: R$ " + valorTotalFinanciado);
            Console.WriteLine("Diferença entre o valor total do financiamento e valor do carro: R$ " + diferencaValor);
        }
    }
}
