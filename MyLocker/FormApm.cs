using System;
using Refit;
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
    public partial class FormApm : Form
    {
        public FormApm()
        {
            InitializeComponent();
        }

        async private void FormApm_Load(object sender, EventArgs e)
        {
            Armario[] armarios = null;
            armarios = await ListArmarios();

            foreach (Armario a in armarios)
            {
                //MessageBox.Show(a.Number.ToString());
                string[] row = new string[] { a.Number.ToString() };
                tblApm.Rows.Add(row);
            }
        }

        static async Task<Armario[]> ListArmarios()
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api.herokuapp.com");

            Armario[] response = await apiClient.ListArmarios();

            return response;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            var FormAlugarArmario = new FormDadosArmarios();
            FormAlugarArmario.Closed += (s, args) => this.Close();
            FormAlugarArmario.Show();
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

        private void btnGerenciarAlunos_Click(object sender, EventArgs e)
        {
            var FormGerenciarAlunos = new FormGerenciarAlunos();
            FormGerenciarAlunos.Closed += (s, args) => this.Close();
            FormGerenciarAlunos.Show();
            this.Hide();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            var FormAlterarSenha = new FormAlterarSenha();
            FormAlterarSenha.FormClosed += (s, args) => this.Close();
            FormAlterarSenha.Show();
            this.Hide();
        }

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            var FormAlterarSenha = new FormAlterarFoto();
            FormAlterarSenha.FormClosed += (s, args) => this.Close();
            FormAlterarSenha.Show();
            this.Hide();
        }

        private void btnTrocarPerfil_Click(object sender, EventArgs e)
        {
            var FormAlterarSenha = new FormLogin();
            FormAlterarSenha.FormClosed += (s, args) => this.Close();
            FormAlterarSenha.Show();
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
                panel4.Visible = true;
                panel5.Visible = true;
                panel2.Visible = true;
                panel4.Visible = false;
                panel7.Visible = false;
            }
            else if (panel2.Visible == true)
            {
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

        private void imgPerfil_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                panel11.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                panel3.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel11.Visible = false;
            }
        }
    }
}
