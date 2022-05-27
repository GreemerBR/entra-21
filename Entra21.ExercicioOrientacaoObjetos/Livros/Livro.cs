using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetos.Livros
{
    public class Livro
    {
       

        public string Titulo, Autor, IdiomaOriginal, CodigoIsbn;
        public int QuantidadePaginas, QuantidadePaginasLidas, QuantidadeReleituras;
        public DateTime DataLancamento;

        public void ApresentarAutor()
        {
            Console.WriteLine("O nome do(a) autor(a) do livro " + Titulo + " é " + Autor);
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            var quantidadePaginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;

            Console.WriteLine("Faltam sere(m) lida(s) um total de " + quantidadePaginasParaLer + " página(s).");
        }

        public void ApresentarQuantidadePaginasLidasNoTotal()
        {
            Console.WriteLine("Já foi(ram) lida(s) um total de " + QuantidadePaginasLidas + " página(s).");
        }
        
    }
}
