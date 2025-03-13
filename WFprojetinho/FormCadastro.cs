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
        public void erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            string semMascara = mkbTelefone.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace("-", "")
                .Replace(" ", "");
                
            void txtNomeCompleto_TextChanged(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    erro("Nome é obrigatório"); return;
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    erro("Campo Sobrenome esta vazio "); return;
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    erro("Campo Telefone esta vazio "); return;
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    erro("Campo Email esta vazio "); return;
                }
                else if (!rdbComercial.Checked || !rdbPessoal.Checked || !rdbRecado.Checked)
                {
                    erro("deve se marcar uma opção de tipo telefone"); return;
                }

                string tipoTelefone = "";

                if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked) 
                {
                    erro("deve se marcar um tipo de telefone!"); return;
                }
                {
                    string dddTelefone =
                        "(" + mkbTelefone.Text.Substring(0, 2) + ") "
                        + mkbTelefone.Text.Substring(2, 5)
                        + "-" + mkbTelefone.Text.Substring(7);

                    string mensagem = $@"Nome completo: {txtNome.Text} {txtSobrenome} 
                    tipo telefone: {gbxTipoTelefone}
                    DddTelefone: {lblDddTelefone.Text}
                    Email: {txtEmail.Text}";

                    sucesso(mensagem);

                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            Button btnCadastrar = new Button();

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                MessageBox.Show("cadastro feito com sucesso");
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Button btnVoltar = new Button();

        }
    }
}
