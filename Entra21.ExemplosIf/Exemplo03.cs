using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosIf
{
    internal class Exemplo03
    {
        public void Executar()
        {
            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 5)
            {
                Console.WriteLine("Bebê");
            }
            else if (idade <= 12)
            {
                Console.WriteLine("Criança");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Adolescente");
            }

            else if (idade < 60)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idosos");
            }
        }
    }
}
