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
    public partial class FormDadosAlunos : Form
    {
        public FormDadosAlunos()
        {
            InitializeComponent();
        }

        async private void FormDadosArmarios_Load(object sender, EventArgs e)
        {
            var Load = new Carregamento();
            Load.Show();


            Alunos[] alunos = null;
            alunos = await ListAlunos();

            foreach(Alunos a in alunos) {
                //MessageBox.Show(a.Number.ToString());
                string[] row = new string[]{a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), a.Locker_number.ToString(), a.Status.ToString()};
                tblDadosArmarios.Rows.Add(row);
            }

            Load.Close();
        }

        static async Task<Alunos[]> ListAlunos()
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com/");

            Alunos[] response = await apiClient.ListAlunos();

            return response;
        }

        private void btnAlugarArmario_Click(object sender, EventArgs e)
        {
            var FormDesocuparArmario = new FormAlugarArmario();
            FormDesocuparArmario.Closed += (s, args) => this.Close();
            FormDesocuparArmario.Show();
            this.Hide();
        }

        private void btnDadosArmarios_Click(object sender, EventArgs e)
        {
            var FormDadosArmarios = new FormDadosArmarios();
            FormDadosArmarios.FormClosed += (s, args) => this.Close();
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
            FormAlterarFoto.FormClosed += (s, args) => this.Close();
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

        private void btnGerenciarAlunos_Click(object sender, EventArgs e)
        {
            var FormGerenciarAlunos = new FormGerenciarAlunos();
            FormGerenciarAlunos.Closed += (s, args) => this.Close();
            FormGerenciarAlunos.Show();
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
                guna2GradientPanel2.Visible = false;
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
            if (guna2GradientPanel2.Visible == false)
            {
                panel4.Visible = true;
                guna2GradientPanel2.Visible = true;
                guna2GradientPanel2.BringToFront();
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
            }
            else if (guna2GradientPanel2.Visible == true)
            {
                panel4.Visible = false;
                guna2GradientPanel2.Visible = false;
                txtPesquisarArmario.Visible = true;
                btnTipoPesquisa.Visible = true;
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
            if (guna2GradientPanelImgPerfil.Visible == false)
            {
                guna2GradientPanelImgPerfil.Visible = true;
                panel3.Visible = true;
                panel8.Visible = true;
            }
            else if (panel6.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel3.Visible = false;
                panel8.Visible = false;
            }
        }

        
    }
}
