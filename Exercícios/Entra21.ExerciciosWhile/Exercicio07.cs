using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        /* Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que
         * 5. Ao final deve-se aplicar um desconto de R$ 150,00.
         */
        public void Executar()
        {
            int indice = 0;
            double somaProduto = 0;


            while (indice < 5)
            {
                Console.Write("Informe o nome do produto: ");
                string nomeProduto = Console.ReadLine().ToLower().Trim();

                Console.Write("Informe o valor do produto: R$ ");
                double valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe a quantidade de produtos: ");
                int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                somaProduto = somaProduto + (valorProduto * quantidadeProduto);

                Console.Clear();
                indice = indice + 1;
            }

            double totalCompraComDesconto = somaProduto - 150.00;

            Console.WriteLine("O valor total da compra, com R$150,00 de desconto, é de: R$ " + totalCompraComDesconto);
        }
    }
}