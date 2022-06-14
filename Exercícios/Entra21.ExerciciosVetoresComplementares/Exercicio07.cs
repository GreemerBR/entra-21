using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetoresComplementares
{
    internal class Exercicio07
    {
        /* Crie um vetor para armazenar os nomes dos produtos. Apresentar os nomes do menor
         * nome até o maior nome. Deve listar todos os nomes do menor para o maior
         */
        public void Executar()
        {
            Console.Clear();
            var quantidadeNomesProdutos = 0;
            var testeQuantidadeValida = false;

            while (testeQuantidadeValida == false)
            {
                try
                {
                    Console.Write("Informe a quantidade de produtos que serão informados: ");
                    quantidadeNomesProdutos = Convert.ToInt32(Console.ReadLine());

                    if (quantidadeNomesProdutos <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro positivo.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        testeQuantidadeValida = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro positivo.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            var nomesProdutos = new string[quantidadeNomesProdutos];

            for (var i = 0; i < quantidadeNomesProdutos; i++)
            {
                var testeNomeValido = false;

                while (testeNomeValido == false)
                {
                    Console.Clear();
                    Console.Write("Informe o nome do produto: ");
                    var nomeProduto = Console.ReadLine().Trim();

                    if (nomeProduto.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome informado não é valido. Por favor informe um nome com no mínimo dois caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        nomesProdutos[i] = nomeProduto;
                        testeNomeValido = true;
                    }
                }
            }

            var nomesProdutosOrdenados = new string[quantidadeNomesProdutos];

            for (var i = 0; i < quantidadeNomesProdutos; i++)
            {
                var contador = 0;
                for (var j = 0; j < quantidadeNomesProdutos; j++)
                {
                    if (nomesProdutos[i].Length > nomesProdutos[j].Length)
                    {
                        contador++;
                    }                    
                }

                nomesProdutosOrdenados[contador] = nomesProdutos[i];
            }

            for (var i = 0; i < quantidadeNomesProdutos; i++)
            {
                if (nomesProdutosOrdenados[i] == null)
                {
                    for (var j = 0; j < quantidadeNomesProdutos; j++)
                    {
                        if (nomesProdutosOrdenados[i - 1].Length == nomesProdutos[j].Length && nomesProdutosOrdenados[i - 1] != nomesProdutos[j])
                        {
                            nomesProdutosOrdenados[i] = nomesProdutos[j];
                        }
                    }
                }
            }

            var table = new ConsoleTable("Nomes dos produtos informados");

            for (var i = 0; i < quantidadeNomesProdutos; i++)
            {
                table.AddRow(nomesProdutos[i]);
            }

            table.AddRow("Nomes dos produtos ordenados");

            for (var i = 0; i < quantidadeNomesProdutos; i++)
            {
                table.AddRow(nomesProdutosOrdenados[i]);
            }

            Console.Clear();
            table.Write(Format.Alternative);
        }
    }
}