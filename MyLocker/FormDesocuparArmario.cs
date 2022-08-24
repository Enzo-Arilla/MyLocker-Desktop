using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refit;

namespace MyLocker
{
    public partial class FormDesocuparArmario : Form
    {

        int controle = 0;
        Armario[] armarios = null;

        public FormDesocuparArmario()
        {
            InitializeComponent();
       
        }

        static async Task<Armario[]> ListArmarios()
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api.herokuapp.com/");

            Armario[] response = await apiClient.ListArmarios();

            return response;
        }


        private async void FormDesocuparArmario_Load(object sender, EventArgs e)
        {

            var Load = new Carregamento();
            Load.Show();

            lblFoco.Focus();

            armarios = await ListArmarios();

            foreach (Armario a in armarios)
            {
       
                string[] row = new string[] { a.Number.ToString(), a.Section.Status.ToString() };
                tblDesocuparArmario.Rows.Add(row);

            }

            Load.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filtro = txtPesquisarArmario.Text;

            if(filtro.Trim() == "")
            {
                MyMessageBoxError.ShowBox("Preencha o campo de pesquisa para realizar a busca!", "Erro");
            }
            else
            {
                if(controle == 0)
                {
                   tblDesocuparArmario.Rows.Clear();
                    tblDesocuparArmario.Refresh();

                    foreach (Armario a in armarios)
                    {
                        if (a.Number.ToString().Equals(filtro) || a.Number.ToString().StartsWith(filtro))
                        {
                            string[] row = new string[] { a.Number.ToString(), a.Section.Status.ToString() };
                            tblDesocuparArmario.Rows.Add(row);
                        }

                    }
                    if (tblDesocuparArmario.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O número informado não corresponde a um armário!", "Aviso");
                        foreach (Armario a in armarios)
                        {

                            string[] row = new string[] { a.Number.ToString(), a.Section.Status.ToString() };
                            tblDesocuparArmario.Rows.Add(row);

                        }
                    }

                }
                else if(controle == 1)
                {

                    tblDesocuparArmario.Rows.Clear();
                    tblDesocuparArmario.Refresh();

                    foreach (Armario a in armarios)
                    {

                        if (a.Status.ToString().Equals(filtro) || a.Status.ToString().StartsWith(filtro))
                        {
                            string[] row = new string[] { a.Number.ToString(), a.Section.Status.ToString() };
                            tblDesocuparArmario.Rows.Add(row);
 
                        }
                    }
                    if(tblDesocuparArmario.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O RA informado não corresponde a um armário!", "Aviso");
                        foreach (Armario a in armarios)
                        {

                            string[] row = new string[] { a.Number.ToString(), a.Section.Status.ToString() };
                            tblDesocuparArmario.Rows.Add(row);

                        }

                    }
                }
            }
            

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
                panel10.Visible = false;
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
                panel5.Visible = false;
                panel2.Visible = false;
                panel10.Visible = false;
            }
            else if (guna2GradientPanel2.Visible == true)
            {
                panel4.Visible = false;
                panel2.Visible = false;
                guna2GradientPanel2.Visible = false;
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
            else if (guna2GradientPanelImgPerfil.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel3.Visible = false;
                panel8.Visible = false;
            }
        }

        private void tblDesocuparArmario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex==2 && e.RowIndex>=0)
            {
                int number = e.RowIndex;
                string number2 = tblDesocuparArmario[0, number].Value.ToString();
                MessageBox.Show("Teste:" + number2);
            }
           
        }

        private void tblDesocuparArmario_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex>=0)
            {
                tblDesocuparArmario.Cursor = Cursors.Hand;
            }
            else
            {
                tblDesocuparArmario.Cursor = Cursors.Arrow;
            }
        }

        private void btnTipoPesquisa_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == false)
            {
                panel10.Visible = true;
                panel14.Visible = true;
                if(panel2.Visible == true)
                {
                    panel2.Visible = false;
                }
                else if(guna2GradientPanel2.Visible == true)
                {
                    guna2GradientPanel2.Visible = false;
                }
            }
            else
            {
                panel10.Visible = false;
                panel14.Visible = false;
            }
                
        }

        private void btnRaLocatario_Click(object sender, EventArgs e)
        {
            if(btnRaLocatario.Cursor == Cursors.Hand)
            { 
                btnRaLocatario.Cursor = Cursors.No;
                btnNumero.Cursor = Cursors.Hand;
                btnRaLocatario.FillColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (RA Locatário)";
                controle = 1;
                panel10.Visible = false;
            }
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if(btnNumero.Cursor == Cursors.Hand)
            {
                btnNumero.Cursor = Cursors.No;
                btnNumero.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.Cursor = Cursors.Hand;
                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Número)";
                controle = 0;
                panel10.Visible = false;
            }
        }

        private void txtPesquisarArmario_Enter(object sender, EventArgs e)
        {
            if(btnNumero.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Número)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (RA Locatário)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            

        }

        private void txtPesquisarArmario_Leave(object sender, EventArgs e)
        {
            if(btnNumero.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.Text == "")
                {
                    txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Número)";
                }
            }
            else
            {
                if (txtPesquisarArmario.Text == "")
                {
                    txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (RA Locatário)";
                }
            }
        }

        

        
    }
}
