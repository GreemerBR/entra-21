using Entra21.ExerciciosOrientacaoObjetos.TestesDeValidacaoDeInformacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Temperaturas
{
    public class ExercicioTemperatura
    {
        /* Criar uma classe chamada Temperatura, armazenar as seguintes propriedades:
         *   ● temperatura de origem
         *   ● Temperatura de destino
         *   ● Valor da temperatura
         *  Criar métodos:
         *   ● Calcular Celsius para Kelvin
         *   ● Calcular Celsius para Fahrenheit
         *   ● Calcular Kelvin para Celsius
         *   ● Calcular Kelvin para Fahrenheit
         *   ● Calcular Fahrenheit para Celsius
         *   ● Calcular Fahrenheit para Kelvin
         *   ● Obter temperatura convertida
         *  Exemplo:
         *  Input:
         *   Temperatura origem: usuário digitou ‘Celcius’
         *   Temperatura destino: usuário digitou ‘Fahrenheit’
         *   Temperatura valor: usuário digitou 42.30;
         *  Processamento:
         *   Deve-se executar o método ‘Calcular Celsius para Fahrenheit’, pois de acordo com origem e
         *   destino deve executar este método.
         *  Output:
         *   Temperatura convertida: 108,14
         *  Obs.: Criar testes unitários, assim como, ExercicioTemperatura.
         */
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