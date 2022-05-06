using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo04
    {
        public void Executar()
        {
            string texto = "", nome = "";
            
            while (nome != "fim")
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                texto = texto + nome + "\n";
            }
        }
    }
}
