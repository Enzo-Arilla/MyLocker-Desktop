using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refit;

namespace MyLocker
{
    public partial class FormCadastro : Form
    {
        string primeiroNome, ultimoNome, email, cpf, senha, cSenha;
        int status;

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
        }

        public string FormatCPF(string sender)
        {
            string response = sender.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            return response;
        }

        public string cleanCPF(string sender)
        {
            Regex apenasDigitos = new Regex(@"[^\d]");
            return apenasDigitos.Replace(sender, "");
        }

        static async Task PostFuncionario(Funcionario funcionario)
        {
            var apiClient = RestService.For<IRepositorioFuncionarios>("http://mylocker-api.herokuapp.com");

            await apiClient.CreateFuncionario(funcionario);

            return;
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            var Load = new Carregamento();

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            Regex rg2 = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
            //Regex rg3 = new Regex(@"^[a-z][A-Z]\d$");

            try
            {
                primeiroNome = txtNome.Text;
                ultimoNome = txtUltimoNome.Text;
                email = txtEmail.Text;
                cpf = txtCpf.Text;
                senha = txtSenha.Text;
                cSenha = txtConfirmarSenha.Text;

                if(primeiroNome.Trim() == "" || ultimoNome.Trim() == "" || email.Trim() == "" || cpf.Trim() == "" || senha.Trim() == "" || cSenha.Trim() == "" || primeiroNome.Trim() == "Nome" || ultimoNome.Trim() == "Último nome" || email.Trim() == "E-mail" || cpf.Trim() == "CPF" || senha.Trim() == "Senha" || cSenha.Trim() == "Confirmar senha")
                {
                    MyMessageBoxWarning.ShowBox("Preencha o(s) campo(s)!", "Aviso");
                }
                else if(!rg.IsMatch(txtEmail.Text))
                {
                    MyMessageBoxWarning.ShowBox("O campo do e-mail não foi preenchido no formato correto!", "Aviso");
                }
                else if(!rg2.IsMatch(cpf))
                {
                    MyMessageBoxWarning.ShowBox("O campo do CPF não foi preenchido corretamente!", "Aviso");
                }
              //  else if(!rg3.IsMatch(senha))
                //{
                  //  MyMessageBoxWarning.ShowBox("A senha deve conter números, minúsculas e maiúsculas");
                //}
                else if(senha != cSenha)
                {
                    MyMessageBoxWarning.ShowBox("Você inseriu senhas diferentes!", "Aviso");
                }
                else
                {
                    Load.Show();

                    string cpf2 = cleanCPF(cpf);

                    Funcionario funcionario = new Funcionario(cpf2, primeiroNome, ultimoNome, email, senha, status);

                    await PostFuncionario(funcionario);

                    Load.Close();

                    MyMessageBoxSucess.ShowBox("Você se cadastrou com sucesso!", "Sucesso");

                    var FormLogin = new FormLogin();
                    FormLogin.Closed += (s, args) => this.Close();
                    FormLogin.Show();
                    this.Hide();
                }
            }
            catch (ApiException erro)
            {
                Load.Close();
                string[] mensagemErro = erro.Content.Split('"');
                MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {

            if (txtEmail.PlaceholderText == "E-mail")
            {
                txtEmail.PlaceholderText = "";
                txtEmail.ForeColor = Color.Black;
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }

            if (txtSenha.Text == "")
            {
                txtSenha.PlaceholderText = "Senha";
            }

            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            }

            if (txtNome.Text == "")
            {
                txtNome.PlaceholderText = "Nome";
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último Nome";
            }

        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.PlaceholderText = "E-mail";
            }

            if (txtCpf.PlaceholderText == "CPF")
            {
                txtCpf.PlaceholderText = "";
                txtCpf.ForeColor = Color.Black;
            }

            if (txtSenha.Text == "")
            {
                txtSenha.PlaceholderText = "Senha";
            }

            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            }

            if (txtNome.Text == "")
            {
                txtNome.PlaceholderText = "Nome";
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último Nome";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.PlaceholderText = "E-mail";
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }

            if (txtSenha.PlaceholderText == "Senha")
            {
                txtSenha.PlaceholderText = "";
                txtSenha.ForeColor = Color.Black;
            }

            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            }

            if (txtNome.Text == "")
            {
                txtNome.PlaceholderText = "Nome";
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último Nome";
            }

        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string CPF = txtCpf.Text;
            string CPFFormatado = FormatCPF(CPF);
            txtCpf.Text = CPFFormatado;
        }

        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.PlaceholderText = "E-mail";
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }

            if (txtSenha.Text == "")
            {
                txtSenha.PlaceholderText = "Senha";
            }

            if (txtConfirmarSenha.PlaceholderText == "Confirmar Senha")
            {
                txtConfirmarSenha.PlaceholderText = "";
                txtConfirmarSenha.ForeColor = Color.Black;
            }

            if (txtNome.Text == "")
            {
                txtNome.PlaceholderText = "Nome";
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último Nome";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var FormLogin = new FormLogin();
            FormLogin.Closed += (s, args) => this.Close();
            FormLogin.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.PlaceholderText = "E-mail";
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }

            if (txtSenha.Text == "")
            {
                txtSenha.PlaceholderText = "Senha";
            }

            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            }

            if (txtNome.PlaceholderText == "Nome")
            {
                txtNome.PlaceholderText = "";
                txtNome.ForeColor = Color.Black;
            }

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último Nome";
            }

        }

        private void txtUltimoNome_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.PlaceholderText = "E-mail";
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }

            if (txtSenha.Text == "")
            {
                txtSenha.PlaceholderText = "Senha";
            }

            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            }

            if (txtNome.Text == "")
            {
                txtNome.PlaceholderText = "Nome";
            }

            if (txtUltimoNome.PlaceholderText == "Último Nome")
            {
                txtUltimoNome.PlaceholderText = "";
                txtUltimoNome.ForeColor = Color.Black;
            }
        }

    }
}
