using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio02
    {
        // Solicite o nome e sobrenome e apresente o nome completo
        public void Executar()
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Seu nome completo é: " + nome + sobrenome);
        }
    }
}
