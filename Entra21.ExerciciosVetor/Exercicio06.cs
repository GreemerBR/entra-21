using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio06
    {
        // Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior idade
        public void Executar()
        {
            var pessoas = new string[9];
            var idades = new int[9];
            var maiorIdade = int.MinValue;
            var pessoaMaiorIdade = "";

            for (var i = 0; i < idades.Length; i++)
            {
                var teste = false;

                while (teste == false)
                {
                    Console.Clear();
                    Console.Write("Informe o nome da pessoa: ");
                    var nome = Console.ReadLine().Trim();

                    if (nome.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome informado não é valida. Por favor informe um nome com no mínimo três caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        pessoas[i] = nome;
                        teste = true;
                    }
                }

                var idade = 0;

                while (idade <= 0)
                {
                    try
                    {
                        Console.Write($"Informe a idade do(a) {pessoas[i]}: ");
                        idade = Convert.ToInt32(Console.ReadLine());

                        if (idade <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A idade informada não é valida. Por favor informe uma idade maior do que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            idades[i] = idade;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A idade informada não é valida. Por favor informe uma idade maior do que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                if (idade > maiorIdade)
                {
                    maiorIdade = idades[i];
                    pessoaMaiorIdade = pessoas[i];
                }
            }

            Console.Clear();
            Console.WriteLine($"A pessoa com a maior idade é o(a) {pessoaMaiorIdade} e ele(a) tem {maiorIdade} anos.");
        }
    }
}
