using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio12
    {
        // Solicite o ano de nascimento do usuário e apresente ao final a idade do mesmo
        public void Executar()
        {
            Console.Write("Informe o ano de seu nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sua idade é de: " + (DateTime.Now.Year - anoNascimento) + " anos.");
        }
    }
}
