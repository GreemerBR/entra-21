using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetoresComplementares
{
    internal class Exercicio06
    {
        // Crie um vetor de números e solicite. Após isto apresentar os números em ordem decrescente
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

            var numerosOrdemDecrescente = new double[quantidadeNumeros];

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                var contador = 0;
                for (var j = 0; j < quantidadeNumeros; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        contador++;
                    }
                }

                numerosOrdemDecrescente[contador] = numeros[i];
            }

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                if (numerosOrdemDecrescente[i] == 0)
                {
                    numerosOrdemDecrescente[i] = numerosOrdemDecrescente[i - 1];
                }
            }

            var table = new ConsoleTable("Números em ordem decrescente");

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                table.AddRow(numerosOrdemDecrescente[i]);
            }

            table.Write(Format.Alternative);

        }
    }
}