using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class ExemploSubstituicaoConcatenacaoVariavel
    {
        public void Executar()
        {
            // para criar uma variável
            // tipo + nomeVariavel = valor;
            string nome = "Francisco";
            Console.WriteLine("Nome: " + nome); // Vai apresentar -> Nome: Francisco

            // Substituição do valor da variável
            nome = "Paulo";
            Console.WriteLine("Nome: " + nome); // Vai apresentar -> Nome: Paulo

            // Concatenação da viariável nome com o texto " da Silva"
            nome = nome + " da Silva";
            Console.WriteLine("Nome: " + nome); // Vai apresentar -> Nome: Paulo da Silva
        }
    }
}
