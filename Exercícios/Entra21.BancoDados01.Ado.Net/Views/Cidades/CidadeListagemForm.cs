using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeListagemForm : Form
    {
        private readonly CidadeService _cidadeService;

        public CidadeListagemForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();

            PreencherDataGridViewComCidades();
        }

        private void PreencherDataGridViewComCidades()
        {
            var cidades = _cidadeService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cidade.Id,
                    cidade.Nome,
                    cidade.UnidadeFederativa.Sigla,
                    cidade.DataHoraFundacao,
                    cidade.QuantidadeHabitantes,
                    cidade.Pib
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma cidade para apagar!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar a cidade?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("A cidade permanece na lista!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {

                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _cidadeService.Apagar(id);

                PreencherDataGridViewComCidades();

                MessageBox.Show("Cidade removida com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma cidade para editar!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cidade = _cidadeService.ObterPorId(id);

            var cidadeCadastroForm = new CidadeCadastroEdicaoForm(cidade);

            cidadeCadastroForm.ShowDialog();

            PreencherDataGridViewComCidades();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeCadastroEdicaoForm();
            cidadeForm.ShowDialog();

            PreencherDataGridViewComCidades();
        }
    }
}
