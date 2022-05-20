using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio04
    {
        /* Crie um vetor para armazenar as notas de uma disciplina.
         * A disciplina deve conter 4 notas.
         * Solicite para o usuário o nome e as quatro notas, armazenando as notas em um
         * vetor, realize a média destas notas e apresente.
         */
        public void Executar()
        {
            var teste = false;
            var disciplina = "";

            while (teste == false)
            {
                Console.Clear();
                Console.Write("Informe o nome da disciplina: ");
                disciplina = Console.ReadLine().Trim();

                if (disciplina.Length < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome da disciplina informado não é valido. Por favor informe um nome que contenha ao menos 5 caracteres.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    teste = true;
                }
            }
                        
            var notas = new double[4];
            var somaNotas = 0.0;

            for (var i = 0; i < notas.Length; i++)
            {
                var nota = -1.0;

                while (nota < 0.0)
                {
                    try
                    {
                        Console.Write($"Informe a nota{i+1}: ");
                        nota = Convert.ToDouble(Console.ReadLine());

                        if (nota >= 0.0)
                        {
                            notas[i] = nota;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nota informada não é valida. Por favor informe uma nota que seja maior ou igual a zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nota informada não é valida. Por favor informe uma nota que seja maior ou igual a zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                somaNotas = somaNotas + notas[i];
            }

            var mediaNotas = somaNotas / 4;

            Console.Clear();
            Console.WriteLine($"A média da {disciplina} foi de {mediaNotas.ToString("F")}.");
        }
    }
}
