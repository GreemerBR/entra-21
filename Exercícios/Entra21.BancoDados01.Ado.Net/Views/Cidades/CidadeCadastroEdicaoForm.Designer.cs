namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    partial class CidadeCadastroEdicaoForm
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
            this.labelQuantidadeHabitantes = new System.Windows.Forms.Label();
            this.labelPib = new System.Windows.Forms.Label();
            this.labelUf = new System.Windows.Forms.Label();
            this.labelDataHoraFundacao = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeHabitantes = new System.Windows.Forms.TextBox();
            this.textBoxPib = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataHoraFundacao = new System.Windows.Forms.DateTimePicker();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxUnidadeFederativa = new System.Windows.Forms.ComboBox();
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
            // labelQuantidadeHabitantes
            // 
            this.labelQuantidadeHabitantes.AutoSize = true;
            this.labelQuantidadeHabitantes.Location = new System.Drawing.Point(12, 74);
            this.labelQuantidadeHabitantes.Name = "labelQuantidadeHabitantes";
            this.labelQuantidadeHabitantes.Size = new System.Drawing.Size(143, 15);
            this.labelQuantidadeHabitantes.TabIndex = 1;
            this.labelQuantidadeHabitantes.Text = "Quantidade de habitantes";
            // 
            // labelPib
            // 
            this.labelPib.AutoSize = true;
            this.labelPib.Location = new System.Drawing.Point(216, 74);
            this.labelPib.Name = "labelPib";
            this.labelPib.Size = new System.Drawing.Size(24, 15);
            this.labelPib.TabIndex = 2;
            this.labelPib.Text = "PIB";
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Location = new System.Drawing.Point(304, 9);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(21, 15);
            this.labelUf.TabIndex = 3;
            this.labelUf.Text = "UF";
            // 
            // labelDataHoraFundacao
            // 
            this.labelDataHoraFundacao.AutoSize = true;
            this.labelDataHoraFundacao.Location = new System.Drawing.Point(113, 146);
            this.labelDataHoraFundacao.Name = "labelDataHoraFundacao";
            this.labelDataHoraFundacao.Size = new System.Drawing.Size(140, 15);
            this.labelDataHoraFundacao.TabIndex = 4;
            this.labelDataHoraFundacao.Text = "Data e Hora da Fundação";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(10, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(276, 23);
            this.textBoxNome.TabIndex = 6;
            // 
            // textBoxQuantidadeHabitantes
            // 
            this.textBoxQuantidadeHabitantes.Location = new System.Drawing.Point(10, 101);
            this.textBoxQuantidadeHabitantes.Name = "textBoxQuantidadeHabitantes";
            this.textBoxQuantidadeHabitantes.Size = new System.Drawing.Size(145, 23);
            this.textBoxQuantidadeHabitantes.TabIndex = 7;
            // 
            // textBoxPib
            // 
            this.textBoxPib.Location = new System.Drawing.Point(216, 101);
            this.textBoxPib.Name = "textBoxPib";
            this.textBoxPib.Size = new System.Drawing.Size(143, 23);
            this.textBoxPib.TabIndex = 8;
            // 
            // dateTimePickerDataHoraFundacao
            // 
            this.dateTimePickerDataHoraFundacao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerDataHoraFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataHoraFundacao.Location = new System.Drawing.Point(103, 174);
            this.dateTimePickerDataHoraFundacao.Name = "dateTimePickerDataHoraFundacao";
            this.dateTimePickerDataHoraFundacao.Size = new System.Drawing.Size(159, 23);
            this.dateTimePickerDataHoraFundacao.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(284, 242);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(203, 242);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxUnidadeFederativa
            // 
            this.comboBoxUnidadeFederativa.DisplayMember = "Sigla";
            this.comboBoxUnidadeFederativa.FormattingEnabled = true;
            this.comboBoxUnidadeFederativa.Location = new System.Drawing.Point(304, 27);
            this.comboBoxUnidadeFederativa.Name = "comboBoxUnidadeFederativa";
            this.comboBoxUnidadeFederativa.Size = new System.Drawing.Size(55, 23);
            this.comboBoxUnidadeFederativa.TabIndex = 13;
            // 
            // CidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 277);
            this.Controls.Add(this.comboBoxUnidadeFederativa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dateTimePickerDataHoraFundacao);
            this.Controls.Add(this.textBoxPib);
            this.Controls.Add(this.textBoxQuantidadeHabitantes);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelDataHoraFundacao);
            this.Controls.Add(this.labelUf);
            this.Controls.Add(this.labelPib);
            this.Controls.Add(this.labelQuantidadeHabitantes);
            this.Controls.Add(this.labelNome);
            this.Name = "CidadeCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Cidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private Label labelQuantidadeHabitantes;
        private Label labelPib;
        private Label labelUf;
        private Label labelDataHoraFundacao;
        private TextBox textBoxNome;
        private TextBox textBoxQuantidadeHabitantes;
        private TextBox textBoxPib;
        private DateTimePicker dateTimePickerDataHoraFundacao;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private ComboBox comboBoxUnidadeFederativa;
    }
}