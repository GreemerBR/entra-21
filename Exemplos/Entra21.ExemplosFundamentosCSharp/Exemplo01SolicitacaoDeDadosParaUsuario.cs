using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class Exemplo01SolicitacaoDeDadosParaUsuario
    {
        public void Executar()
        {
            // Como solicitar informações para o usuário
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine("Nome completo: " + nomeCompleto);
        }
    }
}
