using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo06
    {
        public void Executar()
        {
            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            string classificacao = "";

            if ((idade >= 0) && (idade <= 4))
            {
                classificacao = "Bebê";
            }
            else if ((idade >= 5) && (idade <= 11))
            {
                classificacao = "Criança";
            }
            else if ((idade >= 12) && (idade <= 17))
            {
                classificacao = "Adolescente";
            }
            else
            {
                Console.WriteLine("Adulto");
            }

            Console.WriteLine("Você é um " + classificacao);
        }
    }
}
