using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo02
    {
        public void Executar()
        {
            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            double valorIngresso = 50;

            if (idade >= 60)
            {
                valorIngresso = valorIngresso / 2;
            }

            Console.WriteLine("Valor do ingresso: R$ " + valorIngresso);
        }
    }
}
