﻿using Refit;
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
    public partial class FormDadosArmarios : Form
    {
        public FormDadosArmarios()
        {
            InitializeComponent();
        }

        private string transformHexToPlainText(string hex)
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

            async private void FormDadosArmarios_Load(object sender, EventArgs e)
        {

            lblFoco.Focus();

            Armario[] armarios = null;
            armarios  = await ListArmarios();

            foreach(Armario a in armarios) {
                //MessageBox.Show(a.Number.ToString());
                string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                string[] row = new string[]{a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), a.IsRented.ToString() };
                tblDadosArmarios.Rows.Add(row);
            }

            btnStatusApm.BackColor = Color.Transparent;

        }

        static async Task<Armario[]> ListArmarios()
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api-production.up.railway.app");

            Armario[] response = await apiClient.ListArmarios();

            return response;
        }

        private void btnAlugarArmario_Click(object sender, EventArgs e)
        {
            var FormDesocuparArmario = new FormAlugarArmario();
            FormDesocuparArmario.Closed += (s, args) => this.Close();
            FormDesocuparArmario.Show();
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
            if (panel6.Visible == false)
            {
                panel6.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                panel11.Visible = true;
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel11.Visible = false;
            }
        }

        private void btnDadosAlunos_Click(object sender, EventArgs e)
        {
            var FormDadosAlunos = new FormDadosAlunos();
            FormDadosAlunos.Closed += (s, args) => this.Close();
            FormDadosAlunos.Show();
            this.Hide();
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

                if (panel2.Visible == true)
                {
                    panel2.Visible = false;
                }
                else if (panel7.Visible == true)
                {
                    panel7.Visible = false;
                }
            }
            else
            {
                panel10.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (btnNumero.Cursor == Cursors.Hand)
            {
                btnNumero.Cursor = Cursors.No;
                btnNumero.FillColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.Cursor = Cursors.Hand;
                btnNome.FillColor = Color.LightGray;
                btnNome.Cursor = Cursors.Hand;
                btnArmario.FillColor = Color.LightGray;
                btnArmario.Cursor = Cursors.Hand;
                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.Cursor = Cursors.Hand;
                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Número)";
                panel10.Visible = false;
            }
        }

        private void btnRaLocatario_Click(object sender, EventArgs e)
        {
            if(btnRaLocatario.Cursor == Cursors.Hand)
            {
                btnRaLocatario.Cursor = Cursors.No;
                btnRaLocatario.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.FillColor = Color.LightGray;
                btnNumero.Cursor = Cursors.Hand;
                btnNome.FillColor = Color.LightGray;
                btnNome.Cursor = Cursors.Hand;
                btnArmario.FillColor = Color.LightGray;
                btnArmario.Cursor = Cursors.Hand;
                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.Cursor = Cursors.Hand;
                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (RA Locatário)";
                panel10.Visible = false;
            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if(btnNome.Cursor == Cursors.Hand)
            {
                btnNome.Cursor = Cursors.No;
                btnNome.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.FillColor = Color.LightGray;
                btnNumero.Cursor = Cursors.Hand;
                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.Cursor = Cursors.Hand;
                btnArmario.FillColor = Color.LightGray;
                btnArmario.Cursor = Cursors.Hand;
                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.Cursor = Cursors.Hand;
                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Nome)";
                panel10.Visible = false;
            }
        }

        private void btnArmario_Click(object sender, EventArgs e)
        {
            if(btnArmario.Cursor == Cursors.Hand)
            {
                btnArmario.Cursor = Cursors.No;
                btnArmario.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.FillColor = Color.LightGray;
                btnNumero.Cursor = Cursors.Hand;
                btnNome.FillColor = Color.LightGray;
                btnNome.Cursor = Cursors.Hand;
                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.Cursor = Cursors.Hand;
                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.Cursor = Cursors.Hand;
                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Armário)";
                panel10.Visible = false;
            }
        }

        private void btnStatusApm_Click(object sender, EventArgs e)
        {
            if(btnStatusApm.Cursor == Cursors.Hand)
            {
                btnStatusApm.Cursor = Cursors.No;
                btnStatusApm.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.FillColor = Color.LightGray;
                btnNumero.Cursor = Cursors.Hand;
                btnNome.FillColor = Color.LightGray;
                btnNome.Cursor = Cursors.Hand;
                btnArmario.FillColor = Color.LightGray;
                btnArmario.Cursor = Cursors.Hand;
                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.Cursor = Cursors.Hand;
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
            else if (btnArmario.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Armário)")
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
            else if (btnArmario.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Armário)")
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtPesquisarArmario.Text == "" || txtPesquisarArmario.PlaceholderText.Contains("Pesquisar"))
            {
                MyMessageBoxError.ShowBox("Você precisa preencher o campo de pesquisa.", "Campos obrigatórios não preenchidos");
            }
        }
    }
}
