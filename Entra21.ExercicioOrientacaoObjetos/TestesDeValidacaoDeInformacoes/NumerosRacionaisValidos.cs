using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.TestesDeValidacaoDeInformacoes
{
    public class NumerosRacionaisValidos
    {
        public double ObterNumeroRacional()
        {
            var numero = 0.0;
            var testeNumeroValido = false;

            while (testeNumeroValido == false)
            {
                try
                {
                    numero = Convert.ToDouble(Console.ReadLine().Trim());

                    testeNumeroValido = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por favor informe um número.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe um novo numero: ");
                }
            }

            return numero;
        }
    }
}