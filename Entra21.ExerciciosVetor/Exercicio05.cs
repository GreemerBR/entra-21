using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio05
    {
        //Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média dos pesos.
        public void Executar()
        {
            var pesos = new double[5];
            var somaPesos = 0.0;
            var mediaPesos = 0.0;

            for (var i = 0; i < pesos.Length; i++)
            {
                var peso = 0.0;

                while(peso <= 0.0)
                {
                    try
                    {
                        Console.Write("Informe o peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());

                        if (peso <= 0.0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O peso informado não é valido. Por favor informe um peso maior do que zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            pesos[i] = peso;
                            somaPesos = somaPesos + pesos[i];
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O peso informado não é valido. Por favor informe um peso maior do que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }                
            }

            mediaPesos = somaPesos / 5;

            Console.Clear();
            Console.WriteLine($"A soma total dos pesos é de {somaPesos.ToString("F")} Kg e a média dos pesos é de {mediaPesos.ToString("F")} Kg");
        }
    }
}
