using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio01
    {
        // Solicite o preço e nome da peça de 13 peças.
        public void Executar()
        {
            Console.Clear();

            var nomeTeste = false;
            var precoTeste = false;

            for (var i = 0; i < 13; i++)
            {
                while (nomeTeste == false)
                {
                    Console.Write("Informe o nome da peça: ");                        
                    var nomePeca = Console.ReadLine();

                    if (nomePeca.Length >= 2)
                    {
                        nomeTeste = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome da peça informado não é válido. Este deve ter ao menos dois caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                while (precoTeste == false)
                {
                    try
                    {
                        Console.Write("Informe o preço da peça: R$ ");
                        var precoPeca = Convert.ToDouble(Console.ReadLine());

                        if (precoPeca > 0.0)
                        {
                            precoTeste = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor da peça informado não é válido. Este deve ser maior do que R$ 0,00.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor da peça informado não é válido. Este deve ser um número maior do que R$ 0,00.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                nomeTeste = false;
                precoTeste = false;
            }

            Console.WriteLine();
        }
    }
}