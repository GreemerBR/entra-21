using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio04
    {
        /* Solicitar dois números inteiros e apresentar:
         * a. A soma dos valores;
         * b. A subtração dos valores;
         * c. A multiplicação dos valores;
         * d. A divisão dos valores.
         */
        public void Executar()
        {
            Console.WriteLine("POr favor informe dois número inteiros.");
            Console.Write("1°: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2°: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int soma = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
            int divisao = numero1 / numero2;

            Console.Clear();                                      
            Console.WriteLine("A soma destes valores é: " + soma);
            Console.WriteLine("A subtração destes valores é: " + subtracao);
            Console.WriteLine("A multiplicação destes valores é: " + multiplicacao);
            Console.WriteLine("A divisão destes valores é: " + divisao);
        }
    }
}
