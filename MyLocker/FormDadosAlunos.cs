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

        Alunos[] alunos = null;
        int controle = 0;

        public FormDadosAlunos()
        {
            InitializeComponent();
        }

        static async Task<Alunos[]> ListAlunos()
        {
            var apiClient = RestService.For<IRepositorioAlunos>("https://mylocker-api.herokuapp.com/");

            Alunos[] response = await apiClient.ListAlunos();

            return response;
        }

        private async void FormDadosArmarios_Load(object sender, EventArgs e)
        {

            var Load = new Carregamento();
            Load.Show();
            lblFoco.Focus();

            alunos = await ListAlunos();

            foreach (Alunos a in alunos)
            {
                string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                tblDadosAlunos.Rows.Add(row);
            }

            Load.Close();
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
                panel6.Visible = true;
                panel8.Visible = true;
            }
            else if (panel6.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel6.Visible = false;
                panel8.Visible = false;
            }
        }

        private void btnTipoPesquisa_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == false)
            {
                panel10.Visible = true;
                panel12.Visible = true;
                panel13.Visible = true;
                panel14.Visible = true;
                panel15.Visible = true;

            }
            else if (panel10.Visible == true)
            {
                panel10.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
            }
        }

        private void btnRaLocatario_Click(object sender, EventArgs e)
        {
            if (btnRaLocatario.Cursor == Cursors.Hand)
            {
                controle = 0;

                btnRaLocatario.FillColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.PressedColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.Cursor = Cursors.No;

                btnNome.FillColor = Color.LightGray;
                btnNome.HoverState.FillColor = Color.Empty;
                btnNome.PressedColor = Color.Empty;
                btnNome.Cursor = Cursors.Hand;

                btnSobrenome.FillColor = Color.LightGray;
                btnSobrenome.HoverState.FillColor = Color.Empty;
                btnSobrenome.PressedColor = Color.Empty;
                btnSobrenome.Cursor = Cursors.Hand;

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (RA Locatário)";

                panel10.Visible = false;

            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (btnNome.Cursor == Cursors.Hand)
            {
                controle = 1;

                btnNome.FillColor = Color.FromArgb(255, 220, 81);
                btnNome.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnNome.PressedColor = Color.FromArgb(255, 220, 81);
                btnNome.Cursor = Cursors.No;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
                btnRaLocatario.Cursor = Cursors.Hand;

                btnSobrenome.FillColor = Color.LightGray;
                btnSobrenome.HoverState.FillColor = Color.Empty;
                btnSobrenome.PressedColor = Color.Empty;
                btnSobrenome.Cursor = Cursors.Hand;

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Nome)";

                panel10.Visible = false;
            }
        }

        private void btnSobrenome_Click(object sender, EventArgs e)
        {
            if (btnSobrenome.Cursor == Cursors.Hand)
            {
                controle = 2;

                btnSobrenome.FillColor = Color.FromArgb(255, 220, 81);
                btnSobrenome.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnSobrenome.PressedColor = Color.FromArgb(255, 220, 81);
                btnSobrenome.Cursor = Cursors.No;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
                btnRaLocatario.Cursor = Cursors.Hand;

                btnNome.FillColor = Color.LightGray;
                btnNome.HoverState.FillColor = Color.Empty;
                btnNome.PressedColor = Color.Empty;
                btnNome.Cursor = Cursors.Hand;

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Sobrenome)";

                panel10.Visible = false;
            }
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (btnNumero.Cursor == Cursors.Hand)
            {
                controle = 3;

                btnNumero.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.PressedColor = Color.FromArgb(255, 220, 81);
                btnNumero.Cursor = Cursors.No;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
                btnRaLocatario.Cursor = Cursors.Hand;

                btnNome.FillColor = Color.LightGray;
                btnNome.HoverState.FillColor = Color.Empty;
                btnNome.PressedColor = Color.Empty;
                btnNome.Cursor = Cursors.Hand;

                btnSobrenome.FillColor = Color.LightGray;
                btnSobrenome.HoverState.FillColor = Color.Empty;
                btnSobrenome.PressedColor = Color.Empty;
                btnSobrenome.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Número)";

                panel10.Visible = false;
            }
        }

        private void btnStatusApm_Click(object sender, EventArgs e)
        {
            if (btnStatusApm.Cursor == Cursors.Hand)
            {
                controle = 4;

                btnStatusApm.FillColor = Color.FromArgb(255, 220, 81);
                btnStatusApm.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnStatusApm.PressedColor = Color.FromArgb(255, 220, 81);
                btnStatusApm.Cursor = Cursors.No;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
                btnRaLocatario.Cursor = Cursors.Hand;

                btnNome.FillColor = Color.LightGray;
                btnNome.HoverState.FillColor = Color.Empty;
                btnNome.PressedColor = Color.Empty;
                btnNome.Cursor = Cursors.Hand;

                btnSobrenome.FillColor = Color.LightGray;
                btnSobrenome.HoverState.FillColor = Color.Empty;
                btnSobrenome.PressedColor = Color.Empty;
                btnSobrenome.Cursor = Cursors.Hand;

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Status APM)";

                panel10.Visible = false;
            }
        }

        private void txtPesquisarArmario_Enter(object sender, EventArgs e)
        {
            if (btnNumero.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Número)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnRaLocatario.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (RA Locatário)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnNome.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Nome)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnSobrenome.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Sobrenome)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnStatusApm.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Status APM)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
        }

        private void txtPesquisarArmario_Leave(object sender, EventArgs e)
        {
            /*
            if (btnNumero.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Número)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnRaLocatario.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (RA Locatário)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnNome.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Nome)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnSobrenome.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Sobrenome)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnStatusApm.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Status APM)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filtro = txtPesquisarArmario.Text;

            if (filtro.Trim() == "" || filtro.Trim() == "Pesquisar Armário (RA Locatário)" || filtro.Trim() == "Pesquisar Armário (Nome)" || filtro.Trim() == "Pesquisar Armário (Sobrenome)" || filtro.Trim() == "Pesquisar Armário (Número)" || filtro.Trim() == "Pesquisar Armário (Status APM)")
            {
                foreach (Alunos a in alunos)
                {
                    string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                    string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                    tblDadosAlunos.Rows.Add(row);
                }
            }
            else
            {
                //tblDadosAlunos.Location = new Point(40, 24);
                if (controle == 0)
                {
                    tblDadosAlunos.Rows.Clear();
                    tblDadosAlunos.Refresh();

                    foreach (Alunos a in alunos)
                    {

                        if (a.Ra.ToString().Equals(filtro) || a.Ra.ToString().StartsWith(filtro))
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);
                        }
                    }
                    if (tblDadosAlunos.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O RA informado não corresponde a um armário!", "Aviso");
                        foreach (Alunos a in alunos)
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);

                        }
                    }


                }
                else if (controle == 1)
                {

                    tblDadosAlunos.Rows.Clear();
                    tblDadosAlunos.Refresh();

                    foreach (Alunos a in alunos)
                    {

                        if (a.First_name.ToString().Equals(filtro) || a.First_name.ToString().StartsWith(filtro))
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);
                        }
                    }
                    if (tblDadosAlunos.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O nome informado não corresponde a um armário!", "Aviso");
                        foreach (Alunos a in alunos)
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);

                        }
                    }
                }
                else if (controle == 2)
                {
                    tblDadosAlunos.Rows.Clear();
                    tblDadosAlunos.Refresh();

                    foreach (Alunos a in alunos)
                    {

                        if (a.Last_name.ToString().Equals(filtro) || a.Last_name.ToString().StartsWith(filtro))
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);
                        }
                    }
                    if (tblDadosAlunos.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O sobrenome informado não corresponde a um armário!", "Aviso");
                        foreach (Alunos a in alunos)
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);

                        }
                    }
                }
                else if (controle == 3)
                {
                    tblDadosAlunos.Rows.Clear();
                    tblDadosAlunos.Refresh();

                    foreach (Alunos a in alunos)
                    {

                        if (a.Locker_number.ToString().Equals(filtro) || a.Locker_number.ToString().StartsWith(filtro))
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);
                        }
                    }
                    if (tblDadosAlunos.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O número informado não corresponde a um armário!", "Aviso");
                        foreach (Alunos a in alunos)
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);

                        }
                    }
                }
                else if (controle == 4)
                {
                    tblDadosAlunos.Rows.Clear();
                    tblDadosAlunos.Refresh();

                    foreach (Alunos a in alunos)
                    {

                        if (a.Status.ToString().Equals(filtro) || a.Status.ToString().StartsWith(filtro))
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);
                        }
                    }
                    if (tblDadosAlunos.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O status apm informado não corresponde a um armário!", "Aviso");
                        foreach (Alunos a in alunos)
                        {
                            string numero = a.Locker_number != null ? a.Locker_number.ToString() : " - ";
                            string[] row = new string[] { a.Ra.ToString(), a.First_name.ToString(), a.Last_name.ToString(), numero, a.Status.ToString() };
                            tblDadosAlunos.Rows.Add(row);

                        }
                    }
                }
            }
        }
    }
}