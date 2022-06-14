using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetoresComplementares
{
    internal class Exercicio02
    {
        /* Criar dois vetores, no primeiro solicite os nomes para o usuário, o outro vetor deverá ser
         * preenchido da seguinte forma:
         * - Primeira posição vetor 2 recebe última posição vetor 1.
         * - Segunda posição vetor 2 recebe penúltima posição vetor 1.
         * - E continua até terminar o preenchimento do vetor 2.
         */
        public void Executar()
        {
            Console.Clear();

            var quantidadeNomes = 0;

            while (quantidadeNomes <= 0)
            {
                try
                {
                    Console.Write("Informe a quantidade de nomes que serão cadastrados: ");
                    quantidadeNomes = Convert.ToInt32(Console.ReadLine());

                    if (quantidadeNomes <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade informada não é valida. Por favor informe um número inteiro maior que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A quantidade informada não é valida. Por favor informe um número inteiro maior que zero.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            var nomesDesordenados = new string[quantidadeNomes];           

            for (var i = 0; i < quantidadeNomes; i++)
            {

                Console.Clear();
                var nomeValido = false;

                while (nomeValido == false)
                {
                    Console.Write("Informe o nome: ");
                    var nome = Console.ReadLine().Trim();

                    if (nome.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome informado não é valido. Por favor informe um nome com ao menos 2 caracters.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        nomesDesordenados[i] = nome;                        
                        nomeValido = true;
                    }
                }
            }

            var nomesOrdenados = new string[quantidadeNomes];

            for (var i = 0; i < nomesOrdenados.Length; i++)
            {
                nomesOrdenados[i] = nomesDesordenados[(quantidadeNomes - i - 1)];
            }

            Console.Clear();            
            var table = new ConsoleTable("Nomes no vetor 1", "Nomes no vetor 2");

            for (var i = 0; i < quantidadeNomes; i++)
            {
                table.AddRow(nomesDesordenados[i], nomesOrdenados[i]);
            }

            table.Write(Format.Alternative);
        }
    }
}