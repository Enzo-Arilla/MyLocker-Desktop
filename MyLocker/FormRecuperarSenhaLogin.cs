using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using Refit;
using System.Text.RegularExpressions;

namespace MyLocker
{
    public partial class FormRecuperarSenhaLogin : Form
    {

        public FormRecuperarSenhaLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
            txtCodigo.PasswordChar = true;
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

        static async Task GenerateVerificationCode(GenerateFunctionaryVerificationCodeRequest generateFunctionaryVerificationCodeRequest)
        {
        
            var apiClient = RestService.For<IRepositorioFuncionarios>("https://mylocker-api.herokuapp.com");

            await apiClient.GenerateFunctionaryVerificationCode(generateFunctionaryVerificationCodeRequest);
        }

        static async Task VerifyFunctionaryCode(string cpf, string typedCode)
        {

            var apiClient = RestService.For<IRepositorioFuncionarios>("https://mylocker-api.herokuapp.com");

            await apiClient.VerifyFunctionaryCode(cpf, typedCode);
        }

        static async Task PutPassword(UpdateFunctionaryPasswordRequest updateFunctionaryPasswordRequest)
        {
            var apiCliente = RestService.For<IRepositorioFuncionarios>("https://mylocker-api.herokuapp.com");

            await apiCliente.UpdatePassword(updateFunctionaryPasswordRequest);

            return;
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.PlaceholderText == "CPF")
            {
                txtCpf.PlaceholderText = "";
                txtCpf.ForeColor = Color.Black;
            }

            if (txtCodigo.Text == "")
            {
                txtCodigo.PlaceholderText = "Código";
            }

            if(txtNovaSenha.Text == "")
            {
                txtNovaSenha.PlaceholderText = "Nova senha";
            }

        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.PlaceholderText == "Código")
            {
                txtCodigo.PlaceholderText = "";
                txtCodigo.ForeColor = Color.Black;
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }

            if (txtNovaSenha.Text == "")
            {
                txtNovaSenha.PlaceholderText = "Nova senha";
            }
        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {
            if (txtNovaSenha.PlaceholderText == "Nova senha")
            {
                txtNovaSenha.PlaceholderText = "";
                txtNovaSenha.ForeColor = Color.Black;
            }

            if (txtCpf.Text == "")
            {
                txtCpf.PlaceholderText = "CPF";
            }

            if (txtCodigo.Text == "")
            {
                txtCodigo.PlaceholderText = "Código";
            }
        }


        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            var Load = new Carregamento();

            Load.Show();

            GenerateFunctionaryVerificationCodeRequest generateFunctionaryVerificationCodeRequest = new GenerateFunctionaryVerificationCodeRequest(cleanCPF(cpf));

            Regex rg = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

            if (!rg.IsMatch(cpf))
            {
                Load.Close();
                MyMessageBoxWarning.ShowBox("O campo do CPF não foi preenchido no formato correto!", "Aviso");
            }
            else
            {
                try
                {
                    await GenerateVerificationCode(generateFunctionaryVerificationCodeRequest);
                    Load.Close();
                    btnEnviar.Visible = false;
                    btnEnviar.Location = new Point(1380, 545);
                    btnEnviar.Visible = true;
                    MyMessageBoxSucess.ShowBox("Código gerado e enviado para o e-mail cadastrado!", "Sucesso");
                    txtCodigo.Visible = true;
                    txtNovaSenha.Visible = true;
                    btnConfirmar.Visible = true;

                }
                catch (ApiException erro)
                {
                    Load.Close();
                    string[] mensagemErro = erro.Content.Split('"');
                    MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                }
            }

        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {

            string cpf = cleanCPF(txtCpf.Text);
            string codigo = txtCodigo.Text;
            string novaSenha = txtNovaSenha.Text;
            var Load = new Carregamento();
            Load.Show();

            try
            {
                await VerifyFunctionaryCode(cpf, codigo);

                UpdateFunctionaryPasswordRequest update = new UpdateFunctionaryPasswordRequest(novaSenha, null, cpf, true);
                await PutPassword(update);

                Load.Close();

                MyMessageBoxSucess.ShowBox("Senha alterada com sucesso!", "Sucesso");

                var FormLogin = new FormLogin();
                FormLogin.Closed += (s, args) => this.Close();
                FormLogin.Show();
                this.Close();

            }
            catch(ApiException erro)
            {
                string[] mensagemErro = erro.Content.Split('"');
                //txtCodigo.Visible = false;
                //txtNovaSenha.Visible = false;
               // btnConfirmar.Visible = false;
                Load.Close();
                MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var FormLogin = new FormLogin();
            FormLogin.Closed += (s, args) => this.Close();
            FormLogin.Show();
            this.Close();
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string CPF = txtCpf.Text;
            string CPFFormatado = FormatCPF(CPF);
            txtCpf.Text = CPFFormatado;
        }
    }
}
