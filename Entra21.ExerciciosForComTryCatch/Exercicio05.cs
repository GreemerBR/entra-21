using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio05
    {
        /* Faça um programa que solicite a quantidade de carros que o usuário deseja
         *  cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que
         *  atinja a quantidade de carros para cadastro.
         *  Apresente ao final:
         *  ● Média do ano dos carros;
         *  ● Média do valor dos carros;
         *  ● Quantidade de carros que começam com a letra G;
         *  ● Quantidade de carros que começam com a letra A
         */
        public void Executar()
        {
            var quantidadeCarros = 0;
            var somaAno = 0;            
            var somaValor = 0.0;
            var quantidadeCarrosComecamComA = 0;
            var quantidadeCarrosComecamComG = 0;

            Console.Clear();

            while (quantidadeCarros == 0)
            {
                try
                {
                    Console.Write("Informe a quantidade de carros que serão cadastrados: ");
                    quantidadeCarros = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A quantidade de carros informada não é valida. Por favor informe um número inteiro maior que zero.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            for (var i = 0; i < quantidadeCarros; i++)
            {
                Console.Clear();

                var nomeCarroTeste = false;

                while (nomeCarroTeste == false)
                {
                    Console.Write("Informe o modelo do carro: ");
                    var nomeCarro = Console.ReadLine().ToLower().Trim();

                    if (nomeCarro.Length >= 2)
                    {
                        nomeCarroTeste = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A modelo do carros informado não é valida. Este deve ter ao menos dois caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    if (nomeCarroTeste == true)
                    {
                        if (nomeCarro.StartsWith("a"))
                        {
                            quantidadeCarrosComecamComA++;
                        }

                        if (nomeCarro.StartsWith("g"))
                        {
                            quantidadeCarrosComecamComG++;
                        }
                    }
                }

                var valorCarroTeste = false;

                while (valorCarroTeste == false)
                {
                    var valorCarro = 0.0;
                    try
                    {
                        Console.Write("Informe o valor do carro: R$ ");
                        valorCarro = Convert.ToDouble(Console.ReadLine());

                        if (valorCarro > 0.00)
                        {
                            somaValor = somaValor + valorCarro;
                            valorCarroTeste = true;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A valor do carro informado não é valido. Este deve ser maior do que R$ 0,00.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A valor do carro informado não é valido. Este deve ser numérico e maior do que R$ 0,00.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                var anoCarroTeste = false;

                while (anoCarroTeste == false)
                {
                    var anoCarro = 0;
                    try
                    {
                        Console.Write("Informe o ano do carro: ");
                        anoCarro = Convert.ToInt32(Console.ReadLine());

                        if (anoCarro > 1900)
                        {
                            somaAno = somaAno + anoCarro;
                            anoCarroTeste = true;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A ano do carro informado não é valido. Este deve ser maior do que 1900.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A valor do carros informado não é valido. Este deve ser numérico e maior do que 1900.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            var mediaAno = somaAno / quantidadeCarros;
            var mediaValor = somaValor / quantidadeCarros;

            Console.Clear();
            Console.WriteLine("A ano médio dos carros é de " + mediaAno);
            Console.WriteLine("O valor médio dos carros é de R$ " + mediaValor);
            Console.WriteLine("Existem um total de " + quantidadeCarrosComecamComG + " carro(s) que começa(m) com a letra 'G'.");
            Console.WriteLine("Existem um total de " + quantidadeCarrosComecamComA + " carro(s) que começa(m) com a letra 'A'.");

            Console.WriteLine();
        }
    }
}