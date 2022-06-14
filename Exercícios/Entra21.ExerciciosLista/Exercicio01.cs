using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosLista
{
    internal class Exercicio01
    {
        /* Criar uma classe que irá armazenar os melhores filmes de todos os tempos
         *   a. Adicionar o filme "Dragon Ball Evollution";
         *   b. Adicionar o filme "Titanic";
         *   c. Adicionar o filme "Lanterna verde";
         *   d. Listar os filmes armazenados na lista;
         *   e. Adicionar o filme "";
         *   f. Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
         *   g. Remover filme "Lanterna verde";
         *   h. Verificar se a lista contém o filme "Lanterna verde" apresentando para o
         *   usuário se está ou não cadastrado;
         *   i. Adicionar o filme "Quarteto fantástico";
         *   j. Listar os filmes armazenados na lista;
         *   k. Alterar o filme "Titanic" para “Titanic 2”;
         *   l. Listar os filmes armazenados na lista;
         *   m. Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário
         */
        public void Executar()
        {
            Console.Clear();

            // Criar lista
            List<string> melhoresFilmesDeTodosOsTempos = new List<string>();

            //Adicionar filmes
            melhoresFilmesDeTodosOsTempos.Add("Dragon Ball Evollution");
            melhoresFilmesDeTodosOsTempos.Add("Titanic");
            melhoresFilmesDeTodosOsTempos.Add("Lanterna verde");

            // Listar filmes presentes na lista
            Console.WriteLine($@"Melhores filmes de todos os tempos:
{melhoresFilmesDeTodosOsTempos[0]}
{melhoresFilmesDeTodosOsTempos[1]}
{melhoresFilmesDeTodosOsTempos[2]}
");

            // Adicionar filme
            melhoresFilmesDeTodosOsTempos.Add("");

            // Alterar nome do filme
            var indiceDragonBallEvollution = melhoresFilmesDeTodosOsTempos.IndexOf("Dragon Ball Evollution");
            melhoresFilmesDeTodosOsTempos[indiceDragonBallEvollution] = "Dragon Ball Super: Broly";

            // Remover filme
            melhoresFilmesDeTodosOsTempos.Remove("Lanterna verde");

            // Verifiar se existe na lista
            var possuiLanternaVerde = melhoresFilmesDeTodosOsTempos.Contains("Lanterna verde");

            if (possuiLanternaVerde == true)
            {
                Console.WriteLine(@"O filme Lanterna verde está cadastrado.
");
            }
            else
            {
                Console.WriteLine(@"O filme Lanterna verde não está cadastrado.
");
            }

            // Adicionar filme
            melhoresFilmesDeTodosOsTempos.Add("Quarteto fantástico");

            // Listar filmes presentes na lista
            Console.WriteLine($@"Melhores filmes de todos os tempos:
{melhoresFilmesDeTodosOsTempos[0]}
{melhoresFilmesDeTodosOsTempos[1]}
{melhoresFilmesDeTodosOsTempos[2]}
{melhoresFilmesDeTodosOsTempos[3]}
");

            // Alterar nome do filme
            var indiceTitanic = melhoresFilmesDeTodosOsTempos.IndexOf("Titanic");
            melhoresFilmesDeTodosOsTempos[indiceTitanic] = "Titanic 2";

            // Listar filmes presentes na lista
            Console.WriteLine($@"Melhores filmes de todos os tempos:
{melhoresFilmesDeTodosOsTempos[0]}
{melhoresFilmesDeTodosOsTempos[1]}
{melhoresFilmesDeTodosOsTempos[2]}
{melhoresFilmesDeTodosOsTempos[3]}
");

            // Verifiar se existe na lista
            var possuiLagoaAzul = melhoresFilmesDeTodosOsTempos.Contains("A Lagoa Azul");

            if (possuiLagoaAzul == true)
            {
                Console.WriteLine("O filme A Lagoa Azul está cadastrado.");
            }
            else
            {
                Console.WriteLine("O filme A Lagoa Azul não está cadastrado.");
            }
        }
    }
}