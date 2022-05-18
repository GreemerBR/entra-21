using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosTryCatch
{
    internal class Exemplo02
    {
        public void Executar()
        {
            var numero = 0;
            var numeroValido = false;

            while (numeroValido == false)
            {
                try
                {
                    Console.Write("Número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    numeroValido = true;
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
