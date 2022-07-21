namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    partial class UnidadeFederativaCadastroEdicaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSigla = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSigla = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(289, 9);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(32, 15);
            this.labelSigla.TabIndex = 1;
            this.labelSigla.Text = "Sigla";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(254, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxSigla
            // 
            this.textBoxSigla.Location = new System.Drawing.Point(289, 27);
            this.textBoxSigla.Name = "textBoxSigla";
            this.textBoxSigla.Size = new System.Drawing.Size(59, 23);
            this.textBoxSigla.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(273, 76);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(191, 76);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // UnidadeFederativaCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 110);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxSigla);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelSigla);
            this.Controls.Add(this.labelNome);
            this.Name = "UnidadeFederativaCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Unidade Federativa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private Label labelSigla;
        private TextBox textBoxNome;
        private TextBox textBoxSigla;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}