using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLocker
{
    public partial class FormAlterarSenha : Form
    {
        public FormAlterarSenha()
        {
            InitializeComponent();
        }

        private void FormAlterarSenha_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
        }

        private void btnTrocarPerfil_Click(object sender, EventArgs e)
        {
            var FormLogin = new FormLogin();
            FormLogin.Closed += (s, args) => this.Close();
            FormLogin.Show();
            this.Hide();
        }

        private void btnFecharAplicativo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblArmarios_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel4.Visible = true;
                panel5.Visible = true;
                panel5.BringToFront();
                panel2.Visible = true;
                panel4.Visible = false;
                guna2GradientPanel1.Visible = false;
            }
            else if (panel2.Visible == true)
            {
                label1.Visible = true;
                panel5.Visible = false;
                panel2.Visible = false;
                guna2GradientPanel1.Visible = false;
            }
        }

        private void lblAlunos_Click(object sender, EventArgs e)
        {

            if (guna2GradientPanel1.Visible == false)
            {
                panel4.Visible = true;
                guna2GradientPanel1.Visible = true;
                panel2.Visible = false;
            }
            else if (guna2GradientPanel1.Visible == true)
            {
                guna2GradientPanel1.Visible = false;
                panel4.Visible = false;
                panel2.Visible = false;
            }
        }

        private void lblApm_Click(object sender, EventArgs e)
        {
            var FormApm = new FormApm();
            FormApm.Closed += (s, args) => this.Close();
            FormApm.Show();
            this.Hide();
        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
                panel3.BringToFront();
                panel8.Visible = true;
                panel9.Visible = true;
                panel11.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                panel3.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel11.Visible = false;
            }
        }

        private void btnAlugarAmario_Click(object sender, EventArgs e)
        {
            var FormAlugarArmario = new FormAlugarArmario();
            FormAlugarArmario.Closed += (s, args) => this.Close();
            FormAlugarArmario.Show();
            this.Hide();
        }

        private void btnDadosArmarios_Click(object sender, EventArgs e)
        {
            var FormDadosArmarios = new FormDadosArmarios();
            FormDadosArmarios.Closed += (s, args) => this.Close();
            FormDadosArmarios.Show();
            this.Hide();
        }

        private void btnDesocuparArmario_Click(object sender, EventArgs e)
        {
            var FormDesocuparArmario = new FormDesocuparArmario();
            FormDesocuparArmario.Closed += (s, args) => this.Close();
            FormDesocuparArmario.Show();
            this.Hide();
        }

        private void btnDadosAlunos_Click(object sender, EventArgs e)
        {

        }

        private void btnGerenciarAlunos_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {

        }

        private void myCustomDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            

        }

        private void txtSenhaAntiga_Enter(object sender, EventArgs e)
        {
            if (txtSenhaAntiga.PlaceholderText == "Senha antiga")
            {
                txtSenhaAntiga.PlaceholderText = "";
                txtSenhaAntiga.ForeColor = Color.Black;
            }

            if (txtNovaSenha.Text == "")
            {
                txtNovaSenha.PlaceholderText = "Nova senha";
            }

            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.PlaceholderText = "Confirmar nova senha";
            }
        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {
            if(txtSenhaAntiga.Text == "")
            {
                txtSenhaAntiga.PlaceholderText = "Senha antiga";
            }

            if(txtNovaSenha.PlaceholderText == "Nova senha")
            {
                txtNovaSenha.PlaceholderText = "";
                txtNovaSenha.ForeColor = Color.Black;
            }

            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.PlaceholderText = "Confirmar nova senha";
            }
        }

        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenhaAntiga.Text == "")
            {
                txtSenhaAntiga.PlaceholderText = "Senha antiga";
            }

            if (txtNovaSenha.Text == "")
            {
                txtNovaSenha.PlaceholderText = "Nova senha";
            }

            if (txtConfirmarSenha.PlaceholderText == "Confirmar nova senha")
            {
                txtConfirmarSenha.PlaceholderText = "";
                txtConfirmarSenha.ForeColor = Color.Black;
            }
        }

      
    }
}
