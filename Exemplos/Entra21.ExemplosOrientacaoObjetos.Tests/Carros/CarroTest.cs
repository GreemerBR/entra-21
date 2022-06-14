using Entra21.ExemplosOrientacaoObjetos.Carros;
using FluentAssertions;
using Xunit;

namespace Entra21.ExemplosOrientacaoObjetos.Tests.Carros
{
    public class CarroTest
    {
        [Fact]
        public void Validar_CalcularValorTotalEmprestimo_Cenario1()
        {
            Carro carro = new Carro();
            carro.QuantidadeParcelas = 60;
            carro.ValorParcela = 1200.36;

            var valorTotalEmprestimo = carro.CalcularValorTotalEmprestimo();

            var valorTotalEmprestimoEsperado = 60 * 1200.36 + 30;

            valorTotalEmprestimo.Should().Be(valorTotalEmprestimoEsperado);
        }

        [Fact]
        public void Validar_CalcularValorTotalEmprestimo_Cenario2()
        {
            Carro carro = new Carro();
            carro.QuantidadeParcelas = 120;
            carro.ValorParcela = 670.20;

            var valorTotalEmprestimo = carro.CalcularValorTotalEmprestimo();

            var valorTotalEmprestimoEsperado = 120 * 670.20 + 30;

            valorTotalEmprestimo.Should().Be(valorTotalEmprestimoEsperado);
        }

        [Fact]
        public void Testar_CalcularConsumo()
        {
            Carro carro = new Carro();
            carro.TotalParcialPercorrido = 200;
            carro.TamanhoTanque = 82;

            var valorEsperado = 200 / 82.0;

            var consumo = carro.CalcularConsumo();

            consumo.Should().Be(valorEsperado);


        }
    }
}
