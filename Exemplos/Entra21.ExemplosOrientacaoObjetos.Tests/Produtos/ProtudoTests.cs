using Entra21.ExemplosOrientacaoObjetos.Produtos;
using FluentAssertions;
using Xunit;

namespace Entra21.ExemplosOrientacaoObjetos.Tests.Produtos
{
    public class ProtudoTests
    {
        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Menor_Hoje()
        {
            // Arrange (preparar od dados)
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(-1);

            // Act (ato da execução do método que deseja testar)
            var produtoVencido = produto.EhVencido();

            // Assert (validação do que foi gerado)
            produtoVencido.Should().Be(true);
            // produtoVencido.Should().BeTrue(); -> outra forma do "Be(True)"
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Maior_Hoje()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(1);

            // Act
            var produtoVencido = produto.EhVencido();

            // Assert
            produtoVencido.Should().Be(false);
            //vencido.Should().BeFalse(); -> outra forma do "Be(false)"
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Hoje()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().Be(true);
        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdadeiro()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().Be(true);
        }

        [Fact]
        public void Validar_EstaEmPromocao_Falso()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().Be(false);
        }
    }
}