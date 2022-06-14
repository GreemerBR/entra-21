using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02
    {
        // Solicite nomes ao usuário até que o mesmo digite fim para o nome.
        public void Executar()
        {
            string nome = "";

            while (nome != "fim")
            {
                Console.Write("Informe o nome: ");
                nome = Console.ReadLine().ToLower().Trim();
            }
        }
    }
}