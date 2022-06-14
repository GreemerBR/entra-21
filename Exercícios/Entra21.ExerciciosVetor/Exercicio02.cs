using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio02
    {
        //Crie um vetor para guardar 10 nomes e apresente os dez nomes
        public void Executar()
        {
            var nomes = new string[10];

            for (var i = 0; i < nomes.Length; i++)
            {
                var nome = "";
                var teste = false;

                while (teste == false)
                {
                    Console.Clear();
                    Console.Write("Informe o nome: ");
                    nome = Console.ReadLine().Trim();

                    if (nome.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome informado não é valido. Por favor informe um nome com no mínimo 3 caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        teste = true;
                    }
                }

                nomes[i] = nome;
            }

            var listaNomes = "";

            for (var i =0; i < nomes.Length; i++)
            {
                listaNomes = listaNomes + nomes[i] + ", ";
            }

            Console.Clear();
            Console.WriteLine(listaNomes);
        }
    }
}
