using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosListaObjetos
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();

        public void GerenciarMenu()
        {
            var opcaoDesejada = 0;

            while (opcaoDesejada != 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
-------------MENU-------------
1 - Cadastrar
2 - Apresentar Produtos
3 - SAIR
");

                try
                {
                    Console.Write("Digite a opção desejada: ");
                    opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                    if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A opção informada não é válida. Por favor informe um número presente no MENU.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A opção informada não é válida. Por favor informe um número presente no MENU.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (opcaoDesejada == 1)
                {

                    Cadastrar();
                }

                if (opcaoDesejada == 2)
                {
                    ApresentarProdutos();
                }
            }
        }
        private void Cadastrar()
        {
            Console.Write("Nome do produto: ");
            var nome = Console.ReadLine().Trim();

            Console.Write("Quantidade do produto: ");
            var quantidade = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Preço unitário do produto: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine().Trim());

            Console.Write("Localização do produto: ");
            var localizacao = Console.ReadLine().Trim();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }
        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }
        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            for (var i = 0; i < produtos.Count(); i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine($@"Nome: {produtoAtual.Nome}
Preço unitário: {produtoAtual.PrecoUnitario}");
            }
        }
    }
}
