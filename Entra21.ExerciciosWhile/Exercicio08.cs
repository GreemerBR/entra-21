using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        // Solicite um número e apresentar a tabuada do mesmo até 1000.
        public void Executar()
        {
            Console.Write("Informe o número desejado: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            int indice = 0;

            while (indice <= 1000)
            {
                double resultado = numero * indice;
                Console.WriteLine(numero + " * " + indice + " = " + resultado);

                indice = indice + 1;
            }
        }
    }
}