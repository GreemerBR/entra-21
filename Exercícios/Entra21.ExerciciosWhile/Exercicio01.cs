using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        // Solicite o preço e nome da peça de 13 peças.
        public void Executar()
        {            
            int indice = 0;
            string nomeProduto = "";
            double precoProduto = 0.00;

            while (indice < 13)
            {
                Console.Write("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Informe o preço do produto: R$ ");
                precoProduto = Convert.ToDouble(Console.ReadLine());

                indice = indice + 1;
            }
        }
    }
}