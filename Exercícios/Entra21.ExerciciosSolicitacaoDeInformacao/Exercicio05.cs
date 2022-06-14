using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio05
    {
        // Solicite um número para o usuário e apresente ao final seu antecessor e o sucessor
        public void Executar()
        {
            Console.Write("Informe um número: "); ;
            int numero = Convert.ToInt32(Console.ReadLine());

            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.Clear();
            Console.WriteLine("O número" + antecessor + " é o antecessor do número " + numero);
            Console.WriteLine("O número" + sucessor + " é o sucessor do número " + numero);
        }
    }
}
