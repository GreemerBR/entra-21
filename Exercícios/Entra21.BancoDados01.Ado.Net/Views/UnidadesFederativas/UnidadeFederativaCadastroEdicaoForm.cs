using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public UnidadeFederativaCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }

        public UnidadeFederativaCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this()
        {
            _idParaEditar = unidadeFederativa.Id;

            textBoxNome.Text = unidadeFederativa.Nome;

            textBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var sigla = textBoxSigla.Text.Trim();

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Nome = nome;            
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadeFederativaService();

            if (_idParaEditar == -1)
            {
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa cadastrada com sucesso");
                Close();
            }
            else
            {
                unidadeFederativa.Id = _idParaEditar;
                unidadeFederativaService.Editar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa alterada com sucesso");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
