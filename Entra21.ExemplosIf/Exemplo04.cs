using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo04
    {
        public void Executar()
        {
            Console.Write("Digite a categoria: ");
            string categoria = Console.ReadLine().ToLower().Trim();

            if (categoria == "moba")
            {
                Console.WriteLine("Jogador de moba");
            }
            else if (categoria == "rpg")
            {
                Console.WriteLine("Jogador de rpg");
            }
            else if (categoria == "rpg de mesa")
            {
                Console.WriteLine("Jogador de rpg de mesa");
            }
            else
            {
                Console.WriteLine("Jogador de outras categorias");
            }
        }
    }
}
