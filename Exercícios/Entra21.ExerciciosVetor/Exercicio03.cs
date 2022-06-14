using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        /* Crie dois vetores para guardar o nome e preço de 7 produtos e apresente o
         * nome e preço dos sete produtos
         */
        public void Executar()
        {
            var nomesProdutos = new string[7];
            var precosProdutos = new double[7];

            for (var i = 0; i < nomesProdutos.Length; i++)
            {
                var testeNome = false;
                Console.Clear();
                while (testeNome == false)
                {
                    Console.Write("Informe o nome do produto: ");
                    var nome = Console.ReadLine().Trim();

                    if (nome.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome informado não é valido. Por favor informe um nome com no mínimo 2 caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        nomesProdutos[i] = nome;
                        testeNome = true;
                    }
                }

                var preco = 0.0;
                while (preco <= 0.0)
                {
                    try
                    {
                        Console.Write("Informe o preço do produto: ");
                        preco = Convert.ToDouble(Console.ReadLine());

                        if (preco <= 0.0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado não é valido. Por favor informe um preço que seja maior do que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;

                            preco = 0.0;
                        }
                        else
                        {
                            precosProdutos[i] = preco;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um preço que seja maior do que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Lista de Produtos e Preços");
            for (var i = 0; i < precosProdutos.Length; i++)
            {
                Console.WriteLine($"Protudo: {nomesProdutos[i]} -> Preço: R$ {precosProdutos[i].ToString("F")}");
            }
        }
    }
}
