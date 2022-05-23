using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetoresComplementares
{
    internal class Exercicio03
    {
        /* Criei um vetor e solicite 8 números. Crie outro vetor preenchendo ele da seguinte forma.
         * - Primeira posição do vetor 2 recebe a soma da última posição do vetor 1 e a primeira
         * posição do vetor 1.
         * - Segunda posição do vetor 2 recebe a soma da primeira posição do vetor 1 e a
         * segunda posição do vetor 1.
         * - E continua até terminar o preenchimento do vetor 2.
         */
        public void Executar()
        {
            Console.Clear();
            var numerosVetor1 = new double[8];            

            for (var i = 0; i < numerosVetor1.Length; i++)
            {
                var teste = false;
                while (teste == false)
                {
                    try
                    {
                        Console.Write("Informe um número: ");
                        var numero = Convert.ToDouble(Console.ReadLine());

                        numerosVetor1[i] = numero;
                        teste = true;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            var numerosVetor2 = new double[8];

            for (var i = 0; i < numerosVetor2.Length; i++)
            {
                if (i == 0)
                {
                    numerosVetor2[i] = numerosVetor1[numerosVetor2.Length - 1] + numerosVetor1[i];
                }
                else
                {
                    numerosVetor2[i] = numerosVetor1[i - 1] + numerosVetor1[i];
                }
            }

            Console.Clear();            
            var table = new ConsoleTable("Números no vetor 1", "Números no vetor 2");

            for (var i = 0; i < numerosVetor1.Length; i++)
            {
                table.AddRow(numerosVetor1[i], numerosVetor2[i]);
            }

            table.Write(Format.Alternative);
        }
    }
}
