using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public CidadeCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxUnidadeFederativa();

            _idParaEditar = -1;
        }

        public CidadeCadastroEdicaoForm(Cidade cidade) : this()
        {
            _idParaEditar = cidade.Id;

            textBoxNome.Text = cidade.Nome;

            for (var i = 0; i < comboBoxUnidadeFederativa.Items.Count; i++)
            {
                var tipoUnidadeFederativaPercorrido = comboBoxUnidadeFederativa.Items[i] as UnidadeFederativa;

                if (tipoUnidadeFederativaPercorrido.Id == cidade.UnidadeFederativa.Id)
                {
                    comboBoxUnidadeFederativa.SelectedItem = tipoUnidadeFederativaPercorrido;
                    break;
                }
            }
        }

        public void PreencherComboBoxUnidadeFederativa()
        {
            var unidadeFederativaService = new UnidadeFederativaService();
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];
                comboBoxUnidadeFederativa.Items.Add(unidadeFederativa);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxUnidadeFederativa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Unidade Federativa");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var unidadeFederativa = comboBoxUnidadeFederativa.SelectedItem as UnidadeFederativa;
            var quantidadeHabitantes = Convert.ToInt32(textBoxQuantidadeHabitantes.Text.Trim());
            var pib = Convert.ToDouble(textBoxPib.Text.Trim());
            var dataHoraFundacao = Convert.ToDateTime(dateTimePickerDataHoraFundacao.Value);

            var cidade = new Cidade();
            cidade.Nome = nome;
            cidade.UnidadeFederativa = unidadeFederativa;
            cidade.QuantidadeHabitantes = quantidadeHabitantes;
            cidade.Pib = pib;
            cidade.DataHoraFundacao = dataHoraFundacao;

            var cidadeService = new CidadeService();

            if (_idParaEditar == -1)
            {
                cidadeService.Cadastrar(cidade);

                MessageBox.Show("Cidade cadastrada com sucesso");
                Close();
            }
            else
            {
                cidade.Id = _idParaEditar;
                cidadeService.Editar(cidade);

                MessageBox.Show("Cidade alterada com sucesso");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
