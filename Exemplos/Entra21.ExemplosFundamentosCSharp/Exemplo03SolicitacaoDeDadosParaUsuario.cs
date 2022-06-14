using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class Exemplo03SolicitacaoDeDadosParaUsuario
    {
        public void Executar()
        {
            // Pedir o nome, a quantidade e o valor de 2 produtos. No final apresentar a soma de seus valores
            Console.Write("Informe o nome do Produto 1: ");
            string produto1 = Console.ReadLine();
            Console.Write("Informe a quantidade do Produto 1: ");
            int quantidadeProduto1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor do Produto 1: ");
            double valorProduto1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o nome do Produto 2: ");
            string produto2 = Console.ReadLine();
            Console.Write("Informe a quantidade do Produto 2: ");
            int quantidadeProduto2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor do Produto 2: ");
            double valorProduto2 = Convert.ToDouble(Console.ReadLine());

            double soma = quantidadeProduto1 * valorProduto1 + quantidadeProduto2 * valorProduto2;

            Console.WriteLine("O valor total da compra foi de: R$ " + soma);
        }
    }
}
