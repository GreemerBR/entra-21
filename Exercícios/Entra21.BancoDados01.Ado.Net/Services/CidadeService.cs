using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class CidadeService : ICidadeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO cidades (id_tipo_personagem, id_editora, nome) " +
                "VALUES (@ID_TIPO_PERSONAGEM, @ID_EDITORA, @NOME);";

            comando.Parameters.AddWithValue("@ID_TIPO_PERSONAGEM", personagem.TipoPersonagem.Id);
            comando.Parameters.AddWithValue("@ID_EDITORA", personagem.Editora.Id);
            comando.Parameters.AddWithValue("@NOME", personagem.Nome);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Cidade cidade)
        {
            throw new NotImplementedException();
        }

        public Cidade ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cidade> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
