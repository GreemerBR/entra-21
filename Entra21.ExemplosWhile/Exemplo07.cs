using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo07
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade desejada: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());
            int indice = 0;

            while (indice < quantidadeDesejada)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                indice = indice + 1;
            }
        }
    }
}
