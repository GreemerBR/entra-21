using Entra21.ExercicioOrientacaoObjetos.TestesDeValidacaoDeInformacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetos.ASCIIs
{
    public class ExercicioConversorAscii
    {
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