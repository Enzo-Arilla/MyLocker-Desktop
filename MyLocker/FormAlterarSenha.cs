using Refit;
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
            label1.Focus();
        }

        static async Task<Funcionario> GetFuncionario(string cpf)
        {

            var apiClient = RestService.For<IRepositorioFuncionarios>("https://mylocker-api.herokuapp.com");

            Funcionario response = await apiClient.ReturnFuncionario(cpf);

            return response;
        }

        static async Task PutPassword(UpdateFunctionaryPasswordRequest updateFunctionaryPasswordRequest)
        {
            var apiCliente = RestService.For<IRepositorioFuncionarios>("https://mylocker-api.herokuapp.com");

            await apiCliente.UpdatePassword(updateFunctionaryPasswordRequest);

            return;
            
        }

        private async void btnAlterar_Click(object sender, EventArgs e)
        {
            var Load = new Carregamento();

            string novaSenha = txtNovaSenha.Text;
            string cNovaSenha = txtConfirmarSenha.Text;
            string senhaAntiga = txtSenhaAntiga.Text;

            if (novaSenha.Trim() == "" || senhaAntiga.Trim() == "" || cNovaSenha == "" || novaSenha.Trim() == "Senha antiga" || senhaAntiga.Trim() == "Nova senha" || cNovaSenha == "Confirmar nova senha")
            {
                Load.Close();
                MyMessageBoxWarning.ShowBox("Preencha o(s) campo(s)!", "Aviso");
            }
            else if (novaSenha != cNovaSenha)
            {
                Load.Close();
                MyMessageBoxWarning.ShowBox("Você inseriu senhas diferentes!", "Aviso");
            }
            else
            {
                try
                {
                    Load.Show();

                    UpdateFunctionaryPasswordRequest update = new UpdateFunctionaryPasswordRequest(novaSenha, senhaAntiga, Usuario.Cpf, false);

                    await PutPassword(update);

                    Load.Close();

                    MyMessageBoxSucess.ShowBox("Senha alterada com sucesso!", "Sucesso");

                }
                catch (ApiException erro)
                {
                    Load.Close();
                    string[] mensagemErro = erro.Content.Split('"');
                    MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                }
            }
  
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
                lblAlunos.ForeColor = Color.White;
                lblArmarios.ForeColor = Color.FromArgb(253, 200, 0);
                panel4.Visible = true;
                panel5.Visible = true;
                panel5.BringToFront();
                panel2.Visible = true;
                panel4.Visible = false;
                guna2GradientPanel1.Visible = false;
            }
            else if (panel2.Visible == true)
            {
                lblArmarios.ForeColor = Color.White;
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
                lblAlunos.ForeColor = Color.FromArgb(253, 200, 0);
                lblArmarios.ForeColor = Color.White;
                panel4.Visible = true;
                guna2GradientPanel1.Visible = true;
                panel2.Visible = false;
            }
            else if (guna2GradientPanel1.Visible == true)
            {
                lblAlunos.ForeColor = Color.White;
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
                panel9.Visible = true;
                panel11.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                panel3.Visible = false;
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

        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDadosAlunos_Click(object sender, EventArgs e)
        {
            var FormDadosAlunos = new FormDadosAlunos();
            FormDadosAlunos.Closed += (s, args) => this.Close();
            FormDadosAlunos.Show();
            this.Hide();
        }

        private void btnGerenciarAlunos_Click(object sender, EventArgs e)
        {
            var FormGerenciarAlunos = new FormGerenciarAlunos();
            FormGerenciarAlunos.Closed += (s, args) => this.Close();
            FormGerenciarAlunos.Show();
            this.Hide();
        }
    }
}
