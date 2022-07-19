﻿using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    // Dois pontos seguido de uma interface quer dizer que a classe será obrigada a implemenatr os métodos(contratos) estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            // Conectar com o bd
            var conexao = new Conexao().Conectar();

            // Criar comando para executar o delete
            var comando = conexao.CreateCommand();

            // Definido o comando para apagar o registro
            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            // Executado o comando para apagar o registro
            comando.ExecuteNonQuery();

            // Fechar conexão com o bd
            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            // Será descrito a implementação do contrato definido na interface

            // Criando conexão com o Banco de Dados e aberta a conexão
            var conexao = new Conexao().Conectar();

            // Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            // Especificando o comando que será executado
            comando.CommandText =
                "INSERT INTO tipos_personagens (tipo) VALUES (@TIPO)";

            comando.Parameters.AddWithValue("@TIPO", tipoPersonagem.Tipo);

            // Executando o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(TipoPersonagem tipoPersonagem)
        {
            var conexao = new Conexao().Conectar();

            // Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE tipos_personagens SET tipo = @TIPO WHERE id = @ID";

            comando.Parameters.AddWithValue("@TIPO", tipoPersonagem.Tipo);
            comando.Parameters.AddWithValue("@ID", tipoPersonagem.Id);

            // Executa o UPDATE na tabela de tipos_personagens
            comando.ExecuteNonQuery();

            // Fechar conexão
            comando.Connection.Close();
        }

        public TipoPersonagem ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            // Conectado no bando de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, tipo FROM tipos_personagens WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            // Instanciado tabela em memória para armazenar os registros retornados da consulta SELECT
            var tabelaEmMemoria = new DataTable();

            // Executado a consulta na tabela de tipos_personagens armazenando-os na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tipoPersonagem = new TipoPersonagem();
            // Obter a primeira coluna do select que é o id
            tipoPersonagem.Id = Convert.ToInt32(primeiroRegistro["id"]);
            // Obter a primeira coluna do select que é o tipo
            tipoPersonagem.Tipo = primeiroRegistro["tipo"].ToString();

            // Fechar a conexão
            comando.Connection.Close();

            return tipoPersonagem;
        }

        public List<TipoPersonagem> ObterTodos()
        {
            // Criando conexão com o Banco de Dados e aberta a conexão
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            // Criado tabela em memória para posteriormente carregar os registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            // Carregado na tabela em memória os registros encontrados com o comando SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criado uma lista para armazenar os registros da consulta do SELECT
            var tiposPersonagens = new List<TipoPersonagem>();

            // Percorrido cada um dos registros da tabelaEmMemoria (registros do SELECT)
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                // Instanciado objeto da classe TipoPersonagem preenchendo com as informações do SELECT, da linha que está sendo percorrida
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                // Adicionado tipoPersonagem instanciado na lista de TiposPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }

            // Fechado a conexão com o banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }
    }
}