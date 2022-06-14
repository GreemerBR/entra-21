namespace Entra21.ExemplosOrientacaoObjetos.ExemplosDoCaderno
{
    internal class Galinha
    {
        // Propriedades
        public int QuantidadeOvo;
        public string Cor;
        public double Tamanho;
        public double Peso;

        // Método
        // retorno do tipo void quer dizer que o método não vai retornar nada
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public void BotarOvo()
        {
            QuantidadeOvo = QuantidadeOvo + 1;
        }
    }
}