using Entra21.ExemplosOrientacaoObjetos.Calculadoras;
using FluentAssertions;
using Xunit;

namespace Entra21.ExemplosOrientacaoObjetos.Tests.Calculadoras
{
    public class CalculadoraTest
    {
        // Antes
        //[Fact]
        //public void Validar_Soma_Cenario01()
        //{
        //    // Arrange
        //    var calculadora = new Calculadora();
        //    calculadora.Numero1 = 2;
        //    calculadora.Numero2 = 3;

        //    // Act
        //    var soma = calculadora.Somar();

        //    // Assert
        //    soma.Should().Be("Soma: 5");
        // }

        // Agora      
        [Theory]
        [InlineData(2, 3, "Soma: 5")]
        [InlineData(25, 32, "Soma: 57")]
        public void Validar_Soma(int numero1, int numero2, string somaEsperada)
        {
            // Arrange
            var calculadora = new Calculadora();
            calculadora.Numero1 = numero1;
            calculadora.Numero2 = numero2;

            // Act
            var soma = calculadora.Somar();

            // Assert
            soma.Should().Be(somaEsperada);
        }

    }
}