using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Alunos.TestesDeValidacaoDeInformacoes
{
    internal class MateriaFavoritaValida
    {
        public string ObterMateriaFavorita()
        {
            var materia = Console.ReadLine().Trim();
            var testeMateriaValida = false;

            while (testeMateriaValida == false)
            {
                if (materia.Length >= 5)
                {
                    testeMateriaValida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"O nome da matéria informado não é valido.
Por favor, informe um nome com no mínimo 5 caracteres.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe um novo nome: ");
                    materia = Console.ReadLine().Trim();
                }
            }

            return materia;
        }
    }
}
