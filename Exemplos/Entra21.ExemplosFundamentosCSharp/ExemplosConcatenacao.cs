using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class ExemplosConcatenacao
    {
        public void Executar()
        {
            // O + fora das "" é uma concatenação
            Console.WriteLine("Olá mundo");
            Console.WriteLine("Soma: 2 + 2");
            Console.WriteLine("Soma: " + 2 + 2);
            Console.WriteLine("Soma: " + (2 + 2));
            Console.WriteLine("Subtração: " + (2 - 2));
            Console.WriteLine("Multiplicação: " + (2 * 2));
            Console.WriteLine("Divisão: " + (2 / 2));
            Console.WriteLine("Resto da divisão: " + (2 % 2));
        }
    }
}