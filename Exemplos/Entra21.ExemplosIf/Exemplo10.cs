using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo10
    {
        public void Executar()
        {
            Console.Write("Digite o tamanho da camiseta: ");
            string tamanho = Console.ReadLine().ToUpper().Trim();

            Console.Write("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine().Trim());

            double valorUnitario = 0;

            if (quantidade < 3)
            {
                if ((tamanho == "PP") || (tamanho == "P") || (tamanho == "M"))
                {
                    valorUnitario = 39.90;
                }
                else if ((tamanho == "G") || (tamanho == "GG") || (tamanho == "XGG"))
                {
                    valorUnitario = 49.90;
                }
            }
            else
            {
                if ((tamanho == "G") || (tamanho == "GG") || (tamanho == "XGG"))
                {
                    valorUnitario = 39.90;
                }
                else if ((tamanho == "PP") || (tamanho == "P") || (tamanho == "M"))
                {
                    valorUnitario = 29.90;
                }
            }

            double total = valorUnitario * quantidade;
            Console.WriteLine("Total: R$ " + total);
        }
    }
}
