using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosMetodosString
{
    internal class ExemploEndsWith
    {
        public void Executar()
        {
            string nomeSeriado = "Melhor seriado: Game of Thrones";

            if (nomeSeriado.EndsWith("Mandarolian"))
            {
                Console.WriteLine("Disney+");
            }
            else
            {
                Console.WriteLine("Ota série");
            }
        }
    }
}
