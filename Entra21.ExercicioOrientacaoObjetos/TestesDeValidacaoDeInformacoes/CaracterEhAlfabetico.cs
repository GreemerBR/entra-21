using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.TestesDeValidacaoDeInformacoes
{
    public class CaracterEhAlfabetico
    {
        public char ObterCaracterAlfabetico()
        {
            var caracter = Convert.ToChar(Console.ReadLine().Trim());
            var caracterEhValido = false;            

            while (caracterEhValido == false)
            {
                var valorUnicodeCaracter = Convert.ToInt32(Char.GetUnicodeCategory(caracter));
                if (valorUnicodeCaracter == 0 || valorUnicodeCaracter == 1)
                {
                    caracterEhValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O caractere informado não é valido. Por favor informe um caractere alfabetico maiúsculo ou minúsculo.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe um novo caracter: ");
                    caracter = Convert.ToChar(Console.ReadLine().Trim());
                }

            }

            return caracter;
        }
    }
}
