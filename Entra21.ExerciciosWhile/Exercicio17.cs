using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio17
    {
        /* Faça um temporizador começando com 23:59:59 até 00:00:00.
         * Exemplo:
         * 23:59:59
         * 23:59:58
         * 23:59:57
         * ………...
         * 23:59:00
         * 23:58:59
         * …………
         * 23:00:01
         * 23:00:00
         * 22:59:59
         * …………
         * 00:00:02
         * 00:00:01
         * 00:00:00
         */
        public void Executar()
        {
            int contador = 0;
            DateTime temporizador = new DateTime(2022, 5, 17, 0, 0, 0);

            while (contador < 86400)
            {
                temporizador = temporizador.AddSeconds(-1);
                Console.WriteLine(temporizador.ToString("HH:mm:ss"));
                contador = contador + 1;
            }
        }
    }
}