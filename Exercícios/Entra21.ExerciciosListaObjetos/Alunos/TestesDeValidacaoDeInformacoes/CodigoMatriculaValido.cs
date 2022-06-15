using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Alunos.TestesDeValidacaoDeInformacoes
{
    internal class CodigoMatriculaValido
    {
        public int ObterCodigoMatriculaValido()
        {
            var alunoServico = new AlunoServico();

            var codigoMatricula = Convert.ToInt32(Console.ReadLine().Trim());
            var testeIdadeValida = false;

            while (testeIdadeValida == false)
            {
                if (codigoMatricula >= 1)
                {
                    testeIdadeValida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"O código de matrícula informada não é valida.
Por favor, informe um código válido, ele é um número positivo maior que zero e se encontra ao lado do nome.");
                    Console.ForegroundColor = ConsoleColor.Green;

                    var alunos = alunoServico.ObterTodos();

                    for (var i = 0; i < alunos.Count; i++)
                    {
                        var alunoAtual = alunos[i];
                        Console.WriteLine($"Nome: {alunoAtual.Nome} - Código de matrícula: {alunoAtual.CodigoMatricula}");
                    }
                    Console.Write(@"
Informe um novo código de matrícula: ");
                    codigoMatricula = Convert.ToInt32(Console.ReadLine().Trim());
                }
            }

            return codigoMatricula;
        }
    }
}
