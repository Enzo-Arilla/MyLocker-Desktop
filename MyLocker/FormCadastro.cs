using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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

        static async Task PostFuncionario(Funcionario funcionario)
        {
            var apiClient = RestService.For<IRepositorioFuncionarios>("http://mylocker-backend.herokuapp.com");

            Funcionario response = await apiClient.CreateFuncionario(funcionario);

            return;
        }

        private async void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                primeiroNome = txtNome.Text;
                ultimoNome = txtUltimoNome.Text;
                email = txtEmail.Text;
                cpf = txtCpf.Text;
                senha = txtSenha.Text;
                cSenha = txtConfirmarSenha.Text;

                if (senha != cSenha)
                {
                    MyMessageBoxError.ShowBox("Você inseriu senhas diferentes!", "Erro - As senhas não estão iguais");
                }
                else
                {
                    Funcionario funcionario = new Funcionario(cpf, primeiroNome, ultimoNome, email, senha, status);
                    await PostFuncionario(funcionario);

                    //MySqlCommand register = new MySqlCommand("insert into functionary (email, first_name, last_name, cpf, password) values ('" + rjTextBox1.Text + "', '" + rjTextBox5.Text + "','" + rjTextBox6.Text + "','" + rjTextBox2.Text + "','" + rjTextBox3.Text + "')", connection);
                    //register.ExecuteNonQuery();
                    //MyMessageBox.ShowBox("Você se cadastrou com sucesso!", "Sucesso - Você cadastrou sua conta");
                    //connection.Close();

                    this.Hide();
                    var form2 = new FormLogin();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();


                }
            }
            catch (ApiException erro)
            {
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
                txtSenha.PlaceholderText = "CPF";
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
