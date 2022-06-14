using Entra21.ExerciciosOrientacaoObjetos.Temperaturas;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Temperaturas
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

        [Fact]
        public void Validar_CalcularKelvinParaCelsius()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 311.15;

            // Act
            var temperaturaEmCelsius = temperatura.CalcularKelvinParaCelsius();

            // Assert
            temperaturaEmCelsius.Should().Be(38);
        }

        [Fact]
        public void Validar_CalcularKelvinParaFahrenheit()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 311.15;

            // Act
            var temperaturaEmFahrenheit = temperatura.CalcularKelvinParaFahrenheit();

            // Assert
            temperaturaEmFahrenheit.Should().Be(100.4);
        }

        [Fact]
        public void Validar_CalcularFahrenheitParaCelsius()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 100.4;

            // Act
            var temperaturaEmCelsius = temperatura.CalcularFahrenheitParaCelsius();

            // Assert
            temperaturaEmCelsius.Should().Be(38);
        }

        [Fact]
        public void Validar_CalcularFahrenheitParaKelvin()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 100.4;

            // Act
            var temperaturaEmKelvin = temperatura.CalcularFahrenheitParaKelvin();

            // Assert
            temperaturaEmKelvin.Should().Be(311.15);
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_CelsiusParaCelsius()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "CELSIUS";
            temperatura.TemperaturaDestino = "CELSIUS";
            temperatura.ValorTemperatura = 38.00;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 38,00°C.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_CelsiusParaFahrenheit()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "CELSIUS";
            temperatura.TemperaturaDestino = "FAHRENHEIT";
            temperatura.ValorTemperatura = 38.00;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 100,40F.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_CelsiusParaKelvin()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "CELSIUS";
            temperatura.TemperaturaDestino = "KELVIN";
            temperatura.ValorTemperatura = 38.00;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 311,15K.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_FahrenheitParaFahrenheit()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "FAHRENHEIT";
            temperatura.TemperaturaDestino = "FAHRENHEIT";
            temperatura.ValorTemperatura = 100.40;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 100,40F.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_FahrenheitParaKelvin()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "FAHRENHEIT";
            temperatura.TemperaturaDestino = "KELVIN";
            temperatura.ValorTemperatura = 100.40;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 311,15K.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_FahrenheitParaCelsius()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "FAHRENHEIT";
            temperatura.TemperaturaDestino = "CELSIUS";
            temperatura.ValorTemperatura = 100.40;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 38,00°C.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_KelvinParaKelvin()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "KELVIN";
            temperatura.TemperaturaDestino = "KELVIN";
            temperatura.ValorTemperatura = 311.15;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 311,15K.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_KelvinParaFahrenheit()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "KELVIN";
            temperatura.TemperaturaDestino = "FAHRENHEIT";
            temperatura.ValorTemperatura = 311.15;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 100,40F.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_KelvinParaCelsius()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "KELVIN";
            temperatura.TemperaturaDestino = "CELSIUS";
            temperatura.ValorTemperatura = 311.15;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Temperatura convertida: 38,00°C.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_ErroDeTemperaturaOrigem()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "QUELVIN";
            temperatura.TemperaturaDestino = "CELSIUS";
            temperatura.ValorTemperatura = 311.15;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Erro ao determinar as unidades de medida. Temperaturas de origem e destino devem ser Celsius, Fahrenheit ou Kelvin.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_ErroDeTemperaturaDelstino()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "KELVIN";
            temperatura.TemperaturaDestino = "SELSIUS";
            temperatura.ValorTemperatura = 311.15;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Erro ao determinar as unidades de medida. Temperaturas de origem e destino devem ser Celsius, Fahrenheit ou Kelvin.");
        }

        [Fact]
        public void Validar_ObterTemperaturaConvertida_ErroDeTemperaturaOrigemDestino()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "VAHRENHEIT";
            temperatura.TemperaturaDestino = "SELSIUS";
            temperatura.ValorTemperatura = 100.40;

            // Act
            var resultadoEsperadoAposConversao = temperatura.ObterTemperaturaConvertida();

            // Assert
            resultadoEsperadoAposConversao.Should().Be("Erro ao determinar as unidades de medida. Temperaturas de origem e destino devem ser Celsius, Fahrenheit ou Kelvin.");
        }
    }
}
