using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        /* Solicite para o usuário dois números. Apresente o seguinte menu e de acordo com a
         * escolha deve ser apresentado a operação aritmética, isto deve ocorrer até que o
         * mesmo escolha a opção de sair
         */            
        public void Executar()
        {
            Console.Write("Informe o primeiro número: ");
            double numero01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            double numero02 = Convert.ToDouble(Console.ReadLine());

            int opcaoDesejada = 0;

            while (opcaoDesejada < 5)
            {

                Console.Write(@"
-------------MENU-------------
 1 - Somar
 2 - Subtrair
 3 - Multiplicar
 4 - Dividir
 5 - Sair
");
                Console.Write("\nPor favor infome a opção desejada: ");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                if (opcaoDesejada == 1)
                {
                    Console.Write("\n" + numero01 + " + " + numero02 + " = " + (numero01 + numero02).ToString("F") + "\n");
                }
                else if (opcaoDesejada == 2)
                {
                    Console.Write("\n" + numero01 + " - " + numero02 + " = " + (numero01 - numero02).ToString("F") + "\n");
                }
                else if (opcaoDesejada == 3)
                {
                    Console.Write("\n" + numero01 + " * " + numero02 + " = " + (numero01 * numero02).ToString("F") + "\n");
                }
                else if (opcaoDesejada == 4)
                {
                    Console.Write("\n" + numero01 + " / " + numero02 + " = " + (numero01 / numero02).ToString("F") + "\n");
                }
                else if (opcaoDesejada == 5)
                {
                }
                else
                {
                    opcaoDesejada = 0;
                }

            }
        }
    }
}