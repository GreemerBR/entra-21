using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosMetodosString
{
    internal class ExemploContains
    {
        public void Executar()
        {
            string frase = "com FOME eu estou";

            if (frase.ToLower().Contains("fome"))
            {
                Console.WriteLine("Usuário tem fome");
            }
            else
            {
                Console.WriteLine("Usuário não tem fome");
            }
        }
    }
}
