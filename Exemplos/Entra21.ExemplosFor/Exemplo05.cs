using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo05
    {
        public void Executar()
        {
            Console.Write("Quantidade de carros: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            double somaPreco = 0;

            for (int i = 0; i < quantidadeCarros; i++)
            {
                Console.Write("Marca: ");
                string marca = Console.ReadLine().Trim();

                Console.Write("Preço: R$ ");
                double preco = Convert.ToDouble(Console.ReadLine());

                somaPreco = somaPreco + preco;
            }

            Console.WriteLine("Soma dos preços: R$ " + somaPreco);
        }
    }
}
