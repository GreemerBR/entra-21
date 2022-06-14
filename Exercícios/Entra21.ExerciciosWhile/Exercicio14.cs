using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio14
    {
        /* Solicitar a quantidade de caracteres que serão digitados. Após isto solicitando um
         * caracter por vez e armazenar o texto, no final deve-se apresentar o texto.
         * Para solicitar o caracter ao usuário deve-se utilizar char.
         * Ao final apresente o texto contendo os caracteres que o usuário digitou.
         * Exemplo: “A camisa é amarela”
         */
        public void Executar()
        {
            Console.Write("Informe quantos caracteres serão digitiados: ");
            int quantidadeCaracteres = Convert.ToInt32(Console.ReadLine());
            string texto = "";

            int contador = 0;
            while (contador < quantidadeCaracteres)
            {
                Console.Write("Digite o caractere: ");
                char caracter = Convert.ToChar(Console.ReadLine());

                texto = texto + caracter;

                contador = contador + 1;
            }

            Console.Clear();
            Console.WriteLine("O texto digitado foi: " + texto);
        }
    }
}
