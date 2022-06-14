using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    //Classe => PascalCase
    internal class Exemplo01
    {
        //Método => PascalCase
        public void Executar()
        {
            int indice = 0;

            while (indice < 3)
            {
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                indice = indice + 1;
            }
        }
    }
}
