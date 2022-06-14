using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
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
            int contadorLoop = 0;
            int contadorCarroA = 0;
            int contadorCarroG = 0;
            int somaAnos = 0;
            int mediaAnos = 0;
            double somaValoresCarros = 0;
            double mediaValoresCarros = 0;

            Console.Write("Informe a quantidade de carros a serem informados: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            while (contadorLoop < quantidade)
            {
                Console.Clear();
                Console.Write("Informe o modelo do carro: ");
                string modelo = Console.ReadLine().ToLower().Trim();                

                if (modelo.StartsWith("g") == true)
                {
                    contadorCarroG = contadorCarroG + 1;
                }

                if (modelo.StartsWith("a") == true)
                {
                    contadorCarroA = contadorCarroA + 1;
                }

                Console.Write("Informe o valor do carro: R$ ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());
                somaValoresCarros = somaValoresCarros + valorCarro;

                Console.Write("Informe o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());
                somaAnos = somaAnos + anoCarro;

                contadorLoop = contadorLoop + 1;
            }

            mediaAnos = somaAnos / quantidade;
            mediaValoresCarros = somaValoresCarros / quantidade;

            Console.WriteLine();
            Console.WriteLine("O ano médio dos carros é: " + mediaAnos);
            Console.WriteLine("O valor médio dos carros é de R$ " + mediaValoresCarros);
            Console.WriteLine("A quantidade de carros que começam com a letra G é: " + contadorCarroG);
            Console.WriteLine("A quantidade de carros que começam com a letra A é: " + contadorCarroA);

        }
    }
}