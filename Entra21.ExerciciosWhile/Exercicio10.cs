using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
        /*Solicite um número e apresente:
        ● Os 50 números antecessores pares;
        ● Os 50 números sucessores ímpares.*/
        public void Executar()
        {
            Console.Clear();
            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int aux = numero;

            int indice = 0;

            if (numero % 2 ==0 && numero != 0)
            {
                Console.WriteLine("Seus 50 números antecessores pares são: ");
                while (numero > 0 && indice < 50)
                {
                    numero = numero - 2;
                    Console.Write(numero + " ");
                    indice = indice + 1;
                }

                numero = numero - 1;
                indice = 0;

                Console.WriteLine("");
                Console.WriteLine("E seus 50 números sucessores impares são: ");
                while (indice < 50)
                {
                    numero = numero + 2;
                    Console.Write(numero + " ");
                    indice = indice + 1;
                }

            }

            else ()
            {

            }

            
        }
    }
}
