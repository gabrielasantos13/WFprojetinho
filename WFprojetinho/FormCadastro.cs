using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFprojetinho
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void cbxEscolaridade_limparformulario(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtNome.Clear();
            gbxTipoTelefone.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);
            txtNomeCompleto_TextChanged(sender, e);
        }


        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            void txtNomeCompleto_TextChanged(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    btnCadastrar.Enabled = false;
                }
                else
                {
                    btnCadastrar.Enabled = true;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome completo é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
