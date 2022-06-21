using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        //http://www.invertexto.com/fsens

        private List<Endereco> enderecos;

        // Construtor: mais pra frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();
        }

        // Método Adicionar recebe como parâmetro o objeto do endereço completo do Form(Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            // Percorre a lista de endereços afim de encontrar o endereço que deve ser alterado
            for (var i = 0; i < enderecos.Count; i++)
            {
                // Obtem o endereço da lista de endereços
                var endereco = enderecos[i];

                // Verifica se o código do endereço percorrido é o mesmo do endereço que deve ser alterado
                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    // Atualiza campos do endereço encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Endereco enderecoParaApagar)
        {
            // Percorre a lista de endereços afim de encontrar o endereço que deve ser removido
            for (var i = 0; i < enderecos.Count; i++)
            {
                // Obtem o endereço que esta sendo percorrido
                var endereco = enderecos[i];

                // Verifica se o código do endereço percorrido é o mesmo do endereço que deve ser alterado
                if (endereco.Codigo == enderecoParaApagar.Codigo)
                {
                    // Remove o endereço encontrado da lista de endereços
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }

        // Método que permite listar todos os endereços
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            // Percorre a lista de endereços afim de encontrar o endereço com o código desejado
            for (var i = 0; i < enderecos.Count; i++)
            {
                // Obtem o endereço que esta sendo percorrido
                var endereco = enderecos[i];

                // Verifica se o endereço contém o código desejado
                if (endereco.Codigo == codigo)
                    return endereco;
            }

            // Retorna null pois não encontrou o endereço com o código desejado
            return null;
        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json", enderecosEmJson);
        }

        public void LerArquivo()
        {
            // Verifica se o endereço não existe
            if (File.Exists("enderecos.json") == false)
                return;

            // Ler o arquivo JSON e converte para uma lista de objetos de endereços
            var enderecoEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecoEmJson);
        }
    }
}