using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Alunos.TestesDeValidacaoDeInformacoes
{
    internal class IdadeAlunoValida
    {
        public int ObterIdade()
        {
            var idade = Convert.ToInt32(Console.ReadLine().Trim());
            var testeIdadeValida = false;

            while (testeIdadeValida == false)
            {
                if (idade >= 6 && idade <= 21)
                {
                    testeIdadeValida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"A idade informada não é valida.
Por favor, informe uma idade entre 6 e 21 anos.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe uma nova idade: ");
                    idade = Convert.ToInt32(Console.ReadLine().Trim());
                }
            }

            return idade;
        }
    }
}
