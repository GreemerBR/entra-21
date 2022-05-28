using Entra21.ExercicioOrientacaoObjetos.TestesDeValidacaoDeInformacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetos.Temperaturas
{
    public class ExercicioTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperatura();
            var numeroRacionalValido = new NumerosRacionaisValidos();
            var nomeCoisaValido = new NomesCoisasValidos();
            var ehValido = false;

            while (ehValido == false)
            {
                Console.WriteLine("Por favor, informe os dados solicitados abaixo: ");

                Console.Write("Informe a temperatura de origem (Celsius, Fahrenheit ou Kelvin): ");
                temperatura.TemperaturaOrigem = nomeCoisaValido.ObterNome().ToUpper();

                Console.Write("Informe a temperatura de destino (Celsius, Fahrenheit ou Kelvin): ");
                temperatura.TemperaturaDestino = nomeCoisaValido.ObterNome().ToUpper();

                Console.Write("Informe o valor da temperatura: ");
                temperatura.ValorTemperatura = numeroRacionalValido.ObterNumeroRacional();

                var temperaturaConvertida = temperatura.ObterTemperaturaConvertida();

                if (temperaturaConvertida != "Erro ao determinar as unidades de medida. Temperaturas de origem e destino devem ser Celsius, Fahrenheit ou Kelvin.")
                {
                    ehValido = true;
                    Console.Clear();
                    Console.WriteLine(temperaturaConvertida);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(temperaturaConvertida);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }
    }
}