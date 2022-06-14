using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosMetodosString
{
    internal class ExemploReplace
    {
        public void Executar()
        {
            // Replace
            string cpf = "085.611.619-06";

            cpf = cpf.Replace(".","").Replace("-","").Trim();

            Console.WriteLine(cpf);

            //Length
            int quantidadeCaracteres = cpf.Length;
            Console.WriteLine("CPF: " + cpf + "\nQuantidade de caracteres do cpf: " + quantidadeCaracteres);
        }
    }
}
