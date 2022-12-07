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
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace MyLocker
{
    public partial class FormApm : Form
    {
        string ra;
        string nome;
        string sobrenome;
        int controle = 0;
        string filtro;
        Apm[] apms = null;

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

        static async Task ChangeApmStatus(ChangeApmStatusRequest changeApmStatusRequest)
        {
            var apiClient = RestService.For<IRepositorioAPM>("https://mylocker-api.herokuapp.com");
            
            await apiClient.changeApmStatus(changeApmStatusRequest); 
        }

        async private void FormApm_Load(object sender, EventArgs e)
        {
            var Load = new Carregamento();
            Load.Show();
            apms = await ListApms();

            foreach (Apm a in apms)
            {
                if(a.Status == 1)
                {
                    nome = a.Student.First_name;
                    sobrenome = a.Student.Last_name;
                    string[] row = new string[] { a.Id.ToString(), a.FK_Student_Ra, nome, sobrenome, a.RequisitionPdf };
                    tblApm.Rows.Add(row);
                }
            }

            Load.Close();
        }

        private async void tblApm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Load = new Carregamento();

            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                Load.Show();
                int row = e.RowIndex;
                string link = tblApm[4, row].Value.ToString();
                System.Diagnostics.Process.Start(link);
                Load.Close();
            }
            else if(e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                Load.Show();
                int row = e.RowIndex;
                int id = int.Parse(tblApm[0, row].Value.ToString());
                ChangeApmStatusRequest changeApmStatusRequest = new ChangeApmStatusRequest(id, 2, Usuario.Cpf);
                try
                {
                    await ChangeApmStatus(changeApmStatusRequest);
                    Load.Close();
                    MyMessageBoxSucess.ShowBox("Apm aprovada com sucesso!", "Sucesso");
                    tblApm.Rows.RemoveAt(row);
                }
                catch(ApiException erro)
                {
                    Load.Close();
                    string[] mensagemErro = erro.Content.Split('"');
                    MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                }
            }
            else if(e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                Load.Show();
                int row = e.RowIndex;
                int id = int.Parse(tblApm[0, row].Value.ToString());

                ChangeApmStatusRequest changeApmStatusRequest = new ChangeApmStatusRequest(id, 0, Usuario.Cpf);
                try
                {
                    await ChangeApmStatus(changeApmStatusRequest);
                    Load.Close();
                    MyMessageBoxSucess.ShowBox("Apm reprovada com sucesso!", "Sucesso");
                    tblApm.Rows.RemoveAt(row);
                }
                catch(ApiException erro)
                {
                    Load.Close();
                    string[] mensagemErro = erro.Content.Split('"');
                    MyMessageBoxError.ShowBox(mensagemErro[3], "Erro");
                }
            }

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

        private void btnTipoPesquisa_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == false)
            {
                panel7.Visible = true;
                panel10.Visible = true;
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
                panel7.Visible = false;
                panel10.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
            }
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

        private void btnId_Click(object sender, EventArgs e)
        {
            if (btnId.Cursor == Cursors.Hand)
            {
                controle = 0;

                btnId.FillColor = Color.FromArgb(255, 220, 81);
                btnId.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnId.PressedColor = Color.FromArgb(255, 220, 81);
                btnId.Cursor = Cursors.No;

                btnRa.FillColor = Color.LightGray;
                btnRa.HoverState.FillColor = Color.Empty;
                btnRa.PressedColor = Color.Empty;
                btnRa.Cursor = Cursors.Hand;

                btnNome.FillColor = Color.LightGray;
                btnNome.HoverState.FillColor = Color.Empty;
                btnNome.PressedColor = Color.Empty;
                btnNome.Cursor = Cursors.Hand;

                btnSobrenome.FillColor = Color.LightGray;
                btnSobrenome.HoverState.FillColor = Color.Empty;
                btnSobrenome.PressedColor = Color.Empty;
                btnSobrenome.Cursor = Cursors.Hand;

                txtPesquisarApm.PlaceholderText = "Pesquisar APM (ID)";
            }
        }

        private void btnRa_Click(object sender, EventArgs e)
        {
            if(btnRa.Cursor == Cursors.Hand)
            {
                controle = 1;

                btnRa.FillColor = Color.FromArgb(255, 220, 81);
                btnRa.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnRa.PressedColor = Color.FromArgb(255, 220, 81);
                btnRa.Cursor = Cursors.No;

                btnId.FillColor = Color.LightGray;
                btnId.HoverState.FillColor = Color.Empty;
                btnId.PressedColor = Color.Empty;
                btnId.Cursor = Cursors.Hand;

                btnNome.FillColor = Color.LightGray;
                btnNome.HoverState.FillColor = Color.Empty;
                btnNome.PressedColor = Color.Empty;
                btnNome.Cursor = Cursors.Hand;

                btnSobrenome.FillColor = Color.LightGray;
                btnSobrenome.HoverState.FillColor = Color.Empty;
                btnSobrenome.PressedColor = Color.Empty;
                btnSobrenome.Cursor = Cursors.Hand;

                txtPesquisarApm.PlaceholderText = "Pesquisar APM (RA Locatário)";
            }
            
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (btnNome.Cursor == Cursors.Hand)
            {
                controle = 2;

                btnNome.FillColor = Color.FromArgb(255, 220, 81);
                btnNome.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnNome.PressedColor = Color.FromArgb(255, 220, 81);
                btnNome.Cursor = Cursors.No;

                btnId.FillColor = Color.LightGray;
                btnId.HoverState.FillColor = Color.Empty;
                btnId.PressedColor = Color.Empty;
                btnId.Cursor = Cursors.Hand;

                btnRa.FillColor = Color.LightGray;
                btnRa.HoverState.FillColor = Color.Empty;
                btnRa.PressedColor = Color.Empty;
                btnRa.Cursor = Cursors.Hand;

                btnSobrenome.FillColor = Color.LightGray;
                btnSobrenome.HoverState.FillColor = Color.Empty;
                btnSobrenome.PressedColor = Color.Empty;
                btnSobrenome.Cursor = Cursors.Hand;

                txtPesquisarApm.PlaceholderText = "Pesquisar APM (Nome)";
            }
        }

        private void btnSobrenome_Click(object sender, EventArgs e)
        {
            if (btnSobrenome.Cursor == Cursors.Hand)
            {
                controle = 3;

                btnSobrenome.FillColor = Color.FromArgb(255, 220, 81);
                btnSobrenome.HoverState.FillColor = Color.FromArgb(255, 220, 81);
                btnSobrenome.PressedColor = Color.FromArgb(255, 220, 81);
                btnSobrenome.Cursor = Cursors.No;

                btnId.FillColor = Color.LightGray;
                btnId.HoverState.FillColor = Color.Empty;
                btnId.PressedColor = Color.Empty;
                btnId.Cursor = Cursors.Hand;

                btnRa.FillColor = Color.LightGray;
                btnRa.HoverState.FillColor = Color.Empty;
                btnRa.PressedColor = Color.Empty;
                btnRa.Cursor = Cursors.Hand;

                btnNome.FillColor = Color.LightGray;
                btnNome.HoverState.FillColor = Color.Empty;
                btnNome.PressedColor = Color.Empty;
                btnNome.Cursor = Cursors.Hand;

                txtPesquisarApm.PlaceholderText = "Pesquisar APM (Sobrenome)";
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            apms = await ListApms();

            filtro = txtPesquisarApm.Text;

            if (filtro.Trim() == "" || filtro.Trim() == "Pesquisar APM (ID)" || filtro.Trim() == "Pesquisar APM (RA Locatário)" || filtro.Trim() == "Pesquisar APM (Nome)" || filtro.Trim() == "Pesquisar APM (Sobrenome)")
            {
                foreach (Apm a in apms)
                {
                    if (a.Status == 1)
                    {
                        nome = a.Student.First_name;
                        sobrenome = a.Student.Last_name;
                        string[] row = new string[] { a.Id.ToString(), a.FK_Student_Ra, nome, sobrenome, a.RequisitionPdf };
                        tblApm.Rows.Add(row);
                    }
                }
            }
            else
            {
                if (controle == 0)
                {
                    tblApm.Rows.Clear();
                    tblApm.Refresh();

                    foreach (Apm a in apms)
                    {
                        if(a.Id.ToString().Equals(filtro))
                        {
                            string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                            tblApm.Rows.Add(row);
                        }
                    }

                    if(tblApm.Rows.Count == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O ID informado não corresponde à uma solitação de APM", "Aviso");
                        foreach (Apm a in apms)
                        {
                            if (a.Id.ToString().Equals(filtro))
                            {
                                string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                                tblApm.Rows.Add(row);
                            }
                        }
                    }

                }
                else if(controle == 1)
                {
                    filtro = txtPesquisarApm.Text;

                    tblApm.Rows.Clear();
                    tblApm.Refresh();

                    foreach (Apm a in apms)
                    {
                        if (a.Student.Ra.Equals(filtro))
                        {
                            string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                            tblApm.Rows.Add(row);
                        }

                    }

                    if (tblApm.Rows.Count == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O RA informado não corresponde à uma solitação de APM", "Aviso");
                        foreach (Apm a in apms)
                        {
                            string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                            tblApm.Rows.Add(row);
                        }
                    }
                } 
                else if(controle == 2)
                {
                    filtro = txtPesquisarApm.Text;

                    tblApm.Rows.Clear();
                    tblApm.Refresh();

                    foreach (Apm a in apms)
                    {
                        if (a.Student.First_name.Equals(filtro))
                        {
                            string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                            tblApm.Rows.Add(row);
                        }

                    }

                    if (tblApm.Rows.Count == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O nome informado não corresponde à uma solitação de APM", "Aviso");
                        foreach (Apm a in apms)
                        {
                            string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                            tblApm.Rows.Add(row);
                        }
                    }
                }
                else if(controle == 3)
                {
                    filtro = txtPesquisarApm.Text;

                    tblApm.Rows.Clear();
                    tblApm.Refresh();

                    foreach (Apm a in apms)
                    {
                        if (a.Student.Last_name.Equals(filtro))
                        {
                            string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                            tblApm.Rows.Add(row);
                        }

                    }

                    if (tblApm.Rows.Count == 0)
                    {
                        MyMessageBoxWarning.ShowBox("O sobrenome informado não corresponde à uma solitação de APM", "Aviso");
                        foreach (Apm a in apms)
                        {
                            string[] row = new string[] { a.Id.ToString(), a.Student.Ra, a.Student.First_name, a.Student.Last_name, a.RequisitionPdf };
                            tblApm.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void tblApm_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6) && e.RowIndex >= 0)
            {
                tblApm.Cursor = Cursors.Hand;
            }
            else
            {
                tblApm.Cursor = Cursors.Arrow;
            }
        }

        private void txtPesquisarApm_Enter(object sender, EventArgs e)
        {
            
            if (btnId.Cursor == Cursors.No)
            {
                if (txtPesquisarApm.PlaceholderText == "Pesquisar APM (ID)")
                {
                    txtPesquisarApm.PlaceholderText = "";
                    txtPesquisarApm.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnRa.Cursor == Cursors.No)
            {
                if (txtPesquisarApm.PlaceholderText == "Pesquisar APM (RA Locatário)")
                {
                    txtPesquisarApm.PlaceholderText = "";
                    txtPesquisarApm.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnNome.Cursor == Cursors.No)
            {
                if (txtPesquisarApm.PlaceholderText == "Pesquisar APM (Nome)")
                {
                    txtPesquisarApm.PlaceholderText = "";
                    txtPesquisarApm.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }
            else if (btnSobrenome.Cursor == Cursors.No)
            {
                if (txtPesquisarApm.PlaceholderText == "Pesquisar APM (Sobrenome)")
                {
                    txtPesquisarApm.PlaceholderText = "";
                    txtPesquisarApm.ForeColor = Color.Black;
                }
                panel10.Visible = false;
            }            
        }
    }
}
