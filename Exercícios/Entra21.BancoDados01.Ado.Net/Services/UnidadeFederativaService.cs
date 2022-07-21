using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class UnidadeFederativaService : IUnidadeFederativaService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO unidades_federativas (nome, sigla) VALUES (@NOME, @SIGLA);";

            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE unidades_federativas SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", unidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@PIB", unidadeFederativa.Sigla);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public UnidadeFederativa ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var unidadeFederativa = new UnidadeFederativa();

            unidadeFederativa.Id = Convert.ToInt32(primeiroRegistro["id"]);
            unidadeFederativa.Nome = primeiroRegistro["nome"].ToString();
            unidadeFederativa.Sigla = primeiroRegistro["sigla"].ToString();

            comando.Connection.Close();

            return unidadeFederativa;
        }

        public List<UnidadeFederativa> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var unidadesFederativas = new List<UnidadeFederativa>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var unidadeFederativa = new UnidadeFederativa();

                unidadeFederativa.Id = Convert.ToInt32(linha["id"]);
                unidadeFederativa.Nome = linha["nome"].ToString();
                unidadeFederativa.Sigla = linha["sigla"].ToString();

                unidadesFederativas.Add(unidadeFederativa);
            }

            comando.Connection.Close();

            return unidadesFederativas;
        }
    }
}
