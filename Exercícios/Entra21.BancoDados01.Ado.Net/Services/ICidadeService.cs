using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface ICidadeService
    {
        void Cadastrar(Cidade cidade);

        List<Cidade> ObterTodos();

        void Apagar(int id);

        Cidade ObterPorId(int id);

        void Editar(Cidade cidade);
    }
}
