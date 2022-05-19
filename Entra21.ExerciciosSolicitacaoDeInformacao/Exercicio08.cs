using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio08
    {
        /* Desenvolver um algoritmo que solicite quatro notas e apresente a média ao final.
         * Exemplo:
         * Nota 01: 9,75
         * Nota 02: 10,00
         * Nota 03: 4,42
         * Nota 04: 5,00
         * Média: 7,2925
         */
        public void Executar()
        {
            Console.Write("Informe a Nota 01: ");
            double nota01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a Nota 02: ");
            double nota02 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a Nota 03: ");
            double nota03 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a Nota 04: ");
            double nota04 = Convert.ToDouble(Console.ReadLine());

            double mediaNotas = (nota01 + nota02 + nota03 + nota04) / 4;

            Console.Clear();
            Console.WriteLine("A media das quatros notas apresentadas é de: " + mediaNotas);
        }
    }
}
