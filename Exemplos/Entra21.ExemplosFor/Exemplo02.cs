using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo02
    {
        public void Executar()
        {
            int quantidadePessoasSc = 0;

            for (int i = 0; i < 10; i = i +1)
            {
                Console.Write("Digite o seu estado: ");
                string estado = Console.ReadLine().Trim().ToLower();

                if (estado == "sc" || estado == "santa catarina")
                {
                    quantidadePessoasSc = quantidadePessoasSc + 1;
                }
            }

            Console.WriteLine("Quantidade de pessoas de SC: " + quantidadePessoasSc);
        }
    }
}
