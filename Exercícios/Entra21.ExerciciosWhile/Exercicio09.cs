using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        // Solicite um número e faça o fatorial deste número, utilizando while.
        public void Executar()
        {
            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int indice = numero;
            int auxiliar = numero;

            while (indice > 1)
            {
                indice = indice - 1;
                numero = numero * indice;
                
            }

            Console.WriteLine("O fatorial de " + auxiliar + " é: " + numero);
        }
    }
}