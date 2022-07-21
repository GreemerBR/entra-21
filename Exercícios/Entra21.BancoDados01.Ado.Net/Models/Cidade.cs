namespace Entra21.BancoDados01.Ado.Net.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public UnidadeFederativa UnidadeFederativa { get; set; }
        public string Nome { get;  set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public double Pib { get; set; }

    }
}
