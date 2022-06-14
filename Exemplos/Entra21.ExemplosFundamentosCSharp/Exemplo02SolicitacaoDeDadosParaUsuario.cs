using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class Exemplo02SolicitacaoDeDadosParaUsuario
    {
        public void Executar()
        {
            // Solicitando dados
            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            // Para limpar a tela
            Console.Clear();

            // Apresentando os dados
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Valor: " + valor);

            // Solcitar a quantidade e o valor hora para o usuário e apresentar ao final o salário bruto

            // Imput - Entrada de dados solicitados ao usuário
            Console.Write("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            // Processamento dos dados
            double salarioBruto = quantidade * valorHora;

            // Output - Saída dos dados processados ao usuário
            Console.Clear();
            Console.WriteLine("Salário bruto: " + salarioBruto);
        }
    }
}
