using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonEndereco_Click(object sender, EventArgs e)
        {
            var enderecosForm = new EnderecosForm();
            enderecosForm.ShowDialog();
        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            var pacientesForm = new PacientesForm();
            pacientesForm.ShowDialog();
        }
    }
}
