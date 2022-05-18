using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo04
    {
        public void Executar()
        {
            for (int i = 0; i < 10; i = i + 1)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine().Trim();

                while (nome.Length < 5)
                {
                    Console.Write("Nome deve conter no mínimmo 5 caracteres");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine().Trim();
                }

                Console.Write("Salário: R$ ");
                double salario = Convert.ToDouble(Console.ReadLine());


                while (salario < 0)
                {
                    Console.Write("Salário não pode ser negativo");
                    Console.Write("Salário: R$ ");
                    salario = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
