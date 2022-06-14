namespace Entra21.ExemplosOrientacaoObjetos.Carros
{
    public class Carro
    {
        // Propriedas
        public string Modelo;
        public double ValorFipe, ValorParcela;
        public int QuantidadeParcelas, AnoFabricacao, TotalParcialPercorrido, TamanhoTanque;

        // Método
        // retorno do tipo double quer dizer que o método vai retornar um double => é um método com retorno
        // métodos com retorno precisam conter um, ou mais, RETURN dentro de seu escopo
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public double CalcularValorTotalEmprestimo()
        {
            var valorEmprestimo = (QuantidadeParcelas * ValorParcela) + 30;

            return valorEmprestimo;
        }

        // retorno do tipo double quer dizer que o método vai retornar um double => é um método com retorno
        // métodos com retorno precisam conter um, ou mais, RETURN dentro de seu escopo
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public double CalcularJuros()
        {
            var valorTotalEmprestimo = CalcularValorTotalEmprestimo();
            var valorJuros = 0.0;

            if (valorTotalEmprestimo - ValorFipe >= 0)
            {
                valorJuros = valorTotalEmprestimo - ValorFipe;
            }

            return valorJuros;
        }

        // retorno do tipo double quer dizer que o método vai retornar um double => é um método com retorno
        // métodos com retorno precisam conter um, ou mais, RETURN dentro de seu escopo
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public double CalcularConsumo()
        {
            return TotalParcialPercorrido / Convert.ToDouble(TamanhoTanque);
        }

        // retorno do tipo bool quer dizer que o método vai retornar um boolean => é um método com retorno
        // métodos com retorno precisam conter um, ou mais, RETURN dentro de seu escopo
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public bool VerificarSeCarroVelho()
        {
            // Operador ternário
            return AnoFabricacao < 2010
                ? true
                : false;
        }

        // retorno do tipo bool quer dizer que o método vai retornar um boolean => é um método com retorno
        // métodos com retorno precisam conter um, ou mais, RETURN dentro de seu escopo
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public bool ValidarCompraValida()
        {
            var consumo = CalcularConsumo();

            if (consumo <= 12)
            {
                // Não devo comprar o carro pois consome mto combustível
                return false;
            }

            var ehVelho = VerificarSeCarroVelho();

            if (ehVelho == true)
            {
                // Não devo comprar o carro pois ele é velho
                return false;
            }

            var jurosAbusivos = ValidarQueValorJurosEhAbusivo();
            if (jurosAbusivos == true)
            {
                // Não devo pagar além de 40% do valor da fipe
                return false;
            }

            return true;
        }

        // retorno do tipo bool quer dizer que o método vai retornar um boolean => é um método com retorno
        // métodos com retorno precisam conter um, ou mais, RETURN dentro de seu escopo
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public bool ValidarQueValorJurosEhAbusivo()
        {
            // FIPE                 100%
            // ValorTotalEmprestimo
            var valorTotalEmprestimo = CalcularValorTotalEmprestimo();
            var percentualJuros = (valorTotalEmprestimo * 100) / ValorFipe;

            if (percentualJuros > 140)
            {
                return true;
            }

            return false;
        }
    }
}
