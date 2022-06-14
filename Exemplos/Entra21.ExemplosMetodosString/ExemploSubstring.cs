using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosMetodosString
{
    internal class ExemploSubstring
    {
        public void Executar()
        {
            //Substring
            string dataTexto = "1993-06-28";
            dataTexto = dataTexto.Replace("-", "");

            string anoTexto = dataTexto.Substring(0, 4);
            string mesTexto = dataTexto.Substring(4, 2);
            string diaTexto = dataTexto.Substring(6, 2);

            int dia = Convert.ToInt32(diaTexto);
            int mes = Convert.ToInt32(mesTexto);
            int ano = Convert.ToInt32(anoTexto);
            Console.WriteLine(dia + "/" + mes + "/" + ano);

            //DateTime
            DateTime dataHoraAgora = DateTime.Now;
            int anoHoje = dataHoraAgora.Year;

            int idade = anoHoje - ano;
            Console.WriteLine("Idade: " + idade);

            DateTime dataNascimento = new DateTime(ano, mes, dia);
            Console.WriteLine("Idade: " + idade + "\nData nascimento: " + dataNascimento.ToString("dd/MM/yyyy"));

        }
    }
}
