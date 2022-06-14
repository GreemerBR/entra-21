using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class ExemploCriacaoDeVariaveis
    {
        public void Executar()
        {
            // Criando variáveis e as utilizando
            string nomeCompleto = "Ana da Silva";
            int nota1 = 4;
            int nota2 = 2;
            int nota3 = 10;
            int soma = nota1 + nota2 + nota3;
            double media = soma / 3.0;

            Console.WriteLine("Nota 1: " + nota1);
            Console.WriteLine("Nota 2: " + nota2);
            Console.WriteLine("Nota 3: " + nota3);
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Nome Completo: " + nomeCompleto);
        }
    }
}
