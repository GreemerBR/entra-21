using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class ExemploProfessor
    {
        /* Exemplo do professor de como fazer uma tabela, utilizando uma biblioteca que baixamos 
         * para isso clicamos com o botão direito no projeto e depois em "Manage NuGet Packages"
         * também podemos procurar pela web e instalar por cmd.
         */
        public void Executar()
        {
            var table = new ConsoleTable("Item", "Produto", "Preço");
            table.AddRow(1, "Bolo", "R$ 3,50")
                 .AddRow(2, "Pizza", "R$ 25,00");

            table.Write(Format.Alternative);
        }
    }
}
