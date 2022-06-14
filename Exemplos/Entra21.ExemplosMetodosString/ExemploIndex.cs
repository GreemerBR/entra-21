using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosMetodosString
{
    internal class ExemploIndex
    {
        public void Executar()
        {
            Console.Write("Digite o nome do filme | classificação: ");
            string texto = Console.ReadLine(); //peppa pig|14 anos
                                               //peppa pig|1 4   a n o s
                                               //012345678910111213141516
                                               
            int indiceBarraVertical = texto.IndexOf("|"); //9 conforme comentário anterior

            string nomeFilme = texto.Substring(0, indiceBarraVertical); // peppapig

            int indiceComecoClassificacao = indiceBarraVertical + 1; //10

            int tamanhoTexto = texto.Length; //17

            int tamanhoClassificacao = tamanhoTexto - indiceComecoClassificacao; //7

            string classificacao = texto.Substring(indiceComecoClassificacao, tamanhoClassificacao); //14 anos

            int idadeRecomendada = Convert.ToInt32(classificacao.Replace("anos", "")); //14

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= idadeRecomendada)
            {
                Console.WriteLine("Pode assistir o filme");
            }
            else
            {
                Console.WriteLine("Não pode assistir o filme");
            }
        }
    }
}
