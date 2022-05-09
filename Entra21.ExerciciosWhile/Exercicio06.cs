using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        /* Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de
         * sair, ao final deve-se aplicar ao valor total da compra um desconto de 5%.
         */
        public void Executar()
        {
            string nomeProduto = "";
            double somaProduto = 0;


            while (nomeProduto != "sair")
            {
                Console.Write("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower().Trim();

                if (nomeProduto != "sair")
                {
                    Console.Write("Informe o valor do produto: R$ ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Informe a quantidade de produtos: ");
                    int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                    somaProduto = somaProduto + (valorProduto * quantidadeProduto);
                }

                Console.Clear();
            }

            double totalCompraComDesconto = somaProduto * 0.95;

            Console.WriteLine("O valor total da compra, com 5% de desconto, é de: R$ " + totalCompraComDesconto);
        }
    }
}