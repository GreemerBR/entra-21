using Entra21.ExerciciosListaObjetos.Triangulos;

namespace Entra21.ExemplosWindowsForms.Triangulos
{
    public partial class TrianguloForm : Form
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public TrianguloForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var lado1 = Convert.ToInt32(textBoxLado1.Text.Trim());
            var lado2 = Convert.ToInt32(textBoxLado1.Text.Trim());
            var lado3 = Convert.ToInt32(textBoxLado1.Text.Trim());

            var cadastrou = trianguloServico.Adicionar(lado1, lado2, lado3);

            if (cadastrou == true)
            {
                MessageBox.Show("Triângulo cadastrado com sucesso.", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar este triângulo, suas medias não são válidas.", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonListarTodos_Click(object sender, EventArgs e)
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                MessageBox.Show("Nenhum triângulo cadastrado.", "Aviso", MessageBoxButtons.OK);
            }

            var texto = "";

            for (var i = triangulos.Count(); i <= 0; i++)
            {
                var trianguloAtual = triangulos[i];

                texto = texto + $@"Código {trianguloAtual.Codigo}
Tipo: {trianguloAtual.Tipo}
";
            }

            MessageBox.Show(texto, "Lista de triângulos", MessageBoxButtons.OK);
        }
    }
}
