namespace Entra21.ExemplosListaObjetos.ExemploCaderno
{
    internal class ExecutarProduto
    {
        public void Executar()
        {
            List<ExemploProduto> produtos = new List<ExemploProduto>();

            ExemploProduto produto1 = new ExemploProduto();
            produto1.Nome = "Café";
            produto1.Preco = 2.50;
            produtos.Add(produto1); // Índice 0

            ExemploProduto produto2 = new ExemploProduto();
            produto2.Nome = "Leite";
            produto2.Preco = 3.10;
            produtos.Add(produto2); // Índice 1

            // Outra forma de fazer
            produtos.Add(new ExemploProduto()); // Índice 2, por isso o [2]
            produtos[2].Nome = "Nescau";
            produtos[2].Preco = 5.50;

            // Como alterar registro em uma lista
            string nomeAlterar = "Leite";

            for (var i = 0; i < produtos.Count; i++)
            {
                ExemploProduto produtoAtual = produtos[i];

                if (produtoAtual.Nome == nomeAlterar)
                {
                    Console.Write("Nome novo: ");
                    produtoAtual.Nome = Console.ReadLine().Trim();
                    Console.Write("Preço novo: R$");
                    produtoAtual.Preco = Convert.ToDouble(Console.ReadLine().Trim());
                }
            }

            // Como apagar registro em uma lista
            string nomeApagar = "Leite";

            for (var i = 0; i < produtos.Count; i++)
            {
                ExemploProduto produtoAtual = produtos[i];

                if (produtoAtual.Nome == nomeApagar)
                {
                    produtos.Remove(produtoAtual);
                }
            }

            // Como apresentar registro de uma lista
            for (var i = 0; i < produtos.Count; i++)
            {
                ExemploProduto produtoAtual = produtos[i];

                Console.WriteLine($@"Nome: {produtoAtual.Nome} Preço: R${produtoAtual.Preco.ToString("F")}");
            }
        }
    }
}
