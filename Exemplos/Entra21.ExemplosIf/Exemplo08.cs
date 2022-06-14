using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo08
    {
        public void Executar()
        {
            bool estudante = true;
            bool idoso = true;
            double valorIngresso = 22;

            if ((estudante == true) || (idoso == true))
            {
                double desconto = valorIngresso / 2;
                valorIngresso = valorIngresso - desconto;
            }

            Console.WriteLine("Valor ingresso: R$ " + valorIngresso);
        }
    }
}
