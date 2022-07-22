using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        private readonly UnidadeFederativaService _unidadeFederativaService;

        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();

            _unidadeFederativaService = new UnidadeFederativaService();

            PreencherDataGridViewComUnidadesFederativas();
        }

        private void PreencherDataGridViewComUnidadesFederativas()
        {
            var unidadesFederativas = _unidadeFederativaService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Nome,
                    unidadeFederativa.Sigla
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma unidade federativa para apagar!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar a unidade federativa?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("A unidade federativa permanece na lista!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _unidadeFederativaService.Apagar(id);

                PreencherDataGridViewComUnidadesFederativas();

                MessageBox.Show("Unidade federativa removida com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma unidade federativa para editar!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var unidadeFederativa = _unidadeFederativaService.ObterPorId(id);

            var unidadeFederativaCadastroForm = new UnidadeFederativaCadastroEdicaoForm(unidadeFederativa);

            unidadeFederativaCadastroForm.ShowDialog();

            PreencherDataGridViewComUnidadesFederativas();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm();
            unidadeFederativaForm.ShowDialog();

            PreencherDataGridViewComUnidadesFederativas();
        }
    }
}
