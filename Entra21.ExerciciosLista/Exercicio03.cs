using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosLista
{
    internal class Exercicio03
    {
        /* Criar uma classe que irá as notas:
         *   a.Solicitar a nota 1
         *   b.Solicitar a nota 2
         *   c.Solicitar a nota 3
         *   d.Listar notas
         *   e.Apresentar média das notas
         *   f.Apresentar status da média
         */
        public void Executar()
        {
            Console.Clear();

            List<double> notas = new List<double>();

            Console.Write("Por favor informe a nota 01: ");
            notas.Add(Convert.ToDouble(Console.ReadLine().Trim()));

            Console.Write("Por favor informe a nota 02: ");
            notas.Add(Convert.ToDouble(Console.ReadLine().Trim()));

            Console.Write("Por favor informe a nota 03: ");
            notas.Add(Convert.ToDouble(Console.ReadLine().Trim()));

            Console.Clear();
            Console.WriteLine($@"As notas informadas foram:
Nota 01: {notas[0]}
Nota 02: {notas[1]}
Nota 03: {notas[2]}
");

            var mediaNotas = (notas[0] + notas[1] + notas[2]) / 3;                      

            if (mediaNotas >= 7.0)
            {
                Console.WriteLine($"Média final: {mediaNotas.ToString("F")}");
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine($"Média final: {mediaNotas.ToString("F")}");
                Console.WriteLine("Reprovado!");
            }
        }
    }
}