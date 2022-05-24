using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetoresComplementares
{
    internal class Exercicio04
    {
        /* Crie um vetor e solicite os números. Crie outros dois vetores, um deles irá armazenar
         * somente os números pares do vetor 1, o outro irá armazenar somente os números ímpares
         * do vetor 1.
         */
        public void Executar()
        {
            Console.Clear();
            var quantidadeNumeros = 0;
            var quantidadeValida = false;

            while (quantidadeValida == false)
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
                    else
                    {
                        quantidadeValida = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro maior que zero.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            Console.Clear();
            var numeros = new int[quantidadeNumeros];

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                var numeroValido = false;

                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Informe o número: ");
                        var numero = Convert.ToInt32(Console.ReadLine());

                        if (numero <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro maior que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            numeros[i] = numero;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro maior que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            var pares = new int[quantidadeNumeros];

            for (var i = 0; i == 0;)
            {
                for (var j = 0; j < quantidadeNumeros; j++)
                {
                    if (numeros[j] % 2 == 0)
                    {
                        pares[i] = numeros[j];
                        i++;
                    }
                }
            }

            var impares = new int[quantidadeNumeros];
            for (var i = 0; i == 0;)
            {
                for (var j = 0; j < quantidadeNumeros; j++)
                {
                    if (numeros[j] % 2 != 0)
                    {
                        impares[i] = numeros[j];
                        i++;
                    }
                }
            }

            Console.Clear();
            var table1 = new ConsoleTable("Todos os números digitados");

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                table1.AddRow(numeros[i]);
            }

            table1.Write(Format.Alternative);

            var table2 = new ConsoleTable("Números pares");
            for (var i = 0; i < pares.Length; i++)
            {
                if (pares[i] != 0)
                {
                    table2.AddRow(pares[i]);
                }
            }

            table2.Write(Format.Alternative);

            var table3 = new ConsoleTable("Números impares");
            for (var i = 0; i < impares.Length; i++)
            {
                if (impares[i] != 0)
                {
                    table3.AddRow(impares[i]);
                }
            }

            table3.Write(Format.Alternative);
        }
    }
}