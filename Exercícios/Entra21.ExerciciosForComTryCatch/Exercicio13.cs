using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
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
            var jogadorMenorPeso = "";
            var menorPeso = double.MaxValue;
            var jogadorMaiorPeso = "";
            var maiorPeso = double.MinValue;
            var jogadorMaiorAltura = "";
            var maiorAltura = double.MinValue;
            var jogadorMenorNome = "";
            var menorNome = int.MaxValue;
            var jogadorMaiorNome = "";
            var maiorNome = int.MinValue;
            var jogadorMenosCartoesAmarelos = "";
            var menosCartoesAmarelos = int.MaxValue;
            var jogadorMaisCartoesAmarelos = "";
            var maisCartoesAmarelos = int.MinValue;
            var jogadorMenosCartoesVermelhos = "";
            var menosCartoesVermelhos = int.MaxValue;
            var jogadorMaisCartoesVermelhos = "";
            var maisCartoesVermelhos = int.MinValue;
            var jogadoresSexoM = 0;
            var jogadoresSexoF = 0;

            for (var i = 0; i < 22; i++)
            {
                Console.Clear();
                var testeNome = false;
                var nome = "";

                while (testeNome == false)
                {
                    Console.Write("Informe o nome do(a) jogador(a): ");
                    nome = Console.ReadLine().Trim();

                    if (nome.Length >= 3)
                    {
                        testeNome = true;
                    }
                }

                var idade = 0;

                while (idade <= 0)
                {
                    try
                    {
                        Console.Write("Informe a idade do(a) jogador(a): ");
                        idade = Convert.ToInt32(Console.ReadLine());

                        if (idade < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado é invalido. Por favor informe uma idade maior do que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado é invalido. Por favor informe um número maior do que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                var peso = 0.0;

                while (peso <= 0)
                {
                    try
                    {
                        Console.Write("Informe o peso do(a) jogador(a): ");
                        peso = Convert.ToDouble(Console.ReadLine());

                        if (peso < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado é invalido. Por favor informe um peso maior do que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado é invalido. Por favor informe um número maior do que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                var altura = 0.0;

                try
                {
                    Console.Write("Informe a altura do(a) jogador(a): ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    if (idade < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado é invalido. Por favor informe uma altura maior do que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado é invalido. Por favor informe um número maior do que zero.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                var sexo = "";
                var testeSexo = false;

                while (testeSexo == false)
                {
                    Console.Write("Informe o sexo do(a) jogador(a). Utilize 'M' para masculino ou 'F' para feminino: ");
                    sexo = Console.ReadLine().ToLower().Trim();

                    if (sexo != "m" && sexo != "f")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado é invalido. Por favor informe 'M' para masculino ou 'F' para feminino.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        testeSexo = true;
                    }
                }

                var testeGols = false;                

                while (testeGols == false)
                {
                    try
                    {
                        Console.Write("Informe a quantidade de gols marcados pelo(a) jogador(a): ");
                        var golsMarcados = Convert.ToInt32(Console.Read());

                        if (golsMarcados < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado é invalido. Por favor informe um número inteiro igual ou maior que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            testeGols = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado é invalido. Por favor informe um número inteiro igual ou maior que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                var testeCartoesAmarelos = false;
                var cartoesAmarelos = 0;

                while (testeCartoesAmarelos == false)
                {
                    try
                    {
                        Console.Write("Informe a quantidade de cartões amarelos recebidos pelo(a) jogador(a): ");
                        cartoesAmarelos = Convert.ToInt32(Console.ReadLine());

                        if (cartoesAmarelos < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado é invalido. Por favor informe um número inteiro igual ou maior que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            testeCartoesAmarelos = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado é invalido. Por favor informe um número inteiro igual ou maior que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                var testeCartoesVermelhos = false;
                var cartoesVermelhos = 0;

                while (testeCartoesVermelhos == false)
                {
                    try
                    {
                        Console.Write("Informe a quantidade de cartões vermelhos recebidos pelo(a) jogador(a): ");
                        cartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                        if (cartoesVermelhos < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado é invalido. Por favor informe um número inteiro igual ou maior que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            testeCartoesVermelhos = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado é invalido. Por favor informe um número inteiro igual ou maior que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    jogadorMenorPeso = nome;
                }

                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    jogadorMaiorPeso = nome;
                }

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    jogadorMaiorAltura = nome;
                }

                if (nome.Length < menorNome)
                {
                    menorNome = nome.Length;
                    jogadorMenorNome = nome;
                }

                if(nome.Length > maiorNome)
                {
                    maiorNome = nome.Length;
                    jogadorMaiorNome = nome;
                }

                if (cartoesAmarelos < menosCartoesAmarelos)
                {
                    menosCartoesAmarelos = cartoesAmarelos;
                    jogadorMenosCartoesAmarelos = nome;
                }

                if (cartoesAmarelos > maisCartoesAmarelos)
                {
                    maisCartoesAmarelos = cartoesAmarelos;
                    jogadorMaisCartoesAmarelos = nome;
                }

                if (cartoesVermelhos < menosCartoesVermelhos)
                {
                    menosCartoesVermelhos = cartoesVermelhos;
                    jogadorMenosCartoesVermelhos = nome;
                }

                if (cartoesVermelhos > maisCartoesVermelhos)
                {
                    maisCartoesVermelhos = cartoesVermelhos;
                    jogadorMaisCartoesVermelhos = nome;
                }

                if (sexo == "m")
                {
                    jogadoresSexoM++;
                }

                if (sexo == "f")
                {
                    jogadoresSexoF++;
                }
            }

            Console.Clear();
            Console.WriteLine("O(a) jogador(a) com o menor peso é: " + jogadorMenorPeso);
            Console.WriteLine("O(a) jogador(a) com o maior peso é: " + jogadorMaiorPeso);
            Console.WriteLine("O(a) jogador(a) com a maior altura é: " + jogadorMaiorAltura);
            Console.WriteLine("O(a) jogador(a) com o menor nome é: " + jogadorMenorNome);
            Console.WriteLine("O(a) jogador(a) com o maior nome é: " + jogadorMaiorNome);
            Console.WriteLine("A um total de " + jogadoresSexoF + " jogador(es) do sexo F.");
            Console.WriteLine("A um total de " + jogadoresSexoM + " jogador(es) do sexo M.");
            Console.WriteLine("O(a) jogador(a) com a menor quantidade de cartões amarelos é: " + jogadorMenosCartoesAmarelos);
            Console.WriteLine("O(a) jogador(a) com a maior quantidade de cartões amarelos é: " + jogadorMaisCartoesAmarelos);
            Console.WriteLine("O(a) jogador(a) com a menor quantidade de cartões vermelhor é: " + jogadorMenosCartoesVermelhos);
            Console.WriteLine("O(a) jogador(a) com a maior quantidade de cartões vermelhor é: " + jogadorMaisCartoesVermelhos);
        }
    }
}