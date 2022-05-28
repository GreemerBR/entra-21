using Entra21.ExercicioOrientacaoObjetos.Temperaturas;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExercicioOrientacaoObjetos.Tests.Temperaturas
{
    public class TemperaturaTests
    {
        [Fact]
        public void Validar_CalcularCelsiusParaKelvin()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 38;

            // Act
            var temperaturaEmKelvin = temperatura.CalcularCelsiusParaKelvin();

            // Assert
            temperaturaEmKelvin.Should().Be(311.15);
        }

        [Fact]
        public void Validar_CalcularCelciusParaFahrenheit()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 38;

            // Act
            var temperaturaEmFahrenheit = temperatura.CalcularCelsiusParaFahrenheit();

            // Assert
            temperaturaEmFahrenheit.Should().Be(100.4);
        }

    }
}
