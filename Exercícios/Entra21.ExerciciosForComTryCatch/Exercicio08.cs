using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio08
    {
        // Solicite um número e apresentar a tabuada do mesmo até 1000.
        public void Executar()
        {
            Console.Clear();
            var numero = 0.0;
            var teste = false;

            while (teste == false)
            {
                try
                {
                    Console.Write("Informe um número: ");
                    numero = Convert.ToDouble(Console.ReadLine());

                    teste = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por valor informe um número.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            Console.Clear();
            Console.WriteLine("---------- TABUADA DO " + numero + " ----------");

            for (var i = 0; i <= 1000; i++)
            {
                Console.WriteLine(i + " x " + numero + " = " + (i * numero));
            }

            Console.WriteLine();
        }
    }
}
