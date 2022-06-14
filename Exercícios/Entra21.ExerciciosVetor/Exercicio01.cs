using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio01
    {
        /* Crie um vetor para guardar 16 números inteiros.
         * Preencha todas as posições com números e apresente a soma destes números.
         */
        public void Executar()
        {
            var numeros = new int[16];
            var soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                var numero = 0;
                var teste = false;

                while(teste == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Informe um número inteiro: ");
                        numero = Convert.ToInt32(Console.ReadLine().Trim());

                        teste = true;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor informado não é valido. Por favor informe um número inteiro.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                numeros[i] = numero;
                soma = soma + numeros[i];
            }

            Console.Clear();
            Console.WriteLine($"A soma dos números informados é {soma}");
        }
    }
}
