using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Temperaturas
{
    public class Temperatura
    {
        public string TemperaturaOrigem, TemperaturaDestino;
        public double ValorTemperatura;

        public double CalcularCelsiusParaKelvin()
        {
            var temperaturaEmKelvin = ValorTemperatura + 273.15;

            return temperaturaEmKelvin;
        }

        public double CalcularCelsiusParaFahrenheit()
        {
            var temperaturaEmFahrenheit = ((ValorTemperatura / 100) * 180) + 32;

            return temperaturaEmFahrenheit;
        }

        public double CalcularKelvinParaCelsius()
        {
            var temperaturaEmCelsius = ValorTemperatura - 273.15;

            return temperaturaEmCelsius;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            var temperaturaEmCelsius = CalcularKelvinParaCelsius();
            ValorTemperatura = temperaturaEmCelsius;
            var temperaturaEmFahrenheit = CalcularCelsiusParaFahrenheit();

            return temperaturaEmFahrenheit;
        }

        public double CalcularFahrenheitParaCelsius()
        {
            var temperaturaEmCelsius = ((ValorTemperatura - 32) / 180) * 100;

            return temperaturaEmCelsius;
        }

        public double CalcularFahrenheitParaKelvin()
        {
            var temperaturaEmCelsius = CalcularFahrenheitParaCelsius();
            ValorTemperatura = temperaturaEmCelsius;
            var temperaturaEmKelvin = CalcularCelsiusParaKelvin();

            return temperaturaEmKelvin;
        }

        public string ObterTemperaturaConvertida()
        {
            if (TemperaturaOrigem.StartsWith("C") && TemperaturaDestino.StartsWith("C"))
            {
                return $"Temperatura convertida: {ValorTemperatura.ToString("F")}°C.";
            }
            else if (TemperaturaOrigem.StartsWith("C") && TemperaturaDestino.StartsWith("F"))
            {
                return $"Temperatura convertida: {CalcularCelsiusParaFahrenheit().ToString("F")}F.";
            }
            else if (TemperaturaOrigem.StartsWith("C") && TemperaturaDestino.StartsWith("K"))
            {
                return $"Temperatura convertida: {CalcularCelsiusParaKelvin().ToString("F")}K.";
            }
            else if (TemperaturaOrigem.StartsWith("F") && TemperaturaDestino.StartsWith("F"))
            {
                return $"Temperatura convertida: {ValorTemperatura.ToString("F")}F.";
            }
            else if (TemperaturaOrigem.StartsWith("F") && TemperaturaDestino.StartsWith("K"))
            {
                return $"Temperatura convertida: {CalcularFahrenheitParaKelvin().ToString("F")}K.";
            }
            else if (TemperaturaOrigem.StartsWith("F") && TemperaturaDestino.StartsWith("C"))
            {
                return $"Temperatura convertida: {CalcularFahrenheitParaCelsius().ToString("F")}°C.";
            }
            else if (TemperaturaOrigem.StartsWith("K") && TemperaturaDestino.StartsWith("K"))
            {
                return $"Temperatura convertida: {ValorTemperatura.ToString("F")}K.";
            }
            else if (TemperaturaOrigem.StartsWith("K") && TemperaturaDestino.StartsWith("F"))
            {
                return $"Temperatura convertida: {CalcularKelvinParaFahrenheit().ToString("F")}F.";
            }
            else if (TemperaturaOrigem.StartsWith("K") && TemperaturaDestino.StartsWith("C"))
            {
                return $"Temperatura convertida: {CalcularKelvinParaCelsius().ToString("F")}°C.";
            }
            else
            {
                return $"Erro ao determinar as unidades de medida. Temperaturas de origem e destino devem ser Celsius, Fahrenheit ou Kelvin.";
            }
        }
    }
}