using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosLista
{    
    internal class Exercicio02
    {
        /* Criar uma classe que irá armazenar os conteúdos passados até o momento:
         *   a. Adicionar o conteúdo "Como fazer um bolo"
         *   b. Listar conteúdos
         *   c. Alterar conteúdo "Como fazer um bolo" para "Algoritmos onde vivem? Do que
         *   se alimentam]'
         *   d. Adicionar o conteúdo "variáveis"
         *   e. Adicionar o conteúdo "Mais para frente"
         *   f. Alterar o conteúdo “Mais para frente" por "If com E"
         *   g. Adicionar o conteúdo "If com OU”;
         *   h. Adicionar o conteúdo "While";
         *   i. Adicionar o conteúdo "For"
         *   j. Listar conteúdos
         *   k. Adicionar o conteúdo "Vetor"
         *   l. Adicionar o conteúdo "Vetor”
         *   m. Apagar os conteúdos "Vetor"
         *   n. Adicionar o conteúdo "Vetor"
         *   o. Alterar o conteúdo"Vetor" para "Vetor com For um amor na minha vida"
         *   p. Listar conteúdos
         *   q. Adicionar o conteúdo "Classe propriedades e métodos"
         *   r. Listar conteúdos
         */
        public void Executar()
        {
            Console.Clear();

            List<string> conteudosPassados = new List<string>();

            conteudosPassados.Add("Como fazer um bolo");

            Console.WriteLine($@"Conteúdos passados:
{conteudosPassados[0]}
");

            var indiceComoFazerBolo = conteudosPassados.IndexOf("Como fazer um bolo");
            conteudosPassados[indiceComoFazerBolo] = "Algoritmos onde vivem? Do que se alimentam";

            conteudosPassados.Add("variáveis");
            conteudosPassados.Add("Mais para frente");

            var indiceMaisParaFrente = conteudosPassados.IndexOf("Mais para frente");
            conteudosPassados[indiceMaisParaFrente] = "If com E";

            conteudosPassados.Add("If com OU");
            conteudosPassados.Add("While");
            conteudosPassados.Add("For");

            Console.WriteLine($@"Conteúdos passados:
{conteudosPassados[0]}
{conteudosPassados[1]}
{conteudosPassados[2]}
{conteudosPassados[3]}
{conteudosPassados[4]}
{conteudosPassados[5]}
");

            conteudosPassados.Add("Vetor");
            conteudosPassados.Add("Vetor");

            conteudosPassados.Remove("Vetor");
            conteudosPassados.Remove("Vetor");

            conteudosPassados.Add("Vetor");

            var indexVetor = conteudosPassados.IndexOf("Vetor");
            conteudosPassados[indexVetor] = "Vetor com For um amor na minha vida";

            Console.WriteLine($@"Conteúdos passados:
{conteudosPassados[0]}
{conteudosPassados[1]}
{conteudosPassados[2]}
{conteudosPassados[3]}
{conteudosPassados[4]}
{conteudosPassados[5]}
{conteudosPassados[6]}
");

            conteudosPassados.Add("Classe propriedades e métodos");

            Console.WriteLine($@"Conteúdos passados:
{conteudosPassados[0]}
{conteudosPassados[1]}
{conteudosPassados[2]}
{conteudosPassados[3]}
{conteudosPassados[4]}
{conteudosPassados[5]}
{conteudosPassados[6]}
{conteudosPassados[7]}
");
        }
    }
}