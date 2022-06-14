namespace Entra21.ExemplosListaObjetos.Produtos
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            // Repete enquanto o código não for o menu sair (6)
            while (codigo != 6)
            {
                Console.Clear();

                //Aoresenta o menu e solicita o código
                codigo = ApresentarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    // Menu escolhido para listar produtos
                    ApresentarProdutos();
                }

                if (codigo == 2)
                {
                    // Menu escolhido para cadastrar produtos
                    Cadastrar();
                }

                if (codigo == 3)
                {
                    // Menu escolhido para editar produtos
                    Editar();
                }

                if (codigo == 4)
                {
                    // Menu escolhido para apagar produtos
                    Apagar();
                }

                if (codigo == 5)
                {
                    // Menu escolhido para apresentar produto desejado
                    ApresentarProduto();
                }

                if (codigo != 6)
                {
                    Console.WriteLine(@"
Aperte alguma tecla para continuar.");
                    Console.ReadKey();
                }
            }
        }

        private int ApresentarMenu()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
-------------MENU-------------
1 - Listar todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 - SAIR
");

            int codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;

            // Continua solicitndo o código até que seja um código entre 1 e 6
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite a opção desejada: ");
                    codigo = Convert.ToInt32(Console.ReadLine().Trim());

                    if (codigo < 1 || codigo > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
A opção informada não é válida. Por favor informe um número presente no MENU.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Digite a opção desejada: ");
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"
A opção informada não é válida. Por favor informe um número presente no MENU.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Digite a opção desejada: ");
                }
            }

            return codigo;
        }

        private void Cadastrar()
        {
            Console.Write("Nome do produto: ");
            var nome = Console.ReadLine().Trim();

            Console.Write("Quantidade do produto: ");
            var quantidade = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Preço unitário do produto: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine(@"
Localizações disponíveis:
- Armazem
- Area Venda
- Loja
");
            Console.Write("Localização do produto: ");
            var localizacao = Console.ReadLine().Trim();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }

        private void Editar()
        {
            ApresentarProdutos();

            Console.Write("Digite o código produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Nome: ");
            var nome = Console.ReadLine().Trim();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine(@"
Localizações disponíveis:
- Armazem
- Area Venda
- Loja
");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine().Trim();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine(@"
Código digitado não existe.");
            }
            else
            {
                Console.WriteLine(@"
Produto alterado com sucesso.");
            }
        }

        private void Apagar()
        {
            ApresentarProdutos();

            Console.Write("Digite o código produto desejado para apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine().Trim());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum produto cadastrado com o código informado");
        }

        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }

        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine(@"
Nenhum produto cadastrado.");

                // Para a execução deste método
                return;
            }

            Console.WriteLine("Lista de Produtos:");

            for (var i = 0; i < produtos.Count(); i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine($@"Código {produtoAtual.Codigo}
Nome: {produtoAtual.Nome}
");
            }
        }

        private void ApresentarProduto()
        {
            ApresentarProdutos();

            Console.Write("Digite o código do produto a ser detalhado: ");
            var codigo = Convert.ToInt32(Console.ReadLine().Trim());

            var produto = produtoServico.ObterPorCodigo(codigo);

            // Verifica se o produto não está cadastrado na lista de produto
            if (produto == null)
            {
                Console.WriteLine(@"
Produto não cadastrado.");

                return;
            }

            Console.Clear();
            Console.WriteLine($@"Código {produto.Codigo}
Nome: {produto.Nome}
Preço unitário: R${produto.PrecoUnitario}
Quantidade: {produto.Quantidade}
Total: R${produto.CalcularPrecoTotal()}");
        }
    }
}