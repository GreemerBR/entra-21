namespace Entra21.BancoDados01.Ado.Net.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public int IdUnidadeFederativa { get; set; }
        public string Nome { get; private set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public double PIB { get; set; }

    }
}
