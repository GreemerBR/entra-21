using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio10
    {
        /* Desenvolver um algoritmo que solicite a conta de luz, conta de água , valor da NET,
         * valor da Vivo, valor da Oi, valor do IPTU, valor do IPVA, valor do seguro do carro,
         * valor do seguro do jet ski, valor do seguro do avião, valor do seguro do iate.
         * Após solicitar as informações deve-se apresentar as seguintes informações:
         * ● Valor das contas de telefone;
         * ● Valor dos impostos;
         * ● Valor dos seguros;
         * ● Valor do restante das contas;
         * ● Valor total de todas as contas.
         */
        public void Executar()
        {
            Console.Write("Informe o valor da conta de luz: R$ ");
            double valorLuz = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor da conta de água: R$ ");
            double valorAgua = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor da conta da NET: R$ ");
            double valorNet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor da conta da Vivo: R$ ");
            double valorVivo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor da conta da Oi: R$ ");
            double valorOi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do IPTU: R$ ");
            double valorIptu = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do IPVA: R$ ");
            double valorIpva = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do seguro do carro: R$ ");
            double seguroCarro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do seguro do JetSki: R$ ");
            double seguroJetski = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do seguro do avião: R$ ");
            double seguroAviao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do seguro do iate: R$ ");
            double seguroIate = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double valorContasTelefone = valorNet + valorVivo + valorOi;
            double valorImpostos = valorIptu + valorIpva;
            double valorSeguros = seguroCarro + seguroJetski + seguroAviao + seguroIate;
            double valorRestante = valorLuz + valorAgua;
            double valorTotalContas = valorContasTelefone + valorImpostos + valorSeguros + valorRestante;

            Console.WriteLine("Valor das contas de telefone: R$ " + valorContasTelefone);
            Console.WriteLine("Valor dos impostos: R$ " + valorImpostos);
            Console.WriteLine("Valor dos seguros: R$ " + valorSeguros);
            Console.WriteLine("Valor do restante das constas: R$ " + valorRestante);
            Console.WriteLine("Valor total de todas as contas: R$ " + valorTotalContas);
        }
    }
}
