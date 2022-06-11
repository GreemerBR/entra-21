namespace Entra21.ExemplosOrientacaoObjetos.Carros
{
    internal class ExemploCarro
    {
        public void Executar()
        {
            // Instânciando um objeto da classe Carro
            // NomeClasse nomeObjeto = new NomeClasse();
            Carro carro = new Carro();
            carro.Modelo = "Opala";
            carro.ValorParcela = 200.00;
            carro.QuantidadeParcelas = 60;
            carro.TamanhoTanque = 82;
            carro.TotalParcialPercorrido = 400;
            carro.ValorFipe = 32_000;
            carro.AnoFabricacao = 2015;

            Console.WriteLine(
    "Carro velho: " + carro.VerificarSeCarroVelho() +
    "\nJuros abusivo: " + carro.ValidarQueValorJurosEhAbusivo() +
    "\nConsumo: " + carro.CalcularConsumo() +
    "\nTotal empréstimo: " + carro.CalcularValorTotalEmprestimo() +
    "\nCompra válida:  " + carro.ValidarCompraValida());
        }
    }
}
