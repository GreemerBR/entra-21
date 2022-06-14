using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class ExemploComoConverterStringsParaOutroTipo
    {
        public void Executar()
        {
            // Como converter string para int
            int numero1 = Convert.ToInt32("10");
            int numero2 = Convert.ToInt32("8001");

            int soma = numero1 + numero2;
            Console.WriteLine("Soma: " + soma);

            // Como converter string para double
            double valor = Convert.ToDouble("2,30");

            // Como converter string para boll
            bool vivo = Convert.ToBoolean("Verdadeiro");
        }
    }
}
