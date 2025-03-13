namespace WFprojetinho
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuPrincipal = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsSobre = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            picfoto = new PictureBox();
            MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picfoto).BeginInit();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsSobre, mnsSair });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(346, 24);
            MenuPrincipal.TabIndex = 0;
            MenuPrincipal.Text = "Nome Completo";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(66, 20);
            mnsCadastrar.Text = "Cadastro";
            mnsCadastrar.Click += nomeCompletoToolStripMenuItem_Click;
            // 
            // mnsSobre
            // 
            mnsSobre.Name = "mnsSobre";
            mnsSobre.Size = new Size(52, 20);
            mnsSobre.Text = "Sobre ";
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += sairToolStripMenuItem_Click;
            // 
            // picfoto
            // 
            picfoto.Dock = DockStyle.Fill;
            picfoto.Image = Properties.Resources.cc82128aaa8e1387b665684dd5e63b21;
            picfoto.Location = new Point(0, 24);
            picfoto.Name = "picfoto";
            picfoto.Size = new Size(346, 383);
            picfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picfoto.TabIndex = 1;
            picfoto.TabStop = false;
            picfoto.Click += pictureBox1_Click;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 407);
            Controls.Add(picfoto);
            Controls.Add(MenuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = MenuPrincipal;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picfoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipal;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsSobre;
        private ToolStripMenuItem mnsSair;
        private PictureBox picfoto;
    }
}
