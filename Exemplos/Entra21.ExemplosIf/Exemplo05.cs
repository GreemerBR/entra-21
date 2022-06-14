using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo05
    {
        public void Executar()
        {
            Console.Write("Digite o nome do jogo: ");
            string nomeJogo = Console.ReadLine().ToUpper().Trim();

            if (nomeJogo != "MINECRAFT")
            {
                Console.WriteLine("Criado em unit");
            }
            else
            {
                Console.WriteLine("Minecraft foi criado inicialmente em Java");
            }
        }
    }
}
