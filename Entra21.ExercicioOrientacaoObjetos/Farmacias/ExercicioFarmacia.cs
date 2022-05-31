using ConsoleTables;
using Entra21.ExercicioOrientacaoObjetos.TestesDeValidacaoDeInformacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetos.Farmacias
{
    public class ExercicioFarmacia
    {
        public void Executar()
        {
            var farmacia = new Farmacia();
            var nome = new NomesCoisasValidos();
            var valor = new NumerosRacionaisPositivosValidos();
            var cnpj = new CnpjValido();

            Console.Clear();
            Console.Write("Por favor, informe a razão social da farmácia: ");
            farmacia.RazaoSocial = nome.ObterNome();

            Console.WriteLine();
            Console.Write("Informe o CNPJ da farmácia (xx.xxx.xxx/xxxx-xx): ");            
            farmacia.Cnpj = cnpj.ObterCnpj();

            for (var i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write("Informe o nome do produto: ");
                farmacia.NomeProduto[i] = nome.ObterNome();

                Console.WriteLine();
                Console.Write("Informe o preço do produto: ");
                farmacia.PrecoProduto[i] = valor.ObterNumeroRacionalPositivoValido();

                Console.WriteLine();
                var table = new ConsoleTable("Código", "Categorias");
                table.AddRow("1", "Analgésicos");
                table.AddRow("2", "Antibióticos");
                table.AddRow("3", "Anticoagulantes");
                table.AddRow("4", "Antidepressivos");
                table.AddRow("5", "Anticancerosos");
                table.AddRow("6", "Antiepiléticos");
                table.AddRow("7", "Anti Psicóticos");
                table.AddRow("8", "Antivirais");
                table.AddRow("9", "Sedativos");
                table.AddRow("10", "Anti Inflamatórios Não Esteroidais");
                table.AddRow("11", "Anti Inflamatórios Esteroidais");
                table.AddRow("12", "Droga Anti Reumática Modificadora de Doença");
                table.Write(Format.Minimal);

                Console.WriteLine();
                Console.Write("Informe o código da categoria: ");
                farmacia.CategoriaProduto[i] = nomeCategoria();
            }

            var totalPedido = farmacia.ApresentarTotalDoPedido();
            var totalPedidoPorCategoria = farmacia.ApresentarTotalDoPedidoPorCategoriaDeProduto();
            var quantidadeCategoria = farmacia.ApresentarQuantidadePorCategoria();
            var produtoMaisCaro = farmacia.ApresentarNomeProdutoMaisCaro();
            var produtoMaisBarato = farmacia.ApresentarNomeCategoriaProdutoMaisBarato();

            Console.Clear();
            Console.WriteLine(totalPedido);
            Console.WriteLine(totalPedidoPorCategoria);
            Console.WriteLine(quantidadeCategoria);
            Console.WriteLine(produtoMaisCaro);
            Console.WriteLine(produtoMaisBarato);
        }

        private string nomeCategoria()
        {
            var numero = new NumerosInteirosPositivosValidos();
            var testeCategoriaValida = false;
            var categoria = 0;

            while (testeCategoriaValida == false)
            {
                categoria = numero.ObterNumeroInteiroPositivoValido();

                if (categoria < 13)
                {
                    testeCategoriaValida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O código da categoria informado não é valido. Por favor informe um número inteiro entre 1 e 12.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe um novo código: ");
                }
            }

            if (categoria == 1)
            {
                return "analgésicos";
            }
            else if (categoria == 2)
            {
                return "antibióticos";
            }
            else if (categoria == 3)
            {
                return "anticoagulantes";
            }
            else if (categoria == 4)
            {
                return "antidepressivos";
            }
            else if (categoria == 5)
            {
                return "anticancerosos";
            }
            else if (categoria == 6)
            {
                return "antiepiléticos";
            }
            else if (categoria == 7)
            {
                return "anti psicóticos";
            }
            else if (categoria == 8)
            {
                return "antivirais";
            }
            else if (categoria == 9)
            {
                return "sedativos";
            }
            else if (categoria == 10)
            {
                return "anti inflamatórios não esteroidais";
            }
            else if (categoria == 11)
            {
                return "anti inflamatórios esteroidais";
            }
            else
            {
                return "droga anti reumática modificadora de doença";
            }
        }
    }
}