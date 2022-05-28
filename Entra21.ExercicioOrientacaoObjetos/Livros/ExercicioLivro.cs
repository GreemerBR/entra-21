using Entra21.ExercicioOrientacaoObjetos.TestesDeValidacaoDeInformacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetos.Livros
{
    public class ExercicioLivro
    {
        public void Executar()
        {
            var livro = new Livro();
            var nomePessoaValido = new NomesPessoasValidos();
            var numeroInteiroValido = new NumerosInteirosPositivosValidos();

            Console.WriteLine("Por favor, informe os dados solicitados abaixo: ");

            Console.Write("Título do livro: ");
            livro.Titulo = Console.ReadLine().Trim();

            Console.Write("O nome do autor do livro: ");
            livro.Autor = nomePessoaValido.ObterNome();

            Console.Write("O idioma original em que o livro foi escrito: ");
            livro.IdiomaOriginal = nomePessoaValido.ObterNome();

            Console.Write("O código ISBN do livro: ");
            livro.CodigoIsbn = Console.ReadLine().Trim();

            Console.Write("A quantidade de páginas totais do livro: ");
            livro.QuantidadePaginas = numeroInteiroValido.ObterNumeroInteiroPositivoValido();

            Console.Write("A quantidade de página(s) que já foi(ram) lida(s): ");
            livro.QuantidadePaginasLidas = numeroInteiroValido.ObterNumeroInteiroPositivoValido();

            Console.Write("A quantidade de vezes que o livro já foi relido: ");
            livro.QuantidadeReleituras = numeroInteiroValido.ObterNumeroInteiroPositivoValido();

            Console.Write("A data de lançamento do livro (dd/mm/aaaa): ");
            var dataLancamento = Console.ReadLine().Trim();
            dataLancamento = dataLancamento.Replace("/", "");
            var diaLancamento = Convert.ToInt32(dataLancamento.Substring(0, 2));
            var mesLancamento = Convert.ToInt32(dataLancamento.Substring(2, 2));
            var anoLancamento = Convert.ToInt32(dataLancamento.Substring(4, 4));
            livro.DataLancamento = new DateTime(anoLancamento, mesLancamento, diaLancamento);

            Console.Clear();
            Console.WriteLine(livro.ApresentarTituloAutor());
            Console.WriteLine(livro.ApresentarQuantidadePaginasLidasNoTotal());
            Console.WriteLine(livro.ApresentarQuantidadePaginasParaLer());
            Console.WriteLine(livro.ApresentarQuantidadeAnosAposPublicacao());
        }
    }
}