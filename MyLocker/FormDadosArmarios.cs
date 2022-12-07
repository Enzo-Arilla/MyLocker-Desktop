using Guna.UI2.WinForms;
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
using Newtonsoft;

namespace MyLocker
{
    public partial class FormDadosArmarios : Form
    {
        int controle = 0;
        Armario[] armarios = null;

        public FormDadosArmarios()
        {
            InitializeComponent();
        }

        static async Task<Armario[]> ListArmarios()
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api.herokuapp.com/");

            Armario[] response = await apiClient.ListArmarios();

            return response;
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

        private string transformPlainTextToHex(string text)
        {
            if (text == "Amarelo")
            {
                return "#FDFF97";
            }
            else if (text == "Vermelho")
            {
                return "#FF7B7B";
            }
            else if (text == "Azul")
            {
                return "#92B7FF";
            }
            else if (text == "Verde Água")
            {
                return "#A6FFEA";
            }

            return "Erro";
        }

            async private void FormDadosArmarios_Load(object sender, EventArgs e)
            {
            try
            {
                var Load = new Carregamento();
                Load.Show();
                lblFoco.Focus();

                armarios = await ListArmarios();

                foreach (Armario a in armarios)
                {
                    string ra = "-";
                    if (a.Student != null) 
                    {
                        ra = a.Student.Ra;
                    }
                    string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                    string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                    tblDadosArmarios.Rows.Add(row);
                }

                Load.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

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
            else if (guna2GradientPanelImgPerfil.Visible == true)
            {
                guna2GradientPanelImgPerfil.Visible = false;
                panel6.Visible = false;
                panel8.Visible = false;
            
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
                else if (guna2GradientPanel2.Visible == true)
                {
                    guna2GradientPanel2.Visible = false;
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

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (btnNumero.Cursor == Cursors.Hand)
            {
                controle = 0;

                btnNumero.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnNumero.PressedColor = Color.FromArgb(255, 220, 81);
                btnNumero.Cursor = Cursors.No;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
                btnRaLocatario.Cursor = Cursors.Hand;

                btnSala.FillColor = Color.LightGray;
                btnSala.HoverState.FillColor = Color.Empty;
                btnSala.PressedColor = Color.Empty;
                btnSala.Cursor = Cursors.Hand;

                btnCor.FillColor = Color.LightGray;
                btnCor.HoverState.FillColor = Color.Empty;
                btnCor.PressedColor = Color.Empty;
                btnCor.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Número)";

                panel10.Visible = false;
            }
        }

        private void btnRaLocatario_Click(object sender, EventArgs e)
        {
            if(btnRaLocatario.Cursor == Cursors.Hand)
            {
                controle = 1;

                btnRaLocatario.Cursor = Cursors.No;
                btnRaLocatario.FillColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnRaLocatario.PressedColor = Color.FromArgb(255, 220, 81);

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                btnSala.FillColor = Color.LightGray;
                btnSala.HoverState.FillColor = Color.Empty;
                btnSala.PressedColor = Color.Empty;
                btnSala.Cursor = Cursors.Hand;

                btnCor.FillColor = Color.LightGray;
                btnCor.HoverState.FillColor = Color.Empty;
                btnCor.PressedColor = Color.Empty;
                btnCor.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (RA Locatário)";
                panel10.Visible = false;
            }
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            if(btnSala.Cursor == Cursors.Hand)
            {
                controle = 2;

                btnSala.Cursor = Cursors.No;
                btnSala.FillColor = Color.FromArgb(255, 220, 81);
                btnSala.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnSala.PressedColor = Color.FromArgb(255, 220, 81);

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
                btnRaLocatario.Cursor = Cursors.Hand;

                btnCor.FillColor = Color.LightGray;
                btnCor.HoverState.FillColor = Color.Empty;
                btnCor.PressedColor = Color.Empty;
                btnCor.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Sala)";
                panel10.Visible = false;
            }
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if(btnCor.Cursor == Cursors.Hand)
            {
                controle = 3;

                btnCor.Cursor = Cursors.No;
                btnCor.FillColor = Color.FromArgb(255, 220, 81);
                btnCor.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnCor.PressedColor = Color.FromArgb(255, 220, 81);

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                btnSala.FillColor = Color.LightGray;
                btnSala.HoverState.FillColor = Color.Empty;
                btnSala.PressedColor = Color.Empty;
                btnSala.Cursor = Cursors.Hand;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
                btnRaLocatario.Cursor = Cursors.Hand;

                btnStatusApm.FillColor = Color.LightGray;
                btnStatusApm.HoverState.FillColor = Color.Empty;
                btnStatusApm.PressedColor = Color.Empty;
                btnStatusApm.Cursor = Cursors.Hand;

                txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Cor)";
                panel10.Visible = false;
            }
        }

