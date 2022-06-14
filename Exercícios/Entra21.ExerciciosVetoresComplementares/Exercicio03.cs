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
            var numerosDesordenados = new double[8];            

            for (var i = 0; i < numerosDesordenados.Length; i++)
            {
                var numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Informe um número: ");
                        var numero = Convert.ToDouble(Console.ReadLine());

                        numerosDesordenados[i] = numero;
                        numeroValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            var numerosOrdenados = new double[8];

            for (var i = 0; i < numerosOrdenados.Length; i++)
            {
                if (i == 0)
                {
                    numerosOrdenados[i] = numerosDesordenados[numerosOrdenados.Length - 1] + numerosDesordenados[i];
                }
                else
                {
                    numerosOrdenados[i] = numerosDesordenados[i - 1] + numerosDesordenados[i];
                }
            }

            Console.Clear();            
            var table = new ConsoleTable("Números no vetor 1", "Números no vetor 2");

            for (var i = 0; i < numerosDesordenados.Length; i++)
            {
                table.AddRow(numerosDesordenados[i], numerosOrdenados[i]);
            }

            table.Write(Format.Alternative);
        }
    }
}
