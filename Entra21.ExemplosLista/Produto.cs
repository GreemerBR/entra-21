namespace Entra21.ExemplosListaObjetos
{
    internal class Produto
    {
        public int Codigo;
        public string Nome;
        public double PrecoUnitario;
        public int Quantidade;
        public ProdutoLocalizacao Localizacao;

        public double CalcularPrecoTotal()
        {
            var preco = Quantidade * PrecoUnitario;

            return preco;
        }
    }
}