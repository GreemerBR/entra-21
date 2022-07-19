using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface ITipoPersonagemService
    {
        void Cadastrar(TipoPersonagem tipoPersonagem);

        List<TipoPersonagem> ObterTodos();

        void Apagar(int id);

        TipoPersonagem ObterPorId(int id);

        void Editar(TipoPersonagem tipoPersonagem);
    }
}
