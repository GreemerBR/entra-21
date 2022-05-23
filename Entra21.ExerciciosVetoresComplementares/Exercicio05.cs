using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetoresComplementares
{
    internal class Exercicio05
    {
        // Crie um vetor de números e solicite. Após isto apresentar os números em ordem crescente
        public void Executar()
        {
            Console.Clear();
            var quantidadeNumeros = 0;

            while (quantidadeNumeros <= 0)
            {
                try
                {
                    Console.Write("Informe a quantidade de números que serão digitados: ");
                    quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

                    if (quantidadeNumeros <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro maior que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro maior que zero.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            var numeros = new double[quantidadeNumeros];

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                var teste = false;

                while (teste == false)
                {
                    try
                    {
                        Console.Write("Informe o número: ");
                        var numero = Convert.ToDouble(Console.ReadLine());

                        numeros[i] = numero;
                        teste = true;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            var numerosOrdemCrescente = new double[quantidadeNumeros];

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                var contador = 1;
                for (var j = 0; j < quantidadeNumeros; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        contador++;
                    }
                }

                numerosOrdemCrescente[quantidadeNumeros - contador] = numeros[i];
            }

            var table = new ConsoleTable("Números em ordem crescente");

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                table.AddRow(numerosOrdemCrescente[i]);
            }

            table.Write(Format.Alternative);

        }
    }
}