using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.TestesDeValidacaoDeInformacoes
{
    public class CnpjValido
    {
        public long ObterCnpj()
        {
            var cnpj = Console.ReadLine().Trim().Replace(".", "").Replace("/", "").Replace("-", "");
            var testeCnpjValido = false;

            while (testeCnpjValido == false)
            {
                if (cnpj.Length == 14)
                {
                    testeCnpjValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O CNPJ informado não é valido. Por favor informe um CNPJ no seguinte formato xx.xxx.xxx/xxxx-xx.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Informe um novo CNPJ: ");
                    cnpj = Console.ReadLine().Trim();
                }
            }

            var cnpjNumerico = Convert.ToInt64(cnpj);
            return cnpjNumerico;
        }
    }
}