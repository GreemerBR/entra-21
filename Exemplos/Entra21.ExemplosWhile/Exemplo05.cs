using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo05
    {
        public void Executar()
        {
            int somaIdades = 0, indice = 0;
            double maiorIdade = double.MinValue, menorIdade = double.MaxValue;

            while (indice <= 2)
            {
                int idade = Convert.ToInt32(Console.ReadLine());
                somaIdades = somaIdades + idade;

                indice = indice + 1;

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                if (idade < maiorIdade)
                {
                    menorIdade = idade;
                }
            }

            double mediaIdade = somaIdades / indice;
            Console.WriteLine("Média das idade: " + mediaIdade +
                "\nMenor idade: " + menorIdade +
                "\nMaior idade: " + maiorIdade);
        }
    }
}
