using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    // Dois pontos seguido de uma interface, quer dizer que a classe
    // será obrigada a implementar os métodos(contratos) estabelecidos
    // na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            // Criado conexão com o BancoDeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            // Criar comando para executar o delete
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            // Ecetutando o comando para apagar o registro
            comando.ExecuteNonQuery();

            // Fechar conexao com o banco de dados
            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            // Será descrito a implementação do
            // contrato definido na interface

            // Criado conexão com o BancoDeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            // Criar o comando para executar o banco de dados
            SqlCommand comando = conexao.CreateCommand();

            // Expecificado o comando que será executado
            comando.CommandText = 
                "INSERT INTO tipos_personagens (tipo) VALUES ('" +
                tipoPersonagem.Tipo + "')";

            // Executando o comando de insert na tabela de tipos de personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<TipoPersonagem> ObterTodos()
        {
            // Criado conexão com o BancoDeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            // Criado tabela em memória para posteriormente carregar os
            // registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            // Carregado na tabela em memória os registros encontrados
            // com o comando SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criado uma lista para armazenar os registros da consulta do SELECT
            var tiposPersonagens = new List<TipoPersonagem>();

            // Percorrido cada um dos registros da
            // tabelaEmMemoria(registros do SELECT)
            for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                // Instanciando objeto da classe TipoPersonagem
                // Preenchendo com as informações do SELECT, da linha
                // que está sendo percorrida
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                // Adicionado tipoPersonagem instanciado na lista
                // de TiposPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }

            // Fechando a conexão com o banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }
    }
}