        private void btnStatusApm_Click(object sender, EventArgs e)
        {
            if(btnStatusApm.Cursor == Cursors.Hand)
            {
                controle = 4;

                btnStatusApm.Cursor = Cursors.No;
                btnStatusApm.FillColor = Color.FromArgb(255, 220, 81);
                btnStatusApm.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnStatusApm.PressedColor = Color.FromArgb(255, 220, 81);

                btnNumero.FillColor = Color.LightGray;
                btnNumero.HoverState.FillColor = Color.Empty;
                btnNumero.PressedColor = Color.Empty;
                btnNumero.Cursor = Cursors.Hand;

                btnSala.FillColor = Color.LightGray;
                btnSala.HoverState.FillColor = Color.Empty;
                btnSala.PressedColor = Color.Empty;
                btnSala.Cursor = Cursors.Hand;

                btnCor.FillColor = Color.LightGray;
                btnCor.HoverState.FillColor = Color.Empty;
                btnCor.PressedColor = Color.Empty;
                btnCor.Cursor = Cursors.Hand;

                btnRaLocatario.FillColor = Color.LightGray;
                btnRaLocatario.HoverState.FillColor = Color.Empty;
                btnRaLocatario.PressedColor = Color.Empty;
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
            else if (btnSala.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Sala)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnCor.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Cor)")
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
            else if (btnSala.Cursor == Cursors.No)
            {
                if (txtPesquisarArmario.PlaceholderText == "Pesquisar Armário (Nome)")
                {
                    txtPesquisarArmario.PlaceholderText = "";
                    txtPesquisarArmario.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnCor.Cursor == Cursors.No)
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
            string filtro = txtPesquisarArmario.Text;

            if (filtro.Trim() == "" || filtro.Trim() == "Pesquisar Armário (Número)" || filtro.Trim() == "Pesquisar Armário (RA Locatário)" || filtro.Trim() == "Pesquisar Armário (Sala)" || filtro.Trim() == "Pesquisar Armário (Cor)" || filtro.Trim() == "Pesquisar Armário (Status APM)")
            {
                tblDadosArmarios.Rows.Clear();

                foreach (Armario a in armarios)
                {
                    string ra = "-";
                    if (a.Student != null)
                    {
                        ra = a.Student.Ra;
                    }
                    string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                    string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                    tblDadosArmarios.Rows.Add(row);
                }
            }
            else
            {
                if (controle == 0)
                {
                    tblDadosArmarios.Rows.Clear();
                    tblDadosArmarios.Refresh();

                    foreach (Armario a in armarios)
                    {

                        string ra = "-";
                        if (a.Student != null)
                        {
                            ra = a.Student.Ra;
                        }

                        if (a.Number.ToString().Equals(filtro) || a.Number.ToString().StartsWith(filtro))
                        {
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);
                        }
                    }
                    if (tblDadosArmarios.RowCount == 0)
                    { 

                        MyMessageBoxWarning.ShowBox("O número informado não corresponde a um armário!", "Aviso");
                        foreach (Armario a in armarios)
                        {
                            string ra = "-";
                            if (a.Student != null)
                            {
                                ra = a.Student.Ra;
                            }
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);

                        }
                    }

                }
                else if (controle == 1)
                {

                    tblDadosArmarios.Rows.Clear();
                    tblDadosArmarios.Refresh();

                    foreach (Armario a in armarios)
                    {

                        string ra = "-";
                        if (a.Student != null)
                        {
                            ra = a.Student.Ra;
                        }

                        if (ra.Equals(filtro) || ra.StartsWith(filtro))
                        {
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);
                        }
                    }
                    if (tblDadosArmarios.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O RA informado não corresponde a um armário!", "Aviso");
                        foreach (Armario a in armarios)
                        {
                            string ra = "-";
                            if (a.Student != null)
                            {
                                ra = a.Student.Ra;
                            }
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);

                        }
                    }
                }
                else if (controle == 2)
                {
                    tblDadosArmarios.Rows.Clear();
                    tblDadosArmarios.Refresh();

                    foreach (Armario a in armarios)
                    {
                        string ra = "-";
                        if (a.Student != null)
                        {
                            ra = a.Student.Ra;
                        }
                        if (a.Section.Left_room.ToString().Equals(filtro) || a.Section.Left_room.ToString().Contains(filtro) || a.Section.Right_room.ToString().Equals(filtro) || a.Section.Right_room.ToString().Contains(filtro))
                        {
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);
                        }
                    }
                    if (tblDadosArmarios.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("A sala informado não corresponde a um armário!", "Aviso");
                        foreach (Armario a in armarios)
                        {
                            string ra = "-";
                            if (a.Student != null)
                            {
                                ra = a.Student.Ra;
                            }
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);

                        }
                    }
                }
                else if (controle == 3)
                {
                    tblDadosArmarios.Rows.Clear();
                    tblDadosArmarios.Refresh();

                    foreach (Armario a in armarios)
                    {
                        string ra = "-";
                        if (a.Student != null)
                        {
                            ra = a.Student.Ra;
                        }
                        if (transformHexToPlainText(a.Section.Color.ToString()).Equals(filtro) || transformHexToPlainText(a.Section.Color.ToString()).StartsWith(filtro))
                        {
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);
                        }
                    }
                    if (tblDadosArmarios.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("A cor informada não corresponde a um armário!", "Aviso");
                        foreach (Armario a in armarios)
                        {
                            string ra = "-";
                            if (a.Student != null)
                            {
                                ra = a.Student.Ra;
                            }
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);

                        }
                    }
                }
                else if (controle == 4)
                {
                    tblDadosArmarios.Rows.Clear();
                    tblDadosArmarios.Refresh();

                    foreach (Armario a in armarios)
                    {
                        string ra = "-";
                        if (a.Student != null)
                        {
                            ra = a.Student.Ra;
                        }
                        if (a.IsRented.ToString().Equals(filtro) || a.IsRented.ToString().StartsWith(filtro))
                        {
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);
                        }
                    }
                    if (tblDadosArmarios.RowCount == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O status apm informado não corresponde a um armário!", "Aviso");
                        foreach (Armario a in armarios)
                        {
                            string ra = "-";
                            if (a.Student != null)
                            {
                                ra = a.Student.Ra;
                            }
                            string andar = a.FK_section_id > 4 ? "Primeiro" : "Segundo";
                            string[] row = new string[] { a.Number.ToString(), andar, transformHexToPlainText(a.Section.Color.ToString()), a.Section.Left_room.ToString(), a.Section.Right_room.ToString(), ra };
                            tblDadosArmarios.Rows.Add(row);

                        }
                    }
                }
            }

        }

    }
}
