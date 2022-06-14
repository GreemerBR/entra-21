using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        /* O comitê da seleção brasileira de futebol deseja obter algumas estatísticas dos
         * jogadores, para visualizar melhor o desempenho de seus atletas.
         * Para tal deve-se solicitar as seguintes informações abaixo:
         * ➔ Nome;
         * ➔ Idade;
         * ➔ Peso;
         * ➔ Sexo;
         * ➔ Altura;
         * ➔ Quantidade de gols marcados;
         * ➔ Quantidade de cartões amarelos recebidos;
         * ➔ Quantidade de cartões vermelhos recebidos;
         * 
         * Lembrando que um time de futebol terá 22 jogadores.
         * 
         * Ao final deve-se apresentar as seguintes estatísticas:
         * ➔ O jogador com o menor peso;
         * ➔ O jogador com a maior altura;
         * ➔ O jogador com o maior nome;
         * ➔ A quantidade de jogadores do sexo F
         * ➔ A quantidade de jogadores do sexo M
         * ➔ O jogador com a menor quantidade de cartões amarelos recebidos;
         * ➔ O jogador com o menor nome;
         * ➔ O jogador com o maior peso;
         * ➔ O jogador com a maior quantidade de cartões vermelhos recebidos;
         * ➔ O jogador com a maior quantidade de cartões amarelos recebidos;
         * ➔ O jogador com a menor quantidade de cartões vermelhos recebidos.
         */
        public void Executar()
        {
            string nome = "";
            int idade = 0;
            double peso = 0.00;
            string sexo = "";
            double altura = 0.00;
            int quantidadeGolsMarcados = 0;
            int quantidadeCartoesAmarelosRecebidos = 0;
            int quantidadeCartoesVermelhosRecebidos = 0;

            int quantidadeJogadores = 0;

            double maiorPeso = double.MinValue;
            string jogadorMaiorPeso = "";
            double menorPeso = double.MaxValue;
            string jogadorMenorPeso = "";
            double maiorAltura = double.MinValue;
            string jogadorMaiorAltura = "";
            int maiorNome = int.MinValue;
            string jogadorMaiorNome = "";
            int menorNome = int.MaxValue;
            string jogadorMenorNome = "";
            int maisCartoesAmarelos = int.MinValue;
            string jogadorMaisCartoesAmarelos = "";
            int menosCartoesAmarelos = int.MaxValue;
            string jogadorMenosCartoesAmarelos = "";
            int maisCartoesVermelhos = int.MinValue;
            string jogadorMaisCartoesVermelhos = "";
            int menosCartoesVermelhos = int.MaxValue;
            string jogadorMenosCartoesVermelhos = "";
            int quantidadeJogadoresM = 0;
            int quantidadeJogadoresF = 0;



            while (quantidadeJogadores < 3)
            {
                Console.Write("Informe o nome do jogador: ");
                nome = Console.ReadLine();

                if (nome.Length > maiorNome)
                {
                    jogadorMaiorNome = nome;
                    maiorNome = nome.Length;
                }
                if (nome.Length < menorNome)
                {
                    jogadorMenorNome = nome;
                    menorNome = nome.Length;
                }

                Console.Write("Informe a idade do(a) jogador(a) ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o peso do(a) jogador(a): ");
                peso = Convert.ToDouble(Console.ReadLine());

                if (peso > maiorPeso)
                {
                    jogadorMaiorPeso = nome;
                    maiorPeso = peso;
                }
                if (peso < menorPeso)
                {
                    jogadorMenorPeso = nome;
                    menorPeso = peso;
                }

                Console.Write("Informe o sexo do(a) jogador(a). Use M para masculino e F para feminino: ");
                sexo = Console.ReadLine().ToLower().Trim();

                if (sexo == "m")
                {
                    quantidadeJogadoresM = quantidadeJogadoresM + 1;
                }
                if (sexo == "f")
                {
                    quantidadeJogadoresF = quantidadeJogadoresF + 1;
                }

                Console.Write("Informe a algura do(a) jogador(a): ");
                altura = Convert.ToDouble(Console.ReadLine());

                if (altura > maiorAltura)
                {
                    jogadorMaiorAltura = nome;
                    maiorAltura = altura;
                }

                Console.Write("Informe a quantidade de gols marcados pelo(a) jogador(a): ");
                quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a quantidade de cartões amarelos recebidos pelo(a) jogador(a): ");
                quantidadeCartoesAmarelosRecebidos = Convert.ToInt32(Console.ReadLine());

                if (quantidadeCartoesAmarelosRecebidos > maisCartoesAmarelos)
                {
                    jogadorMaisCartoesAmarelos = nome;
                    maisCartoesAmarelos = quantidadeCartoesAmarelosRecebidos;
                }
                if (quantidadeCartoesAmarelosRecebidos < menosCartoesAmarelos)
                {
                    jogadorMenosCartoesAmarelos = nome;
                    menosCartoesAmarelos = quantidadeCartoesAmarelosRecebidos;
                }

                Console.Write("Informe a quantidade de cartões vermehos recebidos pelo(a) jogador(a): ");
                quantidadeCartoesVermelhosRecebidos = Convert.ToInt32(Console.ReadLine());

                if (quantidadeCartoesVermelhosRecebidos > maisCartoesVermelhos)
                {
                    jogadorMaisCartoesVermelhos = nome;
                    maisCartoesVermelhos = quantidadeCartoesVermelhosRecebidos;
                }
                if (quantidadeCartoesVermelhosRecebidos < menosCartoesVermelhos)
                {
                    jogadorMenosCartoesVermelhos = nome;
                    menosCartoesVermelhos = quantidadeCartoesVermelhosRecebidos;
                }

                quantidadeJogadores = quantidadeJogadores + 1;
                Console.WriteLine();

            }
            
            Console.WriteLine("O(a) jogador(a) com o menor peso é: " + jogadorMenorPeso);
            Console.WriteLine("O(a) jogador(a) com o maior peso é: " + jogadorMaiorPeso);
            Console.WriteLine("O(a) jogador(a) com a maior altura é: " + jogadorMaiorAltura);
            Console.WriteLine("O(a) jogador(a) com o menor nome é: " + jogadorMenorNome);
            Console.WriteLine("O(a) jogador(a) com o maior nome é: " + jogadorMaiorNome);
            Console.WriteLine("A quantidade de jogadoras é de: " + quantidadeJogadoresF);
            Console.WriteLine("A quantidade de jogadores é de: " + quantidadeJogadoresM);
            Console.WriteLine("O(a) jogador(a) com a menor quantidade de cartões amarelos é: " + jogadorMenosCartoesAmarelos);
            Console.WriteLine("O(a) jogador(a) com a maior quantidade de cartões amarelos é: " + jogadorMaisCartoesAmarelos);
            Console.WriteLine("O(a) jogador(a) com a menor quantidade de cartões vermelhos é: " + jogadorMenosCartoesVermelhos);
            Console.WriteLine("O(a) jogador(a) com a maior quantidade de cartões vermelhos é: " + jogadorMaisCartoesVermelhos);

        }
    }
}