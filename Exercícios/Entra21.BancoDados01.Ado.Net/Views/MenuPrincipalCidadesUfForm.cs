using Entra21.BancoDados01.Ado.Net.Views.Cidades;
using Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas;

namespace Entra21.BancoDados01.Ado.Net.Views
{
    public partial class MenuPrincipalCidadesUfForm : Form
    {
        public MenuPrincipalCidadesUfForm()
        {
            InitializeComponent();
        }

        private void buttonCidade_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeListagemForm();
            cidadeForm.ShowDialog();
        }

        private void buttonUnidadeFederativa_Click(object sender, EventArgs e)
        {
            var unidadeFederativaForm = new UnidadeFederativaListagemForm();
            unidadeFederativaForm.ShowDialog();
        }
    }
}
