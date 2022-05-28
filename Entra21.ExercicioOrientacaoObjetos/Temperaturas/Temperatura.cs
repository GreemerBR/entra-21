using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetos.Temperaturas
{
    public class Temperatura
    {
        public string TemperaturaOrigem, TemperaturaDestino;
        public double ValorTemperatura;

        public double CalcularCelsiusParaKelvin()
        {
            var temperaturaEmKelvin = ValorTemperatura + 273;

            return temperaturaEmKelvin;
        }

        public double CalcularCelsiusParaFahrenheit()
        {
            var temperaturaEmFahrenheit = ((ValorTemperatura / 100) * 180) + 32;

            return temperaturaEmFahrenheit;
        }

        public double CalcularKelvinParaCelsiu()
        {
            var temperaturaEmCelsiu = ValorTemperatura - 273;

            return temperaturaEmCelsiu;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            var temperaturaEmCelsius = CalcularKelvinParaCelsiu();
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
            var temperaturaEmCelsius = FahrenheitParaCelsius();
            ValorTemperatura = temperaturaEmCelsius;
            var temperaturaEmKelvin = CalcularCelsiusParaKelvin();

            return temperaturaEmKelvin;
        }

        public string ObterTemperaturaConvertida()
        {
            if (TemperaturaOrigem.StartsWith("C") && TemperaturaDestino.StartsWith("C"))
            {
                return $"Temperatura convertida: {ValorTemperatura}°C.";
            }
            else if (TemperaturaOrigem.StartsWith("C") && TemperaturaDestino.StartsWith("F"))
            {
                return $"Temperatura convertida: {CalcularCelsiusParaFahrenheit()}F.";
            }
            else if (TemperaturaOrigem.StartsWith("C") && TemperaturaDestino.StartsWith("K"))
            {
                return $"Temperatura convertida: {CalcularCelsiusParaKelvin()}K.";
            }
            else if (TemperaturaOrigem.StartsWith("F") && TemperaturaDestino.StartsWith("F"))
            {
                return $"Temperatura convertida: {ValorTemperatura}F.";
            }
            else if (TemperaturaOrigem.StartsWith("F") && TemperaturaDestino.StartsWith("K"))
            {
                return $"Temperatura convertida: {CalcularFahrenheitParaKelvin()}K.";
            }
            else if (TemperaturaOrigem.StartsWith("F") && TemperaturaDestino.StartsWith("C"))
            {
                return $"Temperatura convertida: {CalcularFahrenheitParaCelsius()}°C.";
            }
            else if (TemperaturaOrigem.StartsWith("K") && TemperaturaDestino.StartsWith("K"))
            {
                return $"Temperatura convertida: {ValorTemperatura}K.";
            }
            else if (TemperaturaOrigem.StartsWith("K") && TemperaturaDestino.StartsWith("F"))
            {
                return $"Temperatura convertida: {CalcularKelvinParaFahrenheit()}F.";
            }
            else if (TemperaturaOrigem.StartsWith("K") && TemperaturaDestino.StartsWith("C"))
            {
                return $"Temperatura convertida: {CalcularKelvinParaCelsiu()}°C.";
            }
            else
            {
                return $"Opção invalida.";
            }
        }
    }
}
