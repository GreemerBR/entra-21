using Entra21.ExercicioOrientacaoObjetos.Farmacias;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExercicioOrientacaoObjetos.Tests.Farmacias
{
    public class FarmaciaTests
    {
        [Theory]
        [InlineData(10.0, 10.0, 10.0, "O valor total do pedido foi de R$30,00.")]
        [InlineData(15.50, 15.50, 15.50, "O valor total do pedido foi de R$46,50.")]
        [InlineData(25.0, 25.0, 25.0, "O valor total do pedido foi de R$75,00.")]

        public void Validiar_ApresentarTotalDoPedido(double precoProduto1, double precoProduto2, double precoProduto3, string totalEsperadoPedido)
        {
            // Arrange
            var farmacia = new Farmacia();
            farmacia.PrecoProduto[0] = precoProduto1;
            farmacia.PrecoProduto[1] = precoProduto2;
            farmacia.PrecoProduto[2] = precoProduto3;

            // Act
            var totalEsperado = farmacia.ApresentarTotalDoPedido();

            // Assert
            totalEsperado.Should().Be(totalEsperadoPedido);
        }

    }
}
