using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosTryCatch
{
    internal class Exemplo01
    {
        public void Executar()
        {
            var numero = 0;

            while (numero <= 0 || numero > 30)
            {
                try
                {
                    Console.Write("Número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < 0)
                    {
                        Console.WriteLine("Número não pode ser negativo.");
                    }
                    else if (numero > 30)
                    {
                        Console.WriteLine("Númmero não pode ser mmaior que 30.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor digitado não é um número inteiro valido.");
                }
            }

            Console.WriteLine("TEXTO");
        }
    }
}
