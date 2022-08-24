using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using Refit;

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
            txtSenha.PasswordChar = true;
        }

        static async Task<Funcionario> GetFuncionario(string cpf)
        {
        
            var apiClient = RestService.For<IRepositorioFuncionarios>("https://mylocker-api.herokuapp.com");

            Funcionario response = await apiClient.ReturnFuncionario(cpf);

            return response;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var Carregamento = new Carregamento();

            try
            {
                Carregamento.Show();

                cpf = txtCpf.Text;
                senha = txtSenha.Text;

                Funcionario funcionario = await GetFuncionario(cpf);

                Usuario usuario = new Usuario(funcionario.First_name, funcionario.Last_name, funcionario.Email, funcionario.Cpf, funcionario.Status);


                if (BC.Verify(senha, funcionario.Password))
                {
                    var FormMenu = new FormMenu();
                    FormMenu.Closed += (s, args) => this.Close();
                    FormMenu.Show();
                    this.Close();   
                    Carregamento.Close();   
                }
                else
                {
                    Carregamento.Close();
                    MyMessageBoxError.ShowBox("Você inseriu dados incorretos!", "Erro - Credênciais Incorretas");     
                }

            }
            catch (ApiException erro)
            {
                Carregamento.Close();
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
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
