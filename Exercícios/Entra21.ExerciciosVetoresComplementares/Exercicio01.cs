using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetoresComplementares
{
    internal class Exercicio01
    {
        /* Criar um vetor para armazenar 10 números, solicite os números e armazene. Será aceito
         * neste vetor somente números pares
         */
        public void Executar()
        {
            Console.Clear();
            var numerosPares = new int[10];
            
            for (var i = 0; i < numerosPares.Length;i++)
            {
                var numeroValido = false;

                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Informe um número: ");
                        var numero = Convert.ToInt32(Console.ReadLine());

                        if (numero <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O número informado é invalido. Por favor informe um número maior ou igual a zero.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            numeroValido = true;
                        }

                        if (numero % 2 == 0)
                        {
                            numerosPares[i] = numero;
                        }
                        else
                        {
                            numeroValido = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O número informado é invalido. Por favor informe um número maior ou igual a zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            Console.Clear();

            var table = new ConsoleTable("Este são os 10 números pares informados");
          
            for (var i = 0; i < numerosPares.Length; i++)
            {
                table.AddRow(numerosPares[i]);
            }

            table.Write(Format.Alternative);
        }
    }
}
