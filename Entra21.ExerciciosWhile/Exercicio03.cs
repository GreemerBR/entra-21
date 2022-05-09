using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio03
    {
        // Solicite a idade para o usuário até que ele digite uma idade maior que 128.
        public void Executar()
        {
            int idade = 0;

            while (idade <= 128)
            {
                Console.Write("Informe uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
