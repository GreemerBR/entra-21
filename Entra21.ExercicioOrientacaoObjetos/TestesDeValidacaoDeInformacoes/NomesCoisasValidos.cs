using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.TestesDeValidacaoDeInformacoes
{
    public class NomesCoisasValidos
    {
        public string ObterNome()
        {
            var nome = Console.ReadLine().Trim();
            var testeNomeValido = false;

            while (testeNomeValido == false)
            {
                if (nome.Length >= 2)
                {
                    testeNomeValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O nome informado não é valido. Por favor informe um nome com no mínimo 2 caracteres.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe um novo nome: ");
                    nome = Console.ReadLine().Trim();
                }
            }

            return nome;
        }
    }
}