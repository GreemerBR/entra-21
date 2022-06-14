using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio07
    {
        //Solicite a altura de 4 animais, apresente ao final a altura do animal com a menor altura
        public void Executar()
        {
            var alturasAnimais = new double[4];
            var nomesAnimais = new string[4];
            var menorAltura = double.MaxValue;
            var menorAnimal = "";

            for (var i = 0; i < alturasAnimais.Length; i++)
            {
                var teste = false;

                while (teste == false)
                {
                    Console.Clear();
                    Console.Write("Informe o nome do animal: ");
                    var nome = Console.ReadLine().Trim();

                    if (nome.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome informado não é valido. Por favor informe um nome com no mínimo dois caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        nomesAnimais[i] = nome;
                        teste = true;
                    }
                }

                var altura = 0.0;

                while (altura <= 0.0)
                {
                    try
                    {
                        Console.Write($"Informe a altura do(a) {nomesAnimais[i]} em metros: ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        if (altura <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A altura informada não é valida. Por favor informe uma altura maior do que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            alturasAnimais[i] = altura;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A altura informada não é valida. Por favor informe uma altura maior do que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                if (altura < menorAltura)
                {
                    menorAltura = alturasAnimais[i];
                    menorAnimal = nomesAnimais[i];
                }
            }

            Console.Clear();
            Console.WriteLine($"O animal com a menor altura é o(a) {menorAnimal} e ele(a) tem {menorAltura} metros.");
        }
    }
}