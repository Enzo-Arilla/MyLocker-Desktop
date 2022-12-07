﻿using System;
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
    public partial class FormMenu : Form
    {

        DateTime time;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                lblNome.Text = Usuario.Name + " " + Usuario.LastName;
            }
            catch (Exception erro)
            {

            }
            finally
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
           
        }

        private void btnAlugarArmario_Click(object sender, EventArgs e)
        {
            var FormAlugarArmario = new FormAlugarArmario();
            FormAlugarArmario.Closed += (s, args) => this.Close();
            FormAlugarArmario.Show();
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

        private async void btnDadosArmarios_Click(object sender, EventArgs e)
        {
            var FormDadosArmarios = new FormDadosArmarios();
            var Load = new Carregamento();
            Load.Closed += (s, args) => this.Close();
            FormDadosArmarios.Closed += (s, args) => this.Close();
            FormDadosArmarios.Show();
            Load.Show();
            await Task.Delay(5000);
            Load.Close();
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
            if(panel2.Visible == false)
            {
                lblArmarios.ForeColor = Color.FromArgb(253, 200, 0);
                lblAlunos.ForeColor = Color.White;
                panel3.Visible = true;
                panel5.Visible = true;
                panel2.Visible = true;
                panel4.Visible = false;
                panel7.Visible = false;
            }
            else if(panel2.Visible == true)
            {
                lblArmarios.ForeColor = Color.White;
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
            }
        }

        private void lblAlunos_Click(object sender, EventArgs e)
        {
            if(panel7.Visible == false)
            {
                lblAlunos.ForeColor = Color.FromArgb(253, 200, 0);
                lblArmarios.ForeColor = Color.White;
                panel4.Visible = true;
                panel7.Visible = true;
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
            }
            else if(panel7.Visible == true)
            {
                lblAlunos.ForeColor = Color.White;
                panel4.Visible = false;
                panel7.Visible = false;
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
            if(guna2GradientPanelImgPerfil.Visible == false)
            {
                guna2GradientPanelImgPerfil.Visible = true;
                panel8.Visible = true;
                panel6.Visible = true;
            }
            else if (guna2GradientPanelImgPerfil.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel6.Visible = false;
                panel8.Visible = false;
            }
            
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
