﻿namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    partial class PersonagemCadastroEdicaoForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelEditora = new System.Windows.Forms.Label();
            this.labelTipoPersonagem = new System.Windows.Forms.Label();
            this.comboBoxEditora = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoPersonagem = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
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
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(288, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(12, 66);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(44, 15);
            this.labelEditora.TabIndex = 2;
            this.labelEditora.Text = "Editora";
            // 
            // labelTipoPersonagem
            // 
            this.labelTipoPersonagem.AutoSize = true;
            this.labelTipoPersonagem.Location = new System.Drawing.Point(12, 123);
            this.labelTipoPersonagem.Name = "labelTipoPersonagem";
            this.labelTipoPersonagem.Size = new System.Drawing.Size(115, 15);
            this.labelTipoPersonagem.TabIndex = 3;
            this.labelTipoPersonagem.Text = "Tipo de Personagem";
            // 
            // comboBoxEditora
            // 
            this.comboBoxEditora.FormattingEnabled = true;
            this.comboBoxEditora.Location = new System.Drawing.Point(12, 84);
            this.comboBoxEditora.Name = "comboBoxEditora";
            this.comboBoxEditora.Size = new System.Drawing.Size(288, 23);
            this.comboBoxEditora.TabIndex = 4;
            // 
            // comboBoxTipoPersonagem
            // 
            this.comboBoxTipoPersonagem.DisplayMember = "Tipo";
            this.comboBoxTipoPersonagem.FormattingEnabled = true;
            this.comboBoxTipoPersonagem.Location = new System.Drawing.Point(12, 141);
            this.comboBoxTipoPersonagem.Name = "comboBoxTipoPersonagem";
            this.comboBoxTipoPersonagem.Size = new System.Drawing.Size(288, 23);
            this.comboBoxTipoPersonagem.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(144, 201);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(225, 201);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // PersonagemCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 236);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxTipoPersonagem);
            this.Controls.Add(this.comboBoxEditora);
            this.Controls.Add(this.labelTipoPersonagem);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "PersonagemCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Personagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelEditora;
        private Label labelTipoPersonagem;
        private ComboBox comboBoxEditora;
        private ComboBox comboBoxTipoPersonagem;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}