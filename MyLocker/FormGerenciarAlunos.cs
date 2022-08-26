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

        Alunos[] alunos = null;

        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        static async Task CreateAluno(Alunos aluno)
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com");
            await apiClient.CreateAluno(aluno);

        }

        static async Task<Alunos[]> ListAlunos()
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com");

            Alunos[] response = await apiClient.ListAlunos();

            return response;
        }

        private async void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
            txtRaAluno.Width = 633;
            alunos = await ListAlunos();
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
            txtEmailAluno.Enabled = false;
            txtPrimeiroNome.Enabled = false;
            txtUltimoNome.Enabled = false;
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
            txtEmailAluno.Enabled = false;
            txtPrimeiroNome.Enabled = false;
            txtUltimoNome.Enabled = false;
            if (txtRaAluno.Width==633)
            {
                txtRaAluno.Width = 450;
            }
            
        }

        private void lblAtivarAluno_Click(object sender, EventArgs e)
        {
            lblGerenciamento.Text = "Ativar Aluno";
            btnGerenciamento.Text = "Ativar";
            btnBuscar.Visible = true;
            txtEmailAluno.Enabled = false;
            txtPrimeiroNome.Enabled = false;
            txtUltimoNome.Enabled = false;
            if (txtRaAluno.Width==633)
            {
                txtRaAluno.Width = 450;
            }
        }

        private void lblRegistrarAluno_Click(object sender, EventArgs e)
        {

            btnBuscar.Visible = false;
            txtRaAluno.Width = 633;
            lblGerenciamento.Text = "Registrar Aluno";
            btnGerenciamento.Text = "Registrar";
            txtEmailAluno.Enabled = true;
            txtPrimeiroNome.Enabled = true;
            txtUltimoNome.Enabled = true;
            
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRaAluno.Text.Trim() != "")
            {
                txtEmailAluno.Enabled = true;
                txtPrimeiroNome.Enabled = true;
                txtUltimoNome.Enabled = true;

                foreach (Alunos a in alunos)
                {
                    if(txtRaAluno.Text.Equals(a.Ra.ToString()))
                    {
                        txtEmailAluno.PlaceholderText = "";
                        txtPrimeiroNome.PlaceholderText = "";
                        txtUltimoNome.PlaceholderText = "";
                        txtEmailAluno.Text = a.Email.ToString();
                        txtPrimeiroNome.Text = a.First_name.ToString();
                        txtUltimoNome.Text = a.Last_name.ToString();
                        txtEmailAluno.ForeColor = Color.Black;
                        txtPrimeiroNome.ForeColor = Color.Black;
                        txtUltimoNome.ForeColor = Color.Black;
                    }  
                }
                if(txtEmailAluno.Text.Trim() == "")
                {
                    MyMessageBoxWarning.ShowBox("O RA informado não encontrou um aluno! Tente novamente.", "Aviso");
                    txtEmailAluno.Enabled = false;
                    txtPrimeiroNome.Enabled = false;
                    txtUltimoNome.Enabled = false;
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

            if ((txtRaAluno.Text.Trim() != "") && (txtEmailAluno.Text.Trim() != "") && (txtPrimeiroNome.Text.Trim() != "") && (txtUltimoNome.Text.Trim() != "") && (txtRaAluno.PlaceholderText == "") && (txtEmailAluno.PlaceholderText == "") && (txtPrimeiroNome.PlaceholderText == "") && (txtUltimoNome.PlaceholderText == ""))
            {
               // if (txtEmailAluno.Text.StartsWith("cl") && txtEmailAluno.Text.Contains("@g.unicamp.br"))
                //{
                    if (btnGerenciamento.Text == "Registrar")
                    {
                        try
                        {
                            Alunos aluno = new Alunos(txtRaAluno.Text, txtPrimeiroNome.Text, txtUltimoNome.Text, txtEmailAluno.Text);
                            await CreateAluno(aluno);
                            Load.Close();
                            MyMessageBoxSucess.ShowBox("O aluno foi registrado com sucesso!", "Sucesso");
                            txtRaAluno.Text = "";
                            txtPrimeiroNome.Text = "";
                            txtUltimoNome.Text = "";
                            txtEmailAluno.Text = "";
                            txtUltimoNome.PlaceholderText = "Último nome";
                            txtPrimeiroNome.PlaceholderText = "Primeiro nome";
                            txtEmailAluno.PlaceholderText = "E-mail do aluno";
                            txtRaAluno.PlaceholderText = "RA do aluno";
                        }
                        catch (ApiException erro)
                        {
                            Load.Close();
                            string[] mensagemErro = erro.Content.Split('"');
                            MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                        }
                    }
                    else if (btnGerenciamento.Text == "Editar")
                    {
                        
                    }
                    else if (btnGerenciamento.Text == "Apagar")
                    {
                       
                    }
                    else if (btnGerenciamento.Text == "Ativar")
                    {
                        
                    }
                //}  
                //else
                //{
                  //  Load.Close();
                   // MyMessageBoxError.ShowBox("O formato do e-mail utilizado está incorreto!", "Erro");
                //}
            }
            else
            {
                Load.Close();
                MyMessageBoxError.ShowBox("Campo(s) não preenchido(s)!", "Erro");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
