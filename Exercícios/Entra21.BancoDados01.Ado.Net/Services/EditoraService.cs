using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class EditoraService : IEditoraService
    {
        public List<Editora> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, apelido, data_criacao, faturamento FROM editoras";

            // Instanciado tabela em memória para armazenar os registros da consulta
            var tabelaEmMemoria = new DataTable();
            // Executa a consulta SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Cria lista para armazenar as edtoras
            var editoras = new List<Editora>();

            // Percorrido os registros retornados da consulta adicionando na lista de editoras
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var editora = new Editora();
                editora.Id = Convert.ToInt32(linha["id"]);
                editora.Nome = linha["nome"].ToString();
                editora.Apelido = linha["apelido"].ToString();
                editora.DataCriacao = Convert.ToDateTime(linha["data_criacao"]);
                editora.Faturamento = Convert.ToDecimal(linha["faturamento"]);

                editoras.Add(editora);
            }

            // Fechar a conexão
            conexao.Close();

            return editoras;
        }
    }
}
