using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio03
    {
        /* Solicite a altura e peso e apresente o IMC desta pessoa.
         * Fórmula IMC: peso / altura ²
         */
        public void Executar()
        {
            Console.Write("Informe sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.Clear();
            Console.WriteLine("Seu imc é de: " + imc);
        }
    }
}
