using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo03
    {
        public void Executar()
        {
            for (int i = 100; i >= 0; i = i - 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
