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
    public partial class FormGerenciarAlunos : Form
    {
        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        private void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
            txtRaAluno.Width = 633;
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
                panel3.Visible = true;
                panel5.Visible = true;
                panel2.Visible = true;
                panel2.BringToFront();
                panel4.Visible = false;
                panel7.Visible = false;
               
            }
            else if (panel2.Visible == true)
            {
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
                
            }
        }

        private void lblAlunos_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {
                panel4.Visible = true;
                panel4.BringToFront();
                panel7.Visible = true;
                panel7.BringToFront();
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
                
            }
            else if (panel7.Visible == true)
            {
                panel4.Visible = false;
                panel7.Visible = false;
             
            }
        }

        private void txtRaAluno_Enter(object sender, EventArgs e)
        {

            if (txtRaAluno.PlaceholderText == "RA do aluno")
            {
                txtRaAluno.PlaceholderText = "";
                txtRaAluno.ForeColor = Color.Black;
            }

            if (txtEmailAluno.Text == "")
            {
                txtEmailAluno.PlaceholderText = "E-mail do aluno";
            }

            if (txtPrimeiroNome.Text == "")
            {
                txtPrimeiroNome.PlaceholderText = "Primeiro nome";
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último nome";
            }
        }

        private void txtEmailAluno_Enter(object sender, EventArgs e)
        {
            if (txtRaAluno.Text == "")
            {
                txtRaAluno.PlaceholderText = "RA do aluno";
            }

            if (txtEmailAluno.PlaceholderText == "E-mail do aluno")
            {
                txtEmailAluno.PlaceholderText = "";
                txtEmailAluno.ForeColor = Color.Black;
            }

            if (txtPrimeiroNome.Text == "")
            {
                txtPrimeiroNome.PlaceholderText = "Primeiro nome";
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último nome";
            }
        }

        private void txtPrimeiroNome_Enter(object sender, EventArgs e)
        {
            if (txtRaAluno.Text == "")
            {
                txtRaAluno.PlaceholderText = "RA do aluno";
            }

            if (txtEmailAluno.Text == "")
            {
                txtEmailAluno.PlaceholderText = "E-mail do aluno";
            }

            if (txtPrimeiroNome.PlaceholderText == "Primeiro nome")
            {
                txtPrimeiroNome.PlaceholderText = "";
                txtPrimeiroNome.ForeColor = Color.Black;
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último nome";
            }
        }

        private void txtUltimoNome_Enter(object sender, EventArgs e)
        {
            if (txtRaAluno.Text == "")
            {
                txtRaAluno.PlaceholderText = "RA do aluno";
            }

            if (txtEmailAluno.Text == "")
            {
                txtEmailAluno.PlaceholderText = "E-mail do aluno";
            }

            if (txtPrimeiroNome.Text == "")
            {
                txtPrimeiroNome.PlaceholderText = "Primeiro nome";
            }

            if (txtUltimoNome.PlaceholderText == "Último nome")
            {
                txtUltimoNome.PlaceholderText = "";
                txtUltimoNome.ForeColor = Color.Black;
            }
        }

        private void lblEditarAluno_Click(object sender, EventArgs e)
        {
            lblGerenciamento.Text = "Editar Aluno";
            btnGerenciamento.Text = "Editar";
            txtRaAluno.Width = 450;
            btnBuscar.Visible = true;
            if (txtRaAluno.Width == 633)
            {
                txtRaAluno.Width = 450;
            }
        }

        private void lblApagarAluno_Click(object sender, EventArgs e)
        {
            lblGerenciamento.Text = "Apagar Aluno";
            btnGerenciamento.Text = "Apagar";
            btnBuscar.Visible = true;
            if (txtRaAluno.Width==633)
            {
                txtRaAluno.Width = 450;
            }
            
        }

        private void lblRegistrarAluno_Click(object sender, EventArgs e)
        {
            
            lblGerenciamento.Text = "Registrar Aluno";
            btnGerenciamento.Text = "Registrar";
            btnBuscar.Visible = false;
            txtRaAluno.Width =  633;
            txtRaAluno.Focus();
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
    }
}
