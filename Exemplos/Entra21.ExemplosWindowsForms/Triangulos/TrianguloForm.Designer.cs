namespace Entra21.ExemplosWindowsForms.Triangulos
{
    partial class TrianguloForm
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
            this.labelLado1 = new System.Windows.Forms.Label();
            this.textBoxLado1 = new System.Windows.Forms.TextBox();
            this.labelLado2 = new System.Windows.Forms.Label();
            this.textBoxLado2 = new System.Windows.Forms.TextBox();
            this.labelLado3 = new System.Windows.Forms.Label();
            this.textBoxLado3 = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonListarTodos = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.buttonApresentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLado1
            // 
            this.labelLado1.AutoSize = true;
            this.labelLado1.Location = new System.Drawing.Point(12, 9);
            this.labelLado1.Name = "labelLado1";
            this.labelLado1.Size = new System.Drawing.Size(108, 15);
            this.labelLado1.TabIndex = 0;
            this.labelLado1.Text = "Tamanho do lado 1";
            // 
            // textBoxLado1
            // 
            this.textBoxLado1.Location = new System.Drawing.Point(12, 37);
            this.textBoxLado1.Name = "textBoxLado1";
            this.textBoxLado1.Size = new System.Drawing.Size(191, 23);
            this.textBoxLado1.TabIndex = 1;
            // 
            // labelLado2
            // 
            this.labelLado2.AutoSize = true;
            this.labelLado2.Location = new System.Drawing.Point(12, 73);
            this.labelLado2.Name = "labelLado2";
            this.labelLado2.Size = new System.Drawing.Size(108, 15);
            this.labelLado2.TabIndex = 2;
            this.labelLado2.Text = "Tamanho do lado 2";
            // 
            // textBoxLado2
            // 
            this.textBoxLado2.Location = new System.Drawing.Point(12, 101);
            this.textBoxLado2.Name = "textBoxLado2";
            this.textBoxLado2.Size = new System.Drawing.Size(191, 23);
            this.textBoxLado2.TabIndex = 3;
            // 
            // labelLado3
            // 
            this.labelLado3.AutoSize = true;
            this.labelLado3.Location = new System.Drawing.Point(12, 137);
            this.labelLado3.Name = "labelLado3";
            this.labelLado3.Size = new System.Drawing.Size(108, 15);
            this.labelLado3.TabIndex = 4;
            this.labelLado3.Text = "Tamanho do lado 3";
            // 
            // textBoxLado3
            // 
            this.textBoxLado3.Location = new System.Drawing.Point(12, 165);
            this.textBoxLado3.Name = "textBoxLado3";
            this.textBoxLado3.Size = new System.Drawing.Size(191, 23);
            this.textBoxLado3.TabIndex = 5;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.Location = new System.Drawing.Point(265, 9);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(103, 47);
            this.buttonCadastrar.TabIndex = 6;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Yellow;
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(265, 98);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(103, 47);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Red;
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(265, 187);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(103, 47);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            // 
            // buttonListarTodos
            // 
            this.buttonListarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonListarTodos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListarTodos.Location = new System.Drawing.Point(12, 277);
            this.buttonListarTodos.Name = "buttonListarTodos";
            this.buttonListarTodos.Size = new System.Drawing.Size(191, 47);
            this.buttonListarTodos.TabIndex = 9;
            this.buttonListarTodos.Text = "Listar todos";
            this.buttonListarTodos.UseVisualStyleBackColor = false;
            this.buttonListarTodos.Click += new System.EventHandler(this.buttonListarTodos_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 201);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(46, 15);
            this.labelCodigo.TabIndex = 10;
            this.labelCodigo.Text = "Código";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 229);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(191, 23);
            this.textBoxCodigo.TabIndex = 11;
            // 
            // buttonApresentar
            // 
            this.buttonApresentar.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonApresentar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApresentar.Location = new System.Drawing.Point(265, 276);
            this.buttonApresentar.Name = "buttonApresentar";
            this.buttonApresentar.Size = new System.Drawing.Size(103, 45);
            this.buttonApresentar.TabIndex = 12;
            this.buttonApresentar.Text = "Apresentar";
            this.buttonApresentar.UseVisualStyleBackColor = false;
            // 
            // TrianguloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 336);
            this.Controls.Add(this.buttonApresentar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.buttonListarTodos);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxLado3);
            this.Controls.Add(this.labelLado3);
            this.Controls.Add(this.textBoxLado2);
            this.Controls.Add(this.labelLado2);
            this.Controls.Add(this.textBoxLado1);
            this.Controls.Add(this.labelLado1);
            this.Name = "TrianguloForm";
            this.Text = "Cadastrador de triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLado1;
        private TextBox textBoxLado1;
        private Label labelLado2;
        private TextBox textBoxLado2;
        private Label labelLado3;
        private TextBox textBoxLado3;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonListarTodos;
        private Label labelCodigo;
        private TextBox textBoxCodigo;
        private Button buttonApresentar;
    }
}