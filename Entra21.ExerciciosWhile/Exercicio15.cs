using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio15
    {
        /* Solicite ao usuário um texto e utilizando o while apresente caracter por caracter.
         * Exemplo:
         * Texto: Lorem ipsum da Silva
         */
        public void Executar()
        {
            Console.Write("Informe um texto: ");
            string texto = Console.ReadLine();
            
            int contador = 0;

            while (contador < texto.Length)
            {
                char caracter = Convert.ToChar(texto.Substring(contador, 1));
                Console.WriteLine(caracter);

                contador = contador + 1;
            }
        }
    }
}
