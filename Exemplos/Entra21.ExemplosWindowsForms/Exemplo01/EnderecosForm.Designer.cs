namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    partial class EnderecosForm
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
            this.labelEnderecos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCep = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnderecos
            // 
            this.labelEnderecos.AutoSize = true;
            this.labelEnderecos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnderecos.Location = new System.Drawing.Point(16, 13);
            this.labelEnderecos.Name = "labelEnderecos";
            this.labelEnderecos.Size = new System.Drawing.Size(70, 17);
            this.labelEnderecos.TabIndex = 0;
            this.labelEnderecos.Text = "Endereços";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnEnderecoCompleto,
            this.ColumnCep,
            this.ColumnPaciente});
            this.dataGridView1.Location = new System.Drawing.Point(16, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(614, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnEnderecoCompleto
            // 
            this.ColumnEnderecoCompleto.HeaderText = "Endereço Completo";
            this.ColumnEnderecoCompleto.MinimumWidth = 25;
            this.ColumnEnderecoCompleto.Name = "ColumnEnderecoCompleto";
            this.ColumnEnderecoCompleto.ReadOnly = true;
            this.ColumnEnderecoCompleto.Width = 300;
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            // 
            // ColumnPaciente
            // 
            this.ColumnPaciente.HeaderText = "Paciente";
            this.ColumnPaciente.Name = "ColumnPaciente";
            this.ColumnPaciente.ReadOnly = true;
            this.ColumnPaciente.Width = 180;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCep.Location = new System.Drawing.Point(664, 37);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(31, 17);
            this.labelCep.TabIndex = 2;
            this.labelCep.Text = "CEP";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(664, 55);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxCep.TabIndex = 3;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(664, 93);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(126, 17);
            this.labelEnderecoCompleto.TabIndex = 4;
            this.labelEnderecoCompleto.Text = "Endereço completo";
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(664, 111);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(362, 23);
            this.textBoxEnderecoCompleto.TabIndex = 5;
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPaciente.Location = new System.Drawing.Point(664, 149);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(60, 17);
            this.labelPaciente.TabIndex = 6;
            this.labelPaciente.Text = "Paciente";
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(555, 13);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(474, 13);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(664, 167);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(360, 23);
            this.comboBoxPaciente.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(954, 238);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(873, 238);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // EnderecosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 294);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelEnderecos);
            this.Name = "EnderecosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereços";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEnderecos;
        private DataGridView dataGridView1;
        private Label labelCep;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelEnderecoCompleto;
        private TextBox textBoxEnderecoCompleto;
        private Label labelPaciente;
        private Button buttonApagar;
        private Button buttonEditar;
        private ComboBox comboBoxPaciente;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnEnderecoCompleto;
        private DataGridViewTextBoxColumn ColumnCep;
        private DataGridViewTextBoxColumn ColumnPaciente;
    }
}