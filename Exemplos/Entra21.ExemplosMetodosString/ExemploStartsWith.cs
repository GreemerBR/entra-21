using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosMetodosString
{
    internal class ExemploStartsWith
    {
        public void Executar()
        {
            //Exemplo01
            string texto = "Nescau cereal radical";
            bool comecaComNescau = texto.ToLower().StartsWith("nescau");
            Console.WriteLine(comecaComNescau);

            //Exemplo02
            Console.Write("Texto: ");
            string texto2 = Console.ReadLine();
            //texto = "Nome completo: Gregory Viegas Zimmer"
            //texto = "Hora Consu l t a :   22:10:13"
                     //12345678910111213141512345678

            if (texto.StartsWith("Hora consulta: "))
            {
                string hora = texto.Substring(15, 8); //Ver último comentário
                Console.WriteLine(hora);
            }
            else if (texto.StartsWith("Nome completo: "))
            {
                //obtem a quantidade de caracteres
                int quantidadeCaracteresTotal = texto2.Length;
                int quantidadeCaracteresNomeCompleto = quantidadeCaracteresTotal - 15;

                string nomeCompleto = texto2.Substring(15, quantidadeCaracteresNomeCompleto);

                Console.WriteLine(nomeCompleto);
            }
            else
            {
                Console.WriteLine("Comando invalido.");
            }
        }
    }
}
