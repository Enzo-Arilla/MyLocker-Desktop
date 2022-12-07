using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using Refit;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using System.Text.RegularExpressions;

namespace MyLocker
{
    public partial class FormLogin : Form
    {
        string cpf, senha;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
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

        static async Task<Funcionario> GetFuncionario(string cpf)
        {
        
            var apiClient = RestService.For<IRepositorioFuncionarios>("https://mylocker-api.herokuapp.com");

            Funcionario response = await apiClient.ReturnFuncionario(cpf);

            return response;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var Load = new Carregamento();
            Regex rg = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

            try
            {
                Load.Show();

                cpf = txtCpf.Text;
                senha = txtSenha.Text;

                if(cpf.Trim() == "" || senha.Trim() == "" || cpf.Trim() == "CPF" || senha.Trim() == "Senha")
                {
                    Load.Close();
                    MyMessageBoxWarning.ShowBox("Preencha o(s) campo(s)!", "Aviso");
                }
                else if (!rg.IsMatch(txtCpf.Text))
                {
                    Load.Close();
                    MyMessageBoxWarning.ShowBox("O campo do CPF não foi preenchido no formato correto!", "Aviso");
                }
                else
                {
                    Funcionario funcionario = await GetFuncionario(cleanCPF(cpf));
                    Usuario usuario = new Usuario(funcionario.First_name, funcionario.Last_name, funcionario.Cpf, funcionario.Email, funcionario.Status);

                    if (BC.Verify(senha, funcionario.Password))
                    {
                        var FormMenu = new FormMenu();
                        FormMenu.Closed += (s, args) => this.Close();
                        FormMenu.Show();
                        this.Close();
                        Load.Close();
                    }
                    else
                    {
                        Load.Close();
                        MyMessageBoxError.ShowBox("Você inseriu dados de login incorretos!", "Erro");
                    }
                }
            }
            catch (ApiException erro)
            {
                Load.Close();
                string[] mensagemErro = erro.Content.Split('"');
                MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
            }
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.PlaceholderText == "CPF")
            {
                txtCpf.PlaceholderText = "";
                txtCpf.ForeColor = Color.Black;
            }

            if (txtSenha.Text == "")
            {
                txtSenha.PlaceholderText = "Senha";
                txtSenha.TextOffset = new Point(12, 0);
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.TextOffset = new Point(23, 0);
            if (txtSenha.PlaceholderText == "Senha")
            {
                txtSenha.PlaceholderText = "";
                txtSenha.ForeColor = Color.Black;
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }
        }

        private void lblCriarConta_Click(object sender, EventArgs e)
        {
            FormCadastro FormCadastro = new FormCadastro();
            FormCadastro.Show();
            this.Hide();
        }

        private void FormLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            var FormRecuperarSenha = new FormRecuperarSenhaLogin();
            FormRecuperarSenha.Closed += (s, args) => this.Close();
            FormRecuperarSenha.Show();
            this.Close();

        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string CPF = txtCpf.Text;
            string CPFFormatado = FormatCPF(CPF);
            txtCpf.Text = CPFFormatado;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = default;
            btnVer.Visible = false;
            btnEsconder.Visible = true;
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '●';
            btnVer.Visible = true;
            btnEsconder.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
