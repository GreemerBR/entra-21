using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo09
    {
        public void Executar()
        {
            Console.Write("Nome do jogo: ");
            string nomeJogo = Console.ReadLine().ToLower().Trim();

            if((nomeJogo == "valorant") || (nomeJogo == "cs go") || (nomeJogo == "lol") || (nomeJogo == "league of legends"))
            {
                Console.WriteLine("Jodo de eSports");
            }
            else
            {
                Console.WriteLine("Outra categoria de jogo");
            }
        }
    }
}
