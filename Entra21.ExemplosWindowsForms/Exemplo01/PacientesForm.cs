namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private int codigo = 1;

        private int indiceLinhaSelecionada = -1;

        private int codigoSelecionado = -1;

        public PacientesForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Calcular imc
            var imc = peso / Math.Pow(altura, 2);

            // Verifica se esta em modo adição
            if (indiceLinhaSelecionada == -1)
            {
                // Adicionar linha no dataGridView do paciente
                dataGridView1.Rows.Add(new object[]{
                codigo++, nome, altura, peso, imc.ToString("F")
            });

                textBoxNome.Text = "";
                textBoxAltura.Text = "";
                textBoxPeso.Text = "";

                return;
            }      
            
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString("F");

            indiceLinhaSelecionada = -1;
            textBoxNome.Text = "";
            textBoxAltura.Text = "";
            textBoxPeso.Text = "";
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Pegar o indice da linha selecionada
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verifica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Remove a linha utilizando o índice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a informação da linha selecionada passado a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }
    }
}
