using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio11
    {
        /* Solicite dois números e inverta os valores destas variáveis.
         * Exemplo:
         * número 1: 29
         * número 2: 32
         * Após a inversão a variável número 1 terá o valor 32 e a variável número 2 terá o valor 29
         */
        public void Executar()
        {
            Console.Write("Informe um número: ");
            double numero01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe um novo número: ");
            double numero02 = Convert.ToDouble(Console.ReadLine());

            numero01 = numero01 + numero02;
            numero02 = numero01 - numero02;
            numero01 = numero01 - numero02;

            Console.WriteLine(numero01);
            Console.WriteLine(numero02);
        }
    }
}
