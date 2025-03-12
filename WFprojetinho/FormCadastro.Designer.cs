namespace WFprojetinho
{
    partial class FormCadastro
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
            lblNome = new Label();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            txtSobrenome = new TextBox();
            lblSobrenome = new Label();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            label3 = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnVoltar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(36, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome ";
            lblNome.Click += lblNomeCompleto_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(269, 400);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 35);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Salvar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(36, 58);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(157, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNomeCompleto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 111);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(206, 58);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(157, 23);
            txtSobrenome.TabIndex = 10;
            txtSobrenome.TextChanged += textBox1_TextChanged;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(206, 30);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(68, 15);
            lblSobrenome.TabIndex = 9;
            lblSobrenome.Text = "Sobrenome";
            lblSobrenome.Click += label2_Click;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.BackColor = SystemColors.AppWorkspace;
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(36, 111);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(327, 56);
            gbxTipoTelefone.TabIndex = 11;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo de Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.ForeColor = Color.Black;
            rdbRecado.Location = new Point(222, 27);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.ForeColor = Color.Black;
            rdbComercial.Location = new Point(104, 27);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.ForeColor = Color.Black;
            rdbPessoal.Location = new Point(5, 27);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            rdbPessoal.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(5, 194);
            label3.Name = "label3";
            label3.Size = new Size(400, 1);
            label3.TabIndex = 12;
            label3.Text = "label3";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(36, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 23);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(36, 261);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "E-mail";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ActiveCaptionText;
            btnVoltar.Location = new Point(36, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 35);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(417, 489);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(label3);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobrenome);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btnCadastrar);
            Controls.Add(lblNome);
            ForeColor = Color.White;
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button btnCadastrar;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtSobrenome;
        private Label lblSobrenome;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbPessoal;
        private RadioButton rdbComercial;
        private RadioButton rdbRecado;
        private Label label3;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnVoltar;
    }
}