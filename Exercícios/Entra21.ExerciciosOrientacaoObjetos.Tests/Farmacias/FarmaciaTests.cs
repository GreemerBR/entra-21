using Entra21.ExerciciosOrientacaoObjetos.Farmacias;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Farmacias
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

        [Theory]
        [InlineData(10.0, 10.0, 10.0, "analgésicos", "antibióticos", "anticoagulantes", "* Total Analgésicos: R$10,00\n" +
            "* Total Antibióticos: R$10,00\n" + "* Total Anticoagulantes: R$10,00\n")]
        [InlineData(10.0, 10.0, 10.0, "antidepressivos", "anticancerosos", "antiepilépticos", "* Total Antidepressivos: R$10,00\n" +
            "* Total Anticancerosos: R$10,00\n" + "* Total Antiepiléticos: R$10,00\n")]
        [InlineData(10.0, 10.0, 10.0, "anti psicóticos", "antivirais", "sedativos", "* Total Anti Psicóticos: R$10,00\n" +
            "* Total Antivirais: R$10,00\n" + "* Total Sedativos: R$10,00\n")]
        [InlineData(10.0, 10.0, 10.0, "anti inflamatórios não esteroidais", "anti inflamatórios esteroidais",
            "droga anti reumática modificadora de doença", "* Total Anti Inflamatórios Não Esteroidais: R$10,00\n" +
            "* Total Anti Inflamatórios Esteroidais: R$10,00\n" + "* Total Droga Anti Reumática Modificadora de Doença: R$10,00")]
        [InlineData(10.0, 10.0, 10.0, "analgésicos", "analgésicos", "analgésicos", "* Total Analgésicos: R$30,00\n")]
        [InlineData(10.0, 10.0, 10.0, "analgésicos", "analgésicos", "antibióticos", "* Total Analgésicos: R$20,00\n" +
            "* Total Antibióticos: R$10,00\n")]
        public void Validar_ApresentarTotalDoPedidoPorCategoriaDeProduto(double precoProduto1, double precoProduto2, double precoProduto3,
            string categoriaProduto1, string categoriaProduto2, string categoriaProduto3, string totalPorCategoriaEsperado)
        {
            // Arrange
            var farmacia = new Farmacia();
            farmacia.PrecoProduto[0] = precoProduto1;
            farmacia.PrecoProduto[1] = precoProduto2;
            farmacia.PrecoProduto[2] = precoProduto3;
            farmacia.CategoriaProduto[0] = categoriaProduto1;
            farmacia.CategoriaProduto[1] = categoriaProduto2;
            farmacia.CategoriaProduto[2] = categoriaProduto3;

            // Act
            var totalPorCategoria = farmacia.ApresentarTotalDoPedidoPorCategoriaDeProduto();

            // Assert
            totalPorCategoria.Should().Be(totalPorCategoriaEsperado);
        }

        [Theory]
        [InlineData(1, 1, 1, "analgésicos", "antibióticos", "anticoagulantes", "* Total de Analgésicos: 1 unidade(s)\n" +
            "* Total de Antibióticos: 1 unidade(s)\n" + "* Total de Anticoagulantes: 1 unidade(s)\n")]
        [InlineData(1, 1, 1, "antidepressivos", "anticancerosos", "antiepilépticos", "* Total de Antidepressivos: 1 unidade(s)\n" +
            "* Total de Anticancerosos: 1 unidade(s)\n" + "* Total de Antiepiléticos: 1 unidade(s)\n")]
        [InlineData(1, 1, 1, "anti psicóticos", "antivirais", "sedativos", "* Total de Anti Psicóticos: 1 unidade(s)\n" +
            "* Total de Antivirais: 1 unidade(s)\n" + "* Total de Sedativos: 1 unidade(s)\n")]
        [InlineData(1, 1, 1, "anti inflamatórios não esteroidais", "anti inflamatórios esteroidais",
            "droga anti reumática modificadora de doença", "* Total de Anti Inflamatórios Não Esteroidais: 1 unidade(s)\n" +
            "* Total de Anti Inflamatórios Esteroidais: 1 unidade(s)\n" + "* Total de Droga Anti Reumática Modificadora de Doença: 1 unidade(s)")]
        [InlineData(1, 1, 1, "analgésicos", "analgésicos", "analgésicos", "* Total de Analgésicos: 3 unidade(s)\n")]
        [InlineData(1, 1, 1, "analgésicos", "analgésicos", "antibióticos", "* Total de Analgésicos: 2 unidade(s)\n" +
            "* Total de Antibióticos: 1 unidade(s)\n")]
        public void Validar_ApresentarQuantidadePorCategoria(double precoProduto1, double precoProduto2, double precoProduto3,
            string categoriaProduto1, string categoriaProduto2, string categoriaProduto3, string totalPorCategoriaEsperado)
        {
            // Arrange
            var farmacia = new Farmacia();
            farmacia.PrecoProduto[0] = precoProduto1;
            farmacia.PrecoProduto[1] = precoProduto2;
            farmacia.PrecoProduto[2] = precoProduto3;
            farmacia.CategoriaProduto[0] = categoriaProduto1;
            farmacia.CategoriaProduto[1] = categoriaProduto2;
            farmacia.CategoriaProduto[2] = categoriaProduto3;

            // Act
            var quantidadePorCategoria = farmacia.ApresentarQuantidadePorCategoria();

            // Assert
            quantidadePorCategoria.Should().Be(totalPorCategoriaEsperado);
        }

        [Theory]
        [InlineData(10.0, 15.0, 20.0, "Produto1", "Produto2", "Produto3",
            "O(s) produto(s) mais caro(s) do pedido é(são): Produto3, e ele(s) custa(m) R$20,00.")]
        [InlineData(10.0, 15.0, 15.0, "Produto1", "Produto2", "Produto3",
            "O(s) produto(s) mais caro(s) do pedido é(são): Produto2 / Produto3, e ele(s) custa(m) R$15,00.")]
        [InlineData(10.0, 10.0, 10.0, "Produto1", "Produto2", "Produto3",
            "O(s) produto(s) mais caro(s) do pedido é(são): Produto1 / Produto2 / Produto3, e ele(s) custa(m) R$10,00.")]
        public void Validar_ApresentarNomeProdutoMaisCaro(double precoProduto1, double precoProduto2, double precoProduto3,
            string nomeProduto1, string nomeProduto2, string nomeProduto3, string nomeEsperado)
        {
            // Arrange
            var farmacia = new Farmacia();
            farmacia.NomeProduto[0] = nomeProduto1;
            farmacia.NomeProduto[1] = nomeProduto2;
            farmacia.NomeProduto[2] = nomeProduto3;
            farmacia.PrecoProduto[0] = precoProduto1;
            farmacia.PrecoProduto[1] = precoProduto2;
            farmacia.PrecoProduto[2] = precoProduto3;

            // Act
            var nomeProdutoMaisCaro = farmacia.ApresentarNomeProdutoMaisCaro();

            // Assert
            nomeProdutoMaisCaro.Should().Be(nomeEsperado);
        }

        [Theory]
        [InlineData(10.0, 15.0, 20.0, "Produto1", "Produto2", "Produto3", "analgésicos", "antibióticos", "anticoagulantes",
            "O(s) produto(s) mais barato(s) do pedido é(são): Produto1, e ele(s) é(são) da(s) categoria(s) analgésicos.")]
        [InlineData(10.0, 10.0, 15.0, "Produto1", "Produto2", "Produto3", "antidepressivos", "anticancerosos", "antiepilépticos",
            "O(s) produto(s) mais barato(s) do pedido é(são): Produto1 / Produto2, e ele(s) é(são) da(s) categoria(s)" +
            " antidepressivos / anticancerosos.")]
        [InlineData(10.0, 10.0, 10.0, "Produto1", "Produto2", "Produto3", "anti psicóticos", "antivirais", "sedativos",
            "O(s) produto(s) mais barato(s) do pedido é(são): Produto1 / Produto2 / Produto3, e ele(s) é(são) da(s) categoria(s)" +
            " anti psicóticos / antivirais / sedativos.")]
        public void Validar_ApresentarNomeCategoriaProdutoMaisBarato(double precoProduto1, double precoProduto2, double precoProduto3,
            string nomeProduto1, string nomeProduto2, string nomeProduto3, string categoriaProduto1, string categoriaProduto2,
            string categoriaProduto3, string nomeEsperado)
        {
            // Arrange
            var farmacia = new Farmacia();
            farmacia.NomeProduto[0] = nomeProduto1;
            farmacia.NomeProduto[1] = nomeProduto2;
            farmacia.NomeProduto[2] = nomeProduto3;
            farmacia.PrecoProduto[0] = precoProduto1;
            farmacia.PrecoProduto[1] = precoProduto2;
            farmacia.PrecoProduto[2] = precoProduto3;
            farmacia.CategoriaProduto[0] = categoriaProduto1;
            farmacia.CategoriaProduto[1] = categoriaProduto2;
            farmacia.CategoriaProduto[2] = categoriaProduto3;

            // Act
            var produtoMaisBarato = farmacia.ApresentarNomeCategoriaProdutoMaisBarato();

            // Assert
            produtoMaisBarato.Should().Be(nomeEsperado);
        }
    }
}