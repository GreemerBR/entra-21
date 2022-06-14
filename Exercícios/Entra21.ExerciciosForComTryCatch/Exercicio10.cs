using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio10
    {
        /* Solicite um número e apresente:
         * ● Os 50 números antecessores pares;        
         * ● Os 50 números sucessores ímpares.
         */
        public void Executar()
        {
            Console.Clear();
            var numero = 0;
            var aux = 0;
            var teste = false;

            while (teste == false)
            {
                try
                {
                    Console.Write("Informe um número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    aux = numero;
                    teste = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por valor informe um número inteiro maior que zero.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine("Os 50 números pares antecessores ao " + aux + " são: ");

                for (var i = 0; i < 50; i++)
                {
                    numero = numero - 2;
                    Console.Write(numero + " ");
                }

                numero = aux - 1;
                
                Console.WriteLine("\n" +
                    "E os 50 números impares sucessores ao " + aux + " são: ");
                for (var i = 0; i < 50; i++)
                {
                    numero = numero + 2;
                    Console.Write(numero + " ");
                }
            }
            else
            {
                numero = aux + 1;

                Console.WriteLine("Os 50 números pares antecessores ao " + aux + " são: ");
                for (var i = 0; i < 50; i++)
                {
                    numero = numero - 2;
                    Console.Write(numero + " ");
                }

                numero = aux;

                Console.WriteLine("\n" +
                    "E os 50 números impares sucessores ao " + aux + " são: ");
                for (var i = 0; i < 50; i++)
                {
                    numero = numero + 2;
                    Console.Write(numero + " ");
                }
            }

            Console.WriteLine();
        }
    }
}