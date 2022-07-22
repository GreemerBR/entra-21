namespace Entra21.BancoDados01.Ado.Net.Views
{
    partial class MenuPrincipalCidadesUfForm
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
            this.buttonCidade = new System.Windows.Forms.Button();
            this.buttonUnidadeFederativa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCidade
            // 
            this.buttonCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCidade.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCidade.Image = global::Entra21.BancoDados01.Ado.Net.Properties.Resources.cidade;
            this.buttonCidade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCidade.Location = new System.Drawing.Point(12, 12);
            this.buttonCidade.Name = "buttonCidade";
            this.buttonCidade.Size = new System.Drawing.Size(133, 106);
            this.buttonCidade.TabIndex = 0;
            this.buttonCidade.Text = "CIDADE";
            this.buttonCidade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCidade.UseVisualStyleBackColor = true;
            this.buttonCidade.Click += new System.EventHandler(this.buttonCidade_Click);
            // 
            // buttonUnidadeFederativa
            // 
            this.buttonUnidadeFederativa.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUnidadeFederativa.Image = global::Entra21.BancoDados01.Ado.Net.Properties.Resources.amazonas;
            this.buttonUnidadeFederativa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUnidadeFederativa.Location = new System.Drawing.Point(160, 12);
            this.buttonUnidadeFederativa.Name = "buttonUnidadeFederativa";
            this.buttonUnidadeFederativa.Size = new System.Drawing.Size(133, 106);
            this.buttonUnidadeFederativa.TabIndex = 1;
            this.buttonUnidadeFederativa.Text = "UNIDADE FEDERATIVA";
            this.buttonUnidadeFederativa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUnidadeFederativa.UseVisualStyleBackColor = true;
            this.buttonUnidadeFederativa.Click += new System.EventHandler(this.buttonUnidadeFederativa_Click);
            // 
            // MenuPrincipalCidadesUfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 137);
            this.Controls.Add(this.buttonUnidadeFederativa);
            this.Controls.Add(this.buttonCidade);
            this.Name = "MenuPrincipalCidadesUfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCidade;
        private Button buttonUnidadeFederativa;
    }
}