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
    public partial class FormRecuperarSenha : Form
    {
        public FormRecuperarSenha()
        {
            InitializeComponent();
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
           
        }

        private void lblAlunos_Click(object sender, EventArgs e)
        {
  
        }

        private void lblApm_Click(object sender, EventArgs e)
        {
            var FormLogin = new FormApm();
            FormLogin.Closed += (s, args) => this.Close();
            FormLogin.Show();
            this.Hide();
        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAlugarArmario_Click(object sender, EventArgs e)
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
            var FormDadosAlunos = new FormDadosAlunos();
            FormDadosAlunos.Closed += (s, args) => this.Close();
            FormDadosAlunos.Show();
            this.Hide();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            var FormMenu = new FormMenu();
            FormMenu.Closed += (s, args) => this.Close();
            FormMenu.Show();
            this.Hide();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            var FormAlterarSenha = new FormAlterarSenha();
            FormAlterarSenha.Closed += (s, args) => this.Close();
            FormAlterarSenha.Show();
            this.Hide();
        }

        private void btnGerenciarAlunos_Click(object sender, EventArgs e)
        {
            var FormMenu = new FormGerenciarAlunos();
            FormMenu.Closed += (s, args) => this.Close();
            FormMenu.Show();
            this.Hide();
        }
    }
}
