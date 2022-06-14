namespace Entra21.ExemplosListaObjetos.Produtos
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        // Armazenar o código do próximo produto
        private int codigoAtual = 1;

        // Assinatura do método: composto por encapsulamento encapsulamento + tipoRetorno + NomeMetodo(parametros)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        // Tudo entre as {} é chamado de corpo do método
        {
            // Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            // Atribuir valor para as Propriedades com os dados passados como parâmetros
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            // Incrementar 1 no código atual para quando criar um novo produto o produto contenha outra código
            codigoAtual = codigoAtual + 1;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Obtém o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            // Verifica se não foi possível encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorna falso porque não existe produto com o código dos parâmetros
                return false;
            }

            // Atualiza as propriedade (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retorna verdadeiro porque foi possível alterar o produto
            return true;
        }

        public bool Apagar(int codigo)
        {
            for (var i = 0; i < produtos.Count; i++)
            {
                // Resgatando de uma lista de tipo primitivo
                // int numero = numeros[i];

                // Resgatando de uma lista de objetos
                Produto produto = produtos[i];

                if (produto.Codigo == codigo)
                {
                    // Posso remover com o indice do objeto
                    produtos.RemoveAt(i);

                    // Posso remover com o objeto desejado
                    // produtos.Remove(produto);

                    // Retorna verdadeiro porque o produto com o código desejado foi removido da lista
                    return true;
                }
            }
            // Retorna falso porque não foi encontrado produto com o código desejad, ou seja, nenhum elemento foi removido da lista
            return false;
        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto filtrndo por código
            for (var i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                // Verifica se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    // Retorna o produto encontrado
                    return produtoAtual;
                }
            }

            // Retorna o null, caso não encontre um produto com o código passado como parâmetro
            return null;
        }

        public Produto ObterMenorPrecoUnitario() // Parte nova
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            // Percorre a lista de produtos para obter o produto com o menor Preço Unitário
            for (var i = 0; i < produtos.Count; i++)
            {

                // Obtém o produto atual da lista que está sendo percorrida
                var produto = produtos[i];

                // Verifica se p produto atual ossui o menor preco unitário
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    // Armazena o produto unitário, pois é o menor preço unitário até o momento
                    menorPrecoUnitario = produto.PrecoUnitario;

                    // Armazena o produto para posteriormente saber qual é o produto com o menor preço unitário
                    produtoMenorPrecoUnitario = produto;
                }
            }

            return produtoMenorPrecoUnitario;
        }

        public List<double> ObterTodosPrecos() // Parte nova 2
        {
            // Criar uma lista de preços totais
            var precos = new List<double>();

            // Percorre todos os produtos
            for (var i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Adiciona o preço total na lista de preços
                precos.Add(produto.CalcularPrecoTotal());
            }

            return precos;
        }

        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao) // Parte nova 3
        {
            // Cria uma lista de preços totais
            var precos = new List<double>();

            // Percorre totos os produtos
            for (var i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Verifica se a localização do produto atual é a localização passada no parâmetro
                if (produto.Localizacao == localizacao)
                {
                    // Adiciona o preço total do produto atual que foi filtrado por localização
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public List<double> ObterPrecosTotaisDoArmazem() // Parte nova 4
        {
            // Cria uma lista de preços totais
            var precos = new List<double>();

            // Percorre totos os produtos
            for (var i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Verifica se a localização do produto atual é o Armazem
                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    // Adiciona o preço total do produto atual que foi filtrado por localização por armazém
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public double ObterMediaPrecosTotais() // Parte nova 5
        {
            var somaPrecosTotais = 0.0;

            // Percorre totos os produtos
            for (var i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Adiciona o preço total do produto na variável soma de preços totais
                somaPrecosTotais += produto.CalcularPrecoTotal();
            }

            // Calcula a média de acordo com a quantidade de produtos
            var media = somaPrecosTotais / produtos.Count;

            return media;
        }
    }
}