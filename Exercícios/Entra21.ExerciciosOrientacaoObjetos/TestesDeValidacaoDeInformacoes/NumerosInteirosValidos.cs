using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.TestesDeValidacaoDeInformacoes
{
    public class NumerosInteirosValidos
    {
        public int ObterNumeroInteiro()
        {
            var numero = 0;
            var testeNumeroValido = false;

            while (testeNumeroValido == false)
            {
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine().Trim());

                    testeNumeroValido = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O número informado não é valido. Por favor informe um número inteiro.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe um novo numero: ");
                }
            }

            return numero;
        }
    }
}
