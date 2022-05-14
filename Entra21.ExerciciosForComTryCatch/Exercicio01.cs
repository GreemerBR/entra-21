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

            var nomePeca = "";
            var precoPeca = 0.0;

            for (var i = 0; i < 13; i++)
            {
                while (nomePeca.Length < 2)
                {
                    try
                    {
                        Console.Write("Informe o nome da peça: ");
                        nomePeca = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome da peça informado não é válido. Este deve ter ao menos dois caracteres.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    nomePeca = "";
                }
                
                while (precoPeca <= 0.0)
                {
                    try
                    {
                        Console.Write("Informe o preço da peça: R$ ");
                        precoPeca = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor da peça informado não é válido. Este deve ser maior do que R$ 0,00.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    precoPeca = 0.0;
                }
                
            }
        }
    }
}
