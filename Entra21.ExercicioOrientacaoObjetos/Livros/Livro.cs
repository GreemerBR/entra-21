using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Livros
{
    public class Livro
    {
        public string Titulo, Autor, IdiomaOriginal, CodigoIsbn;
        public int QuantidadePaginas, QuantidadePaginasLidas, QuantidadeReleituras;
        public DateTime DataLancamento;

        public string ObterTituloAutor()
        {
            return $"{Titulo} / {Autor}";
        }

        public string ApresentarTituloAutor()
        {
            return $"Título / Autor: {ObterTituloAutor()}";
        }

        public int ObterQuantidadePaginasParaLer()
        {
            var quantidadePaginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;

            return quantidadePaginasParaLer;
        }

        public string ApresentarQuantidadePaginasParaLer()
        {
            return $"Na atual leitura do livro {Titulo}, ainda falta(m) {ObterQuantidadePaginasParaLer()} página(s) a ser(em) lida(s).";
        }

        public int ObterQuantidadePaginasLidasNoTotal()
        {
            var paginasLidasTotais = QuantidadePaginasLidas + QuantidadePaginas * QuantidadeReleituras;

            return paginasLidasTotais;
        }

        public string ApresentarQuantidadePaginasLidasNoTotal()
        {
            return $@"Já foi(ram) lida(s) {ObterQuantidadePaginasLidasNoTotal()} página(s) do livro {Titulo}.
Além disso, ele já foi relido um total de {QuantidadeReleituras} vezes.";
        }

        public int ObterQuantidadeAnosAposPublicacao()
        {
            var quantosAnosEstaPublicado = DateTime.Now.Year - DataLancamento.Year;

            return quantosAnosEstaPublicado;
        }

        public string ApresentarQuantidadeAnosAposPublicacao()
        {
            return $"O livro {Titulo} está publicado a {ObterQuantidadeAnosAposPublicacao()} ano(s).";
        }
    }
}
