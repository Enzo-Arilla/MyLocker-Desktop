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
    public partial class FormGerenciarAlunos : Form
    {

        int controle = 0;

        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        private async void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
        }

        static async Task CreateAluno(Alunos aluno)
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com");
            await apiClient.CreateAluno(aluno);

        }

        static async Task<Alunos> FindStudentByRa(string ra)
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com");

            Alunos response = await apiClient.FindStudentByRa(ra);

            return response;
        }

        static async Task UpdateStudentInformation(Alunos aluno)
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com");
            await apiClient.UpdateStudentInformation(aluno);
        }

        static async Task ChangeStudentStatus(ChangeStudentStatusRequest changeStudentStatusRequest)
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com");
            await apiClient.ChangeStudentStatus(changeStudentStatusRequest);
        }

        public void limparCampos(bool limparRa = true)
        {
            if(limparRa)
            {
                txtRa2Aluno.Text = "";
                txtRa2Aluno.PlaceholderText = "RA do aluno";
                lblFoco.Focus();
            }
            txtRaAluno.Text = "";
            txtPrimeiroNome.Text = "";
            txtUltimoNome.Text = "";
            txtEmailAluno.Text = "";
            txtUltimoNome.PlaceholderText = "Último nome";
            txtPrimeiroNome.PlaceholderText = "Primeiro nome";
            txtEmailAluno.PlaceholderText = "E-mail do aluno";
            txtRaAluno.PlaceholderText = "RA do aluno";

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

        private void txtRa2Aluno_Enter(object sender, EventArgs e)
        {
            controle = 0;

            if (txtRa2Aluno.PlaceholderText == "RA do aluno")
            {
                txtRa2Aluno.PlaceholderText = "";
                txtRa2Aluno.ForeColor = Color.Black;
            }

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

            if (txtUltimoNome.Text == "")
            {
                txtUltimoNome.PlaceholderText = "Último nome";
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

            if(txtRa2Aluno.Text == "")
            {
                txtRa2Aluno.PlaceholderText = "RA do aluno";
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

            if (txtRa2Aluno.Text == "")
            {
                txtRa2Aluno.PlaceholderText = "RA do aluno";
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

            if (txtRa2Aluno.Text == "")
            {
                txtRa2Aluno.PlaceholderText = "RA do aluno";
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

            if (txtRa2Aluno.Text == "")
            {
                txtRa2Aluno.PlaceholderText = "RA do aluno";
            }
        }

        private void lblEditarAluno_Click(object sender, EventArgs e)
        {
            lblGerenciamento.Location = new Point(620, 164);
            limparCampos(false);
            lblGerenciamento.Text = "Editar Aluno";
            btnGerenciamento.Text = "Editar";
            btnBuscar.Visible = true;
            btnBuscar.Location = new Point(910, 260);
            txtEmailAluno.Enabled = false;
            txtPrimeiroNome.Enabled = false;
            txtUltimoNome.Enabled = false;
            txtRaAluno.Visible = false;
            txtRa2Aluno.Visible = true;
        }

        private void lblApagarAluno_Click(object sender, EventArgs e)
        {
            lblGerenciamento.Location = new Point(620, 164);
            limparCampos(false);
            lblGerenciamento.Text = "Apagar Aluno";
            btnGerenciamento.Text = "Apagar";
            btnBuscar.Visible = true;
            btnBuscar.Location = new Point(910, 260);
            txtEmailAluno.Enabled = false;
            txtPrimeiroNome.Enabled = false;
            txtUltimoNome.Enabled = false;
            txtRaAluno.Visible = false;
            txtRa2Aluno.Visible = true;
        }

        private void lblAtivarAluno_Click(object sender, EventArgs e)
        {
            lblGerenciamento.Location = new Point(620, 164);
            limparCampos(false);
            lblGerenciamento.Text = "Ativar Aluno";
            btnGerenciamento.Text = "Ativar";
            btnBuscar.Visible = true;
            btnBuscar.Location = new Point(910, 260);
            txtEmailAluno.Enabled = false;
            txtPrimeiroNome.Enabled = false;
            txtUltimoNome.Enabled = false;
            txtRaAluno.Visible = false;
            txtRa2Aluno.Visible = true;
        }

        private void lblRegistrarAluno_Click(object sender, EventArgs e)
        {
            lblGerenciamento.Location = new Point(584, 164);
            lblGerenciamento.Text = "Registrar Aluno";
            btnGerenciamento.Text = "Registrar";
            btnBuscar.Visible = false;
            btnBuscar.Location = new Point(1062, 260);
            txtEmailAluno.Enabled = true;
            txtPrimeiroNome.Enabled = true;
            txtUltimoNome.Enabled = true; 
            txtRaAluno.Visible = true;
            txtRa2Aluno.Visible = false;
            limparCampos(true);
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
            if (guna2GradientPanelImgPerfil.Visible == false)
            {
                guna2GradientPanelImgPerfil.Visible = true;
                panel9.Visible = true;
                panel8.Visible = true;
            }
            else if (guna2GradientPanelImgPerfil.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRa2Aluno.Text.Trim() != "")
            {
                var Load = new Carregamento();
                Load.Show();
                try
                {
                    Alunos aluno = await FindStudentByRa(txtRa2Aluno.Text.Trim());

                    if (btnGerenciamento.Text == "Ativar" && aluno.Status == 1)
                    {
                        Load.Close();
                        MyMessageBoxWarning.ShowBox("O aluno já está ativado", "Aviso");
                        return;
                    }

                    if (btnGerenciamento.Text != "Ativar" && aluno.Status == 0)
                    {
                        Load.Close();
                        MyMessageBoxWarning.ShowBox("O aluno está desativado", "Aviso");
                        return;
                    }

                    if(btnGerenciamento.Text != "Editar")
                    {
                        txtEmailAluno.Enabled = false;
                        txtPrimeiroNome.Enabled = false;
                        txtUltimoNome.Enabled = false;
                    }
                    else
                    {
                        txtEmailAluno.Enabled = true;
                        txtPrimeiroNome.Enabled = true;
                        txtUltimoNome.Enabled = true;
                    }

                    txtEmailAluno.PlaceholderText = "";
                    txtPrimeiroNome.PlaceholderText = "";
                    txtUltimoNome.PlaceholderText = "";

                    txtEmailAluno.Text = aluno.Email.ToString();
                    txtPrimeiroNome.Text = aluno.First_name.ToString();
                    txtUltimoNome.Text = aluno.Last_name.ToString();

                    txtEmailAluno.ForeColor = Color.Black;
                    txtPrimeiroNome.ForeColor = Color.Black;
                    txtUltimoNome.ForeColor = Color.Black;

                    Load.Close();
                }
                catch(ApiException erro)
                {
                    Load.Close();
                    string[] mensagemErro = erro.Content.Split('"');
                    MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                }  
            }
            else
            {
                MyMessageBoxError.ShowBox("Preencha o campo informando o RA do aluno!", "Erro");
            }
        }

        private async void btnGerenciamento_Click(object sender, EventArgs e)
        {
            var Load = new Carregamento();
            Load.Show();

            if (btnGerenciamento.Text == "Registrar")
            {
                if ((txtRaAluno.Text.Trim() != "") && (txtEmailAluno.Text.Trim() != "") && (txtPrimeiroNome.Text.Trim() != "") && (txtUltimoNome.Text.Trim() != "") && (txtRaAluno.PlaceholderText != "RA do aluno") && (txtEmailAluno.PlaceholderText != "E-mail do aluno") && (txtPrimeiroNome.PlaceholderText != "Primeiro nome") && (txtUltimoNome.PlaceholderText != "Último nome"))
                {
                    if (txtEmailAluno.Text.StartsWith("cl") && txtEmailAluno.Text.Contains("@g.unicamp.br"))
                    {
                        try
                        {
                            Alunos aluno = new Alunos(txtRaAluno.Text, txtPrimeiroNome.Text, txtUltimoNome.Text, txtEmailAluno.Text);
                            await CreateAluno(aluno);
                            Load.Close();
                            MyMessageBoxSucess.ShowBox("O aluno foi registrado com sucesso!", "Sucesso");
                            limparCampos();
                        }
                        catch (ApiException erro)
                        {
                            Load.Close();
                            string[] mensagemErro = erro.Content.Split('"');
                            MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                        }
                    }
                    else
                    {
                        Load.Close();
                        MyMessageBoxError.ShowBox("O formato do e-mail utilizado está incorreto!", "Erro");
                    }
                }
                else
                {
                    Load.Close();
                    MyMessageBoxError.ShowBox("Campo(s) não preenchido(s)!", "Erro");
                }
            }
            else
            {
                if ((txtRa2Aluno.Text.Trim() != "") && (txtEmailAluno.Text.Trim() != "") && (txtPrimeiroNome.Text.Trim() != "") && (txtUltimoNome.Text.Trim() != "") && (txtRa2Aluno.PlaceholderText != "RA do aluno") && (txtEmailAluno.PlaceholderText != "E-mail do aluno") && (txtPrimeiroNome.PlaceholderText != "Primeiro nome") && (txtUltimoNome.PlaceholderText != "Último nome"))
                {
                    if (txtEmailAluno.Text.StartsWith("cl") && txtEmailAluno.Text.Contains("@g.unicamp.br"))
                    {
                        if (btnGerenciamento.Text == "Editar")
                        {
                            try
                            {
                                Alunos aluno = new Alunos(txtRa2Aluno.Text, txtPrimeiroNome.Text, txtUltimoNome.Text, txtEmailAluno.Text);
                                await UpdateStudentInformation(aluno);
                                Load.Close();
                                MyMessageBoxSucess.ShowBox("O aluno foi atualizado com sucesso!", "Sucesso");
                                limparCampos();
                                txtEmailAluno.Enabled = false;
                                txtPrimeiroNome.Enabled = false;
                                txtUltimoNome.Enabled = false;
                            }
                            catch (ApiException erro)
                            {
                                Load.Close();
                                string[] mensagemErro = erro.Content.Split('"');
                                MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                            }
                        }
                        else if (btnGerenciamento.Text == "Apagar" || btnGerenciamento.Text == "Ativar")
                        {
                            try
                            {
                                ChangeStudentStatusRequest changeStudentStatusRequest = new ChangeStudentStatusRequest(txtRa2Aluno.Text);
                                await ChangeStudentStatus(changeStudentStatusRequest);
                                Load.Close();
                                string mensagem = "O aluno foi ativado com sucesso!";
                                if (btnGerenciamento.Text == "Apagar")
                                {
                                    mensagem = "O aluno foi desativado com sucesso!";
                                }
                                MyMessageBoxSucess.ShowBox(mensagem, "Sucesso");
                                limparCampos();
                            }
                            catch (ApiException erro)
                            {
                                Load.Close();
                                string[] mensagemErro = erro.Content.Split('"');
                                MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                            }
                        }
                    }
                    else
                    {
                        Load.Close();
                        MyMessageBoxError.ShowBox("O formato do e-mail utilizado está incorreto!", "Erro");
                    }
                }
                else
                {
                    Load.Close();
                    MyMessageBoxError.ShowBox("Campo(s) não preenchido(s)!", "Erro");
                }
            }
        }

        private void FormGerenciarAlunos_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnGerenciamento.Text == "Editar" && controle == 0)
            {
                limparCampos(false);
                txtEmailAluno.Enabled = false;
                txtPrimeiroNome.Enabled = false;
                txtUltimoNome.Enabled = false;
            }
        }

        private void txtRa2Aluno_Leave(object sender, EventArgs e)
        {
            controle = 1;
        }
    }
}
