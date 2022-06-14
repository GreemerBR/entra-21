namespace Entra21.ExemplosOrientacaoObjetos.Contas
{
    internal class ExemploConta
    {
        // Instânciando um objeto da classe Conta
        // NomeClasse nomeObjeto = new NomeClasse();
        Conta jose = new Conta();
        int opcaoDesejada = 0;

        public void Executar()
        {
            SolicitarInformacoesBasicas();
        }

        private void Menu()
        {
            while (opcaoDesejada != 9)
            {
                ApresentarSolicitarMenu();
            }
        }

        public void RealizarOperacao()
        {
            if (opcaoDesejada == 0)
            {
                jose.Sacar();
            }
            else if (opcaoDesejada == 1)
            {
                jose.Depositar();

            }
            else if (opcaoDesejada == 2)
            {
                jose.ApresentarExtrato();

            }
            else if (opcaoDesejada == 9)
            {
                Console.WriteLine("Obrigado por utilizar");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

            LimparTela();
        }

        private void LimparTela()
        {
            Thread.Sleep(2000); // delay
            Console.Clear();
        }

        private void SolicitarInformacoesBasicas()
        {
            Console.Write("Digite o seu nome: ");
            jose.Nome = Console.ReadLine();
            Console.Write("Digite o valor do seu saldo: ");
            jose.Saldo = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Menu();
        }

        public void ApresentarSolicitarMenu()
        {
            Console.Write(@"0 - Sacar
1 - Depositar
2 - Apresentar extrato
9 - Sair

Digite o menu desejado:");

            opcaoDesejada = Convert.ToInt32(Console.ReadLine());

            RealizarOperacao();
        }
    }
}
