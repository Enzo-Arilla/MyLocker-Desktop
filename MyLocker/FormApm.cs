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
        string ra;
        string nome;
        string sobrenome;

        public FormApm()
        {
            InitializeComponent();
        }

        static async Task<Apm[]> ListApms()
        {
            var apiClient = RestService.For<IRepositorioAPM>("https://mylocker-api.herokuapp.com");

            Apm[] response = await apiClient.listApms();

            return response;
        }

        async private void FormApm_Load(object sender, EventArgs e)
        {
            //var Load = new Carregamento();
            //Load.Show();
            Apm[] apms = null;
            apms = await ListApms();

            foreach (Apm a in apms)
            {
                //MessageBox.Show(a.Number.ToString());
                if(a.Student != null)
                {
                    ra = a.Student.Ra.ToString();
                    nome = a.Student.First_name;
                    sobrenome = a.Student.Last_name;
                    string[] row = new string[] { a.Id.ToString(), ra, nome, sobrenome, a.RequisitionPdf };
                    tblApm.Rows.Add(row);
                }
            }

            //Load.Close();
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
                guna2GradientPanel2.Visible = false;
            }
            else if (panel2.Visible == true)
            {
                panel5.Visible = false;
                panel2.Visible = false;
                guna2GradientPanel2.Visible = false;
            }
        }

        private void lblAlunos_Click(object sender, EventArgs e)
        {
            if (guna2GradientPanel2.Visible == false)
            {
                panel4.Visible = true;
                guna2GradientPanel2.Visible = true;
                panel2.Visible = false;
            }
            else if (guna2GradientPanel2.Visible == true)
            {
                guna2GradientPanel2.Visible = false;
                panel4.Visible = false;
                panel2.Visible = false;
            }
        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {
            if (guna2GradientPanelImgPerfil.Visible == false)
            {

                guna2GradientPanelImgPerfil.Visible = true;
                panel8.Visible = true;
                panel3.Visible = true;
               
            }
            else if (guna2GradientPanelImgPerfil.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel8.Visible = false;
                panel3.Visible = false;
  
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
