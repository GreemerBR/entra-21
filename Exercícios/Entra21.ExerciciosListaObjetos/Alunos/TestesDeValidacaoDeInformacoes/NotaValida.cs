using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Alunos.TestesDeValidacaoDeInformacoes
{
    internal class NotaValida
    {
        public double ObterNota()
        {
            var nota = Convert.ToDouble(Console.ReadLine().Trim());
            var testeIdadeValida = false;

            while (testeIdadeValida == false)
            {
                if (nota >= 0 && nota <= 10)
                {
                    testeIdadeValida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"A nota informada não é valida.
Por favor, informe uma nota entre 0 e 10.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe uma nova nota: ");
                    nota = Convert.ToDouble(Console.ReadLine().Trim());
                }
            }

            return nota;
        }
    }
}
