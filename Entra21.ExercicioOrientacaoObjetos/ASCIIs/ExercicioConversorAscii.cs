using Entra21.ExerciciosOrientacaoObjetos.TestesDeValidacaoDeInformacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.ASCIIs
{
    public class ExercicioConversorAscii
    {
        /* Criar uma classe chamada ConversorAscii
         *   ● Caracter
         *  Criar métodos:
         *   ● Obter código ascii do caracter.Levar em consideração que pode ser em caixa alta ou caixa baixa.
         *  Obs.: É obrigatório fazer os ifs para descobrir o código ascii.
         *  Obs.: Criar testes unitários, assim como, ExercicioConversorAscii.
         */
        public void Executar()
        {

            var ascii = new ConversorAscii();
            var caracter = new CaracterEhAlfabetico();

            Console.Clear();
            Console.Write("Informe o caracter ao qual de deseja descobrir o código ASCII: ");
            ascii.Caracter = caracter.ObterCaracterAlfabetico();

            var codigoAsciiDecimal = ascii.ObterCodigoAsciiDecimalDoCaracter();

            Console.Clear();
            Console.WriteLine($"O código ASCII decimal do caracter {ascii.Caracter} é {codigoAsciiDecimal}");
        }
    }
}