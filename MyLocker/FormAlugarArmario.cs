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
    public partial class FormAlugarArmario : Form
    {
        public FormAlugarArmario()
        {
            InitializeComponent();
        }

        static async Task SetStudentLockerNumber(SetStudentLockerNumberRequest aluno)
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com");

            await apiClient.SetStudentLockerNumber(aluno);

            return;
        }
        static async Task SetLockerIsRented(SetLockerIsRentedRequest armario)
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api.herokuapp.com");

            await apiClient.SetLockerIsRented(armario);

            return;
        }

        static async Task<Armario> FindLockerByNumber(String lockerNumberString)
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api.herokuapp.com");

            Armario armario = await apiClient.FindLockerByNumber(lockerNumberString);

            return armario;
        }

        static async Task RentLocker(SetLockerIsRentedRequest armario, SetStudentLockerNumberRequest aluno) {
            await SetStudentLockerNumber(aluno);
            await SetLockerIsRented(armario);
        }

        public string transformHexToPlainText(string hex)
        {
            if (hex == "#FDFF97")
            {
                return "Amarelo";
            }
            else if (hex == "#FF7B7B")
            {
                return "Vermelho";
            }
            else if (hex == "#92B7FF")
            {
                return "Azul";
            }
            else if (hex == "#A6FFEA")
            {
                return "Verde Água";
            }

            return "Erro";
        }

        private async void btnAlugar_Click(object sender, EventArgs e)
        {
            var Load = new Carregamento();
            
            try
            {
                if (txtNumeroArmario.Text.Trim() == "" || txtRaAluno.Text.Trim() == "" || txtNumeroArmario.Text.Trim() == "Número do Armário" || txtRaAluno.Text.Trim() == "RA do aluno")
                {
                    Load.Show();
                    Load.Close();
                    MyMessageBoxError.ShowBox("Preencher todos os campos antes de efetuar a locação.", "Campos obrigatórios não preenchidos!");
                }
                else
                {
                    Load.Show();
                    SetLockerIsRentedRequest setLockerIsRentedRequest = new SetLockerIsRentedRequest(int.Parse(txtNumeroArmario.Text), 1);
                    SetStudentLockerNumberRequest setStudentLockerNumberRequest = new SetStudentLockerNumberRequest(txtRaAluno.Text, int.Parse(txtNumeroArmario.Text));
                    await RentLocker(setLockerIsRentedRequest, setStudentLockerNumberRequest);
                    Load.Close();
                    MyMessageBoxSucess.ShowBox("O armário foi alugado com sucesso!", "Sucesso");
                    btnAlugar.Enabled = false;
                    btnAlugar.Cursor = Cursors.Arrow;
                    txtRaAluno.Enabled = false;
                    cbPossuiApm.Enabled = false;
                    txtRaAluno.Text = "";
                    txtNumeroArmario.Text = "";
                    lblResultadoAndar.Text = "";
                    lblResultadoCor.Text = "";
                    lblResultadoSalaDireita.Text = "";
                    lblResultadoSalaEsquerda.Text = "";
                    lblResultadoSituacao.Text = "";
                    lblFoco.Focus();
                }
            }
            catch (ApiException erro)
            {
                Load.Close();
                string[] mensagemErro = erro.Content.Split('"');
                MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
            }

        }


        private void FormAlugarArmario_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
            btnDisponibilidade.FillColor = Color.Empty;
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

        private void btnFecharAplicativo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {
            if (guna2GradientPanelImgPerfil.Visible == false)
            {
                guna2GradientPanelImgPerfil.Visible = true;
                panel3.Visible = true;
                panel8.Visible = true;
            }
            else if (guna2GradientPanelImgPerfil.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel3.Visible = false;
                panel8.Visible = false;
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
                txtRaAluno.Enabled = false;
                btnAlugar.Enabled = false;
                cbPossuiApm.Enabled = false;
                btnDisponibilidade.DisabledState.FillColor = Color.Empty;
            }
        }

        private async void txtNumeroArmario_Enter(object sender, EventArgs e)
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

        private async void btnProcurar_Click(object sender, EventArgs e)
        {
            var Load = new Carregamento();
            Load.Show();

            if (txtNumeroArmario.Text.Trim() == "" || txtNumeroArmario.Text.Trim() == "Número do Armário")
            {
                Load.Close();
                MyMessageBoxWarning.ShowBox("Preencha o campo do número do armário!", "Aviso");
            }
            else
            {
                try
                {
                    Armario armario = await FindLockerByNumber(txtNumeroArmario.Text);
                    Load.Close();
                    if (armario.IsRented == 1)
                    {
                        //string situacao = armario.IsRented == 1 ? "Alugado" : "Disponível";
                        btnDisponibilidade.Visible = true;
                        btnDisponibilidade.DisabledState.FillColor = Color.Red;
                        lblResultadoAndar.Text = armario.Section.Id.ToString();
                        lblResultadoCor.Text = transformHexToPlainText(armario.Section.Color);
                        lblResultadoSalaEsquerda.Text = armario.Section.Left_room;
                        lblResultadoSalaDireita.Text = armario.Section.Right_room;
                        lblResultadoSituacao.Text = "Alugado";
                    }
                    else
                    {
                        btnDisponibilidade.Visible = true;
                        btnDisponibilidade.DisabledState.FillColor = Color.FromArgb(0, 176, 63);
                        lblResultadoAndar.Text = armario.Section.Id.ToString();
                        lblResultadoCor.Text = transformHexToPlainText(armario.Section.Color);
                        lblResultadoSalaEsquerda.Text = armario.Section.Left_room;
                        lblResultadoSalaDireita.Text = armario.Section.Right_room;
                        lblResultadoSituacao.Text = "Disponível";
                        txtRaAluno.Enabled = true;
                        cbPossuiApm.Enabled = true;
                        btnAlugar.Enabled = true;
                        btnAlugar.Cursor = Cursors.Hand;
                    }
                }
                catch (ApiException erro)
                {
                    Load.Close();
                    string[] mensagemErro = erro.Content.Split('"');
                    MyMessageBoxWarning.ShowBox(mensagemErro[3], "Aviso");
                }
            }
        }

        private void txtNumeroArmario__TextChanged(object sender, EventArgs e)
        {
            if(txtNumeroArmario.Text == "")
            {
                btnDisponibilidade.DisabledState.FillColor = Color.Empty;
                txtRaAluno.Enabled = false;
                cbPossuiApm.Enabled = false;
                btnAlugar.Enabled = false;
                txtRaAluno.PlaceholderText = "RA do Aluno";
                lblResultadoAndar.Text = "";
                lblResultadoCor.Text = "";
                lblResultadoSalaDireita.Text = "";
                lblResultadoSalaEsquerda.Text = "";
                lblResultadoSituacao.Text = "";
            }
        }
    }
}
