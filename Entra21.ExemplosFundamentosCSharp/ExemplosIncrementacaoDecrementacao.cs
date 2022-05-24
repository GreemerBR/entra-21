using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFundamentosCSharp
{
    internal class ExemplosIncrementacaoDecrementacao
    {
        public void Executar()
        {
            //  Incrementar a quantidade em 1
            int quantidadeBones = 0;
            quantidadeBones = quantidadeBones + 1; // 0 + 1 = 1;
            quantidadeBones = quantidadeBones + 1; // 1 + 1 = 2;

            //  Decrementar a quantidade em 1
            int contagem = 10;
            contagem = contagem + 1; // 10 - 1 = 9;
            contagem = contagem + 1; // 9 - 1 = 8;
        }
    }
}
