using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio07
    {
        /* Solicite um número para o usuário e após ele informar o número apresente a
         * tabuada desse número.Solicite um número para o usuário e após ele informar o número apresente a
         * tabuada desse número.
         */
        public void Executar()
        {
            Console.Write("Informe o número aoo qual deseja a tabuada: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(numero + " x 0 = " + (numero * 0).ToString("F"));
            Console.WriteLine(numero + " x 1 = " + (numero * 1).ToString("F"));
            Console.WriteLine(numero + " x 2 = " + (numero * 2).ToString("F"));
            Console.WriteLine(numero + " x 3 = " + (numero * 3).ToString("F"));
            Console.WriteLine(numero + " x 4 = " + (numero * 4).ToString("F"));
            Console.WriteLine(numero + " x 5 = " + (numero * 5).ToString("F"));
            Console.WriteLine(numero + " x 6 = " + (numero * 6).ToString("F"));
            Console.WriteLine(numero + " x 7 = " + (numero * 7).ToString("F"));
            Console.WriteLine(numero + " x 8 = " + (numero * 8).ToString("F"));
            Console.WriteLine(numero + " x 9 = " + (numero * 9).ToString("F"));
            Console.WriteLine(numero + " x 10 = " + (numero * 10).ToString("F"));


        }
    }
}
