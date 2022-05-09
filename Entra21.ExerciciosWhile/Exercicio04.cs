using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio04
    {
        /* Solicite o peso para o usuário até que o peso seja menor que 0 ou maior que
         * 300,00. Apresentar ao final a quantidade de pessoas que informaram o peso
         */
        public void Executar()
        {
            double peso = 0;
            int contador = 0;

            while ((peso >= 0) && (peso <= 300.00))
            {
                Console.Write("Informe seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                contador = contador + 1;
            }

            Console.WriteLine();
            Console.Write(contador + " pessoas informaram seus pesos.");
        }
    }
}