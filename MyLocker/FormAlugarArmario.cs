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
    public partial class FormAlugarArmario : Form
    {
        public FormAlugarArmario()
        {
            InitializeComponent();
        }

        private void FormAlugarArmario_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
        }

        private void btnGerenciarAlunos_Click(object sender, EventArgs e)
        {
            var FormGerenciarAlunos = new FormGerenciarAlunos();
            FormGerenciarAlunos.Closed += (s, args) => this.Close();
            FormGerenciarAlunos.Show();
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

        private void btnTrocarPerfil_Click(object sender, EventArgs e)
        {
            var FormLogin = new FormLogin();
            FormLogin.Closed += (s, args) => this.Close();
            FormLogin.Show();
            this.Hide();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            var FormAlterarSenha = new FormAlterarSenha();
            FormAlterarSenha.Closed += (s, args) => this.Close();
            FormAlterarSenha.Show();
            this.Hide();
        }

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            var FormAlterarFoto = new FormAlterarFoto();
            FormAlterarFoto.Closed += (s, args) => this.Close();
            FormAlterarFoto.Show();
            this.Hide();
        }

        private void btnFecharAplicativo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
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


        private void lblArmarios_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel4.Visible = true;
                panel5.Visible = true;
                panel5.BringToFront();
                panel2.Visible = true;
                panel4.Visible = false;
                panel7.Visible = false;
            }
            else if (panel2.Visible == true)
            {
                lblAlugarArmario.Visible = true;
                panel5.Visible = false;
                panel2.Visible = false;
                panel7.Visible = false;
            }
        }

        private void lblAlunos_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel2.Visible = false;
            }
            else if (panel7.Visible == true)
            {
                panel7.Visible = false;
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

        private void txtRaAluno_Enter(object sender, EventArgs e)
        {
            if (txtRaAluno.PlaceholderText == "RA do Aluno")
            {
                txtRaAluno.PlaceholderText = "";
                txtRaAluno.ForeColor = Color.Black;
            }

            if (txtNumeroArmario.Text == "")
            {
                txtNumeroArmario.PlaceholderText = "Número do Armário";
            }
        }

        private void txtNumeroArmario_Enter(object sender, EventArgs e)
        {
            if (txtNumeroArmario.PlaceholderText == "Número do Armário")
            {
                txtNumeroArmario.PlaceholderText = "";
                txtNumeroArmario.ForeColor = Color.Black;
            }

            if (txtRaAluno.Text == "")
            {
                txtRaAluno.PlaceholderText = "RA do Aluno";
            }

        }

        private void txtNumeroArmario__TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroArmario.Text == Convert.ToString(832))
            {
                btnDisponibilidade.Visible = true;
                lblResultadoAndar.Visible = true;
                lblResultadoCor.Visible = true;
                lblResultadoSalaEsquerda.Visible = true;
                lblResultadoSalaDireita.Visible = true;
                lblResultadoSituacao.Visible = true;
                //guna2Button2.Visible = true;
            }
            else
            {
                btnDisponibilidade.Visible = false;
                lblResultadoAndar.Visible = false;
                lblResultadoCor.Visible = false;
                lblResultadoSalaEsquerda.Visible = false;
                lblResultadoSalaDireita.Visible = false;
                lblResultadoSituacao.Visible = false;
                //guna2Button2.Visible = false;
            }
        }

        
        private void cbPossuiApm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPossuiApm_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            if (txtNumeroArmario.Text == "" || txtRaAluno.Text == "" || txtNumeroArmario.PlaceholderText == "Número do Armário" || txtRaAluno.PlaceholderText == "RA do Aluno")
            {
                MyMessageBoxError.ShowBox("Preencher todos os campos antes de efetuar a locação.", "Campos obrigatórios não preenchidos!");
            }
            
        }

    }
}
