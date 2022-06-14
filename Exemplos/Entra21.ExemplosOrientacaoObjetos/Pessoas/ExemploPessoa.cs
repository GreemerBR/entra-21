namespace Entra21.ExemplosOrientacaoObjetos.Pessoas
{
    internal class ExemploPessoa
    {
        public void Executar()
        {
            // Instânciando um objeto da classe Pessoa
            // NomeClasse nomeObjeto = new NomeClasse();
            var claudinho = new Pessoa();
            claudinho.Nome = "Claudinho";
            claudinho.Altura = 2.03;
            claudinho.Peso = 98;


            claudinho.CalcularImc();
            claudinho.ApresentarImc();
        }
    }
}
