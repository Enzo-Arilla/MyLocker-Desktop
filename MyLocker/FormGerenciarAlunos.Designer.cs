
namespace MyLocker
{
    partial class FormGerenciarAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarAlunos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblApm = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblArmarios = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGerenciarAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.btnDadosAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDesocuparArmario = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDadosArmarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlugarArmario = new Guna.UI2.WinForms.Guna2Button();
            this.lblFoco = new System.Windows.Forms.Label();
            this.imgPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnTrocarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnFecharAplicativo = new Guna.UI2.WinForms.Guna2Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAlterarFoto = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterarSenha = new Guna.UI2.WinForms.Guna2Button();
            this.gbGerenciar = new MyLocker.MyGroupBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnGerenciamento = new Guna.UI2.WinForms.Guna2Button();
            this.txtUltimoNome = new MyLocker.RJTextBox();
            this.txtPrimeiroNome = new MyLocker.RJTextBox();
            this.txtEmailAluno = new MyLocker.RJTextBox();
            this.txtRaAluno = new MyLocker.RJTextBox();
            this.lblGerenciamento = new MyLocker.MyLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblEditarAluno = new System.Windows.Forms.Label();
            this.lblApagarAluno = new System.Windows.Forms.Label();
            this.lblRegistrarAluno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panel8.SuspendLayout();
            this.gbGerenciar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.lblApm);
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Controls.Add(this.lblArmarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 113);
            this.panel1.TabIndex = 5;
            // 
            // lblApm
            // 
            this.lblApm.AutoSize = true;
            this.lblApm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblApm.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApm.ForeColor = System.Drawing.Color.White;
            this.lblApm.Location = new System.Drawing.Point(668, 26);
            this.lblApm.Name = "lblApm";
            this.lblApm.Size = new System.Drawing.Size(141, 61);
            this.lblApm.TabIndex = 2;
            this.lblApm.Text = "APM";
            this.lblApm.Click += new System.EventHandler(this.lblApm_Click);
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lblAlunos.Location = new System.Drawing.Point(395, 26);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(189, 61);
            this.lblAlunos.TabIndex = 1;
            this.lblAlunos.Text = "Alunos";
            this.lblAlunos.Click += new System.EventHandler(this.lblAlunos_Click);
            // 
            // lblArmarios
            // 
            this.lblArmarios.AutoSize = true;
            this.lblArmarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArmarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmarios.ForeColor = System.Drawing.Color.White;
            this.lblArmarios.Location = new System.Drawing.Point(73, 26);
            this.lblArmarios.Name = "lblArmarios";
            this.lblArmarios.Size = new System.Drawing.Size(240, 61);
            this.lblArmarios.TabIndex = 0;
            this.lblArmarios.Text = "Armários";
            this.lblArmarios.Click += new System.EventHandler(this.lblArmarios_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.btnGerenciarAlunos);
            this.panel7.Controls.Add(this.btnDadosAlunos);
            this.panel7.Location = new System.Drawing.Point(288, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 167);
            this.panel7.TabIndex = 12;
            this.panel7.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 2);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            // 
            // btnGerenciarAlunos
            // 
            this.btnGerenciarAlunos.BorderRadius = 20;
            this.btnGerenciarAlunos.Cursor = System.Windows.Forms.Cursors.No;
            this.btnGerenciarAlunos.CustomizableEdges.TopLeft = false;
            this.btnGerenciarAlunos.CustomizableEdges.TopRight = false;
            this.btnGerenciarAlunos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciarAlunos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciarAlunos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciarAlunos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciarAlunos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnGerenciarAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnGerenciarAlunos.ForeColor = System.Drawing.Color.Black;
            this.btnGerenciarAlunos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnGerenciarAlunos.Location = new System.Drawing.Point(0, 83);
            this.btnGerenciarAlunos.Name = "btnGerenciarAlunos";
            this.btnGerenciarAlunos.Size = new System.Drawing.Size(397, 86);
            this.btnGerenciarAlunos.TabIndex = 6;
            this.btnGerenciarAlunos.Text = "Gerenciar Alunos";
            // 
            // btnDadosAlunos
            // 
            this.btnDadosAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosAlunos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDadosAlunos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDadosAlunos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDadosAlunos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDadosAlunos.FillColor = System.Drawing.Color.White;
            this.btnDadosAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnDadosAlunos.ForeColor = System.Drawing.Color.Black;
            this.btnDadosAlunos.Location = new System.Drawing.Point(0, 0);
            this.btnDadosAlunos.Name = "btnDadosAlunos";
            this.btnDadosAlunos.Size = new System.Drawing.Size(397, 86);
            this.btnDadosAlunos.TabIndex = 5;
            this.btnDadosAlunos.Text = "Dados dos Alunos";
            this.btnDadosAlunos.Click += new System.EventHandler(this.btnDadosAlunos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnDesocuparArmario);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnDadosArmarios);
            this.panel2.Controls.Add(this.btnAlugarArmario);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 254);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 2);
            this.panel5.TabIndex = 9;
            this.panel5.Visible = false;
            // 
            // btnDesocuparArmario
            // 
            this.btnDesocuparArmario.BorderRadius = 20;
            this.btnDesocuparArmario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesocuparArmario.CustomizableEdges.BottomLeft = false;
            this.btnDesocuparArmario.CustomizableEdges.TopLeft = false;
            this.btnDesocuparArmario.CustomizableEdges.TopRight = false;
            this.btnDesocuparArmario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesocuparArmario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesocuparArmario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesocuparArmario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesocuparArmario.FillColor = System.Drawing.Color.White;
            this.btnDesocuparArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F);
            this.btnDesocuparArmario.ForeColor = System.Drawing.Color.Black;
            this.btnDesocuparArmario.Location = new System.Drawing.Point(0, 166);
            this.btnDesocuparArmario.Name = "btnDesocuparArmario";
            this.btnDesocuparArmario.Size = new System.Drawing.Size(397, 86);
            this.btnDesocuparArmario.TabIndex = 7;
            this.btnDesocuparArmario.Text = "Desocupar um Armário";
            this.btnDesocuparArmario.Click += new System.EventHandler(this.btnDesocuparArmario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 2);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // btnDadosArmarios
            // 
            this.btnDadosArmarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosArmarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDadosArmarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDadosArmarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDadosArmarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDadosArmarios.FillColor = System.Drawing.Color.White;
            this.btnDadosArmarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnDadosArmarios.ForeColor = System.Drawing.Color.Black;
            this.btnDadosArmarios.Location = new System.Drawing.Point(0, 83);
            this.btnDadosArmarios.Name = "btnDadosArmarios";
            this.btnDadosArmarios.Size = new System.Drawing.Size(397, 86);
            this.btnDadosArmarios.TabIndex = 6;
            this.btnDadosArmarios.Text = "Dados dos Armários";
            this.btnDadosArmarios.Click += new System.EventHandler(this.btnDadosArmarios_Click);
            // 
            // btnAlugarArmario
            // 
            this.btnAlugarArmario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlugarArmario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugarArmario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugarArmario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlugarArmario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlugarArmario.FillColor = System.Drawing.Color.White;
            this.btnAlugarArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnAlugarArmario.ForeColor = System.Drawing.Color.Black;
            this.btnAlugarArmario.Location = new System.Drawing.Point(0, 0);
            this.btnAlugarArmario.Name = "btnAlugarArmario";
            this.btnAlugarArmario.Size = new System.Drawing.Size(397, 86);
            this.btnAlugarArmario.TabIndex = 5;
            this.btnAlugarArmario.Text = "Alugar um Armário";
            this.btnAlugarArmario.Click += new System.EventHandler(this.btnAlugarArmario_Click);
            // 
            // lblFoco
            // 
            this.lblFoco.AutoSize = true;
            this.lblFoco.Location = new System.Drawing.Point(98, 457);
            this.lblFoco.Name = "lblFoco";
            this.lblFoco.Size = new System.Drawing.Size(0, 13);
            this.lblFoco.TabIndex = 34;
            // 
            // imgPerfil
            // 
            this.imgPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.imgPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPerfil.Image = ((System.Drawing.Image)(resources.GetObject("imgPerfil.Image")));
            this.imgPerfil.ImageRotate = 0F;
            this.imgPerfil.Location = new System.Drawing.Point(1214, 15);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgPerfil.Size = new System.Drawing.Size(85, 82);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 38;
            this.imgPerfil.TabStop = false;
            this.imgPerfil.Click += new System.EventHandler(this.imgPerfil_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.btnTrocarPerfil);
            this.panel8.Controls.Add(this.btnFecharAplicativo);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.btnAlterarFoto);
            this.panel8.Controls.Add(this.btnAlterarSenha);
            this.panel8.Location = new System.Drawing.Point(1043, 113);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(397, 345);
            this.panel8.TabIndex = 53;
            this.panel8.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(0, 252);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(397, 2);
            this.panel11.TabIndex = 11;
            this.panel11.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(0, 166);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(397, 2);
            this.panel9.TabIndex = 9;
            this.panel9.Visible = false;
            // 
            // btnTrocarPerfil
            // 
            this.btnTrocarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrocarPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrocarPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrocarPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrocarPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrocarPerfil.FillColor = System.Drawing.Color.White;
            this.btnTrocarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F);
            this.btnTrocarPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnTrocarPerfil.Location = new System.Drawing.Point(0, 166);
            this.btnTrocarPerfil.Name = "btnTrocarPerfil";
            this.btnTrocarPerfil.Size = new System.Drawing.Size(397, 86);
            this.btnTrocarPerfil.TabIndex = 7;
            this.btnTrocarPerfil.Text = "Trocar Perfil";
            this.btnTrocarPerfil.Click += new System.EventHandler(this.btnTrocarPerfil_Click);
            // 
            // btnFecharAplicativo
            // 
            this.btnFecharAplicativo.BorderRadius = 20;
            this.btnFecharAplicativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharAplicativo.CustomizableEdges.BottomRight = false;
            this.btnFecharAplicativo.CustomizableEdges.TopLeft = false;
            this.btnFecharAplicativo.CustomizableEdges.TopRight = false;
            this.btnFecharAplicativo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharAplicativo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharAplicativo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFecharAplicativo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFecharAplicativo.FillColor = System.Drawing.Color.White;
            this.btnFecharAplicativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F);
            this.btnFecharAplicativo.ForeColor = System.Drawing.Color.Black;
            this.btnFecharAplicativo.Location = new System.Drawing.Point(0, 254);
            this.btnFecharAplicativo.Name = "btnFecharAplicativo";
            this.btnFecharAplicativo.Size = new System.Drawing.Size(397, 86);
            this.btnFecharAplicativo.TabIndex = 10;
            this.btnFecharAplicativo.Text = "Fechar Aplicativo";
            this.btnFecharAplicativo.Click += new System.EventHandler(this.btnFecharAplicativo_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(0, 83);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(397, 2);
            this.panel10.TabIndex = 8;
            this.panel10.Visible = false;
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarFoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterarFoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterarFoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterarFoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlterarFoto.FillColor = System.Drawing.Color.White;
            this.btnAlterarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnAlterarFoto.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarFoto.Location = new System.Drawing.Point(0, 83);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(397, 86);
            this.btnAlterarFoto.TabIndex = 6;
            this.btnAlterarFoto.Text = "Alterar Foto";
            this.btnAlterarFoto.Click += new System.EventHandler(this.btnAlterarFoto_Click);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterarSenha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterarSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterarSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlterarSenha.FillColor = System.Drawing.Color.White;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarSenha.Location = new System.Drawing.Point(0, 0);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(397, 86);
            this.btnAlterarSenha.TabIndex = 5;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // gbGerenciar
            // 
            this.gbGerenciar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbGerenciar.BorderColor = System.Drawing.Color.Transparent;
            this.gbGerenciar.Controls.Add(this.btnBuscar);
            this.gbGerenciar.Controls.Add(this.btnGerenciamento);
            this.gbGerenciar.Controls.Add(this.txtUltimoNome);
            this.gbGerenciar.Controls.Add(this.txtPrimeiroNome);
            this.gbGerenciar.Controls.Add(this.txtEmailAluno);
            this.gbGerenciar.Controls.Add(this.txtRaAluno);
            this.gbGerenciar.Controls.Add(this.lblGerenciamento);
            this.gbGerenciar.Controls.Add(this.panel6);
            this.gbGerenciar.Controls.Add(this.lblEditarAluno);
            this.gbGerenciar.Controls.Add(this.lblApagarAluno);
            this.gbGerenciar.Controls.Add(this.lblRegistrarAluno);
            this.gbGerenciar.Location = new System.Drawing.Point(280, 115);
            this.gbGerenciar.Name = "gbGerenciar";
            this.gbGerenciar.Size = new System.Drawing.Size(1410, 950);
            this.gbGerenciar.TabIndex = 17;
            this.gbGerenciar.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBuscar.Location = new System.Drawing.Point(910, 260);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBuscar.Size = new System.Drawing.Size(85, 85);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Visible = false;
            // 
            // btnGerenciamento
            // 
            this.btnGerenciamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGerenciamento.BorderRadius = 20;
            this.btnGerenciamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnGerenciamento.ForeColor = System.Drawing.Color.Black;
            this.btnGerenciamento.Location = new System.Drawing.Point(472, 820);
            this.btnGerenciamento.Name = "btnGerenciamento";
            this.btnGerenciamento.Size = new System.Drawing.Size(500, 87);
            this.btnGerenciamento.TabIndex = 52;
            this.btnGerenciamento.Text = "Registrar";
            // 
            // txtUltimoNome
            // 
            this.txtUltimoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtUltimoNome.BorderColor = System.Drawing.Color.Transparent;
            this.txtUltimoNome.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtUltimoNome.BorderRadius = 50;
            this.txtUltimoNome.BorderSize = 2;
            this.txtUltimoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUltimoNome.Location = new System.Drawing.Point(414, 632);
            this.txtUltimoNome.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtUltimoNome.Multiline = false;
            this.txtUltimoNome.Name = "txtUltimoNome";
            this.txtUltimoNome.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtUltimoNome.PasswordChar = false;
            this.txtUltimoNome.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtUltimoNome.PlaceholderText = "Último nome";
            this.txtUltimoNome.Size = new System.Drawing.Size(633, 106);
            this.txtUltimoNome.TabIndex = 36;
            this.txtUltimoNome.UnderlinedStyle = false;
            this.txtUltimoNome.Enter += new System.EventHandler(this.txtUltimoNome_Enter);
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtPrimeiroNome.BorderColor = System.Drawing.Color.Transparent;
            this.txtPrimeiroNome.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPrimeiroNome.BorderRadius = 50;
            this.txtPrimeiroNome.BorderSize = 2;
            this.txtPrimeiroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiroNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPrimeiroNome.Location = new System.Drawing.Point(414, 506);
            this.txtPrimeiroNome.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtPrimeiroNome.Multiline = false;
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtPrimeiroNome.PasswordChar = false;
            this.txtPrimeiroNome.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtPrimeiroNome.PlaceholderText = "Primeiro nome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(633, 106);
            this.txtPrimeiroNome.TabIndex = 35;
            this.txtPrimeiroNome.UnderlinedStyle = false;
            this.txtPrimeiroNome.Enter += new System.EventHandler(this.txtPrimeiroNome_Enter);
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtEmailAluno.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmailAluno.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtEmailAluno.BorderRadius = 50;
            this.txtEmailAluno.BorderSize = 2;
            this.txtEmailAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAluno.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEmailAluno.Location = new System.Drawing.Point(414, 378);
            this.txtEmailAluno.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtEmailAluno.Multiline = false;
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtEmailAluno.PasswordChar = false;
            this.txtEmailAluno.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtEmailAluno.PlaceholderText = "E-mail do aluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(633, 106);
            this.txtEmailAluno.TabIndex = 34;
            this.txtEmailAluno.UnderlinedStyle = false;
            this.txtEmailAluno.Enter += new System.EventHandler(this.txtEmailAluno_Enter);
            // 
            // txtRaAluno
            // 
            this.txtRaAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtRaAluno.BorderColor = System.Drawing.Color.Transparent;
            this.txtRaAluno.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtRaAluno.BorderRadius = 50;
            this.txtRaAluno.BorderSize = 2;
            this.txtRaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaAluno.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtRaAluno.Location = new System.Drawing.Point(414, 249);
            this.txtRaAluno.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtRaAluno.Multiline = false;
            this.txtRaAluno.Name = "txtRaAluno";
            this.txtRaAluno.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtRaAluno.PasswordChar = false;
            this.txtRaAluno.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtRaAluno.PlaceholderText = "RA do aluno";
            this.txtRaAluno.Size = new System.Drawing.Size(633, 106);
            this.txtRaAluno.TabIndex = 33;
            this.txtRaAluno.UnderlinedStyle = false;
            this.txtRaAluno.Enter += new System.EventHandler(this.txtRaAluno_Enter);
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.BackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(157)))));
            this.lblGerenciamento.BackColorStart = System.Drawing.Color.Orange;
            this.lblGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.lblGerenciamento.Location = new System.Drawing.Point(566, 164);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(291, 44);
            this.lblGerenciamento.TabIndex = 18;
            this.lblGerenciamento.Text = "Registrar Aluno";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1410, 1);
            this.panel6.TabIndex = 17;
            // 
            // lblEditarAluno
            // 
            this.lblEditarAluno.AutoSize = true;
            this.lblEditarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.lblEditarAluno.Location = new System.Drawing.Point(580, 34);
            this.lblEditarAluno.Name = "lblEditarAluno";
            this.lblEditarAluno.Size = new System.Drawing.Size(234, 44);
            this.lblEditarAluno.TabIndex = 15;
            this.lblEditarAluno.Text = "Editar Aluno";
            this.lblEditarAluno.Click += new System.EventHandler(this.lblEditarAluno_Click);
            // 
            // lblApagarAluno
            // 
            this.lblApagarAluno.AutoSize = true;
            this.lblApagarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblApagarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.lblApagarAluno.Location = new System.Drawing.Point(858, 34);
            this.lblApagarAluno.Name = "lblApagarAluno";
            this.lblApagarAluno.Size = new System.Drawing.Size(258, 44);
            this.lblApagarAluno.TabIndex = 16;
            this.lblApagarAluno.Text = "Apagar Aluno";
            this.lblApagarAluno.Click += new System.EventHandler(this.lblApagarAluno_Click);
            // 
            // lblRegistrarAluno
            // 
            this.lblRegistrarAluno.AutoSize = true;
            this.lblRegistrarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.lblRegistrarAluno.Location = new System.Drawing.Point(224, 34);
            this.lblRegistrarAluno.Name = "lblRegistrarAluno";
            this.lblRegistrarAluno.Size = new System.Drawing.Size(291, 44);
            this.lblRegistrarAluno.TabIndex = 14;
            this.lblRegistrarAluno.Text = "Registrar Aluno";
            this.lblRegistrarAluno.Click += new System.EventHandler(this.lblRegistrarAluno_Click);
            // 
            // FormGerenciarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 839);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.lblFoco);
            this.Controls.Add(this.gbGerenciar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGerenciarAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGerenciarAlunos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panel8.ResumeLayout(false);
            this.gbGerenciar.ResumeLayout(false);
            this.gbGerenciar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApm;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblArmarios;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnGerenciarAlunos;
        private Guna.UI2.WinForms.Guna2Button btnDadosAlunos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnDesocuparArmario;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnDadosArmarios;
        private Guna.UI2.WinForms.Guna2Button btnAlugarArmario;
        private System.Windows.Forms.Label lblRegistrarAluno;
        private System.Windows.Forms.Label lblEditarAluno;
        private System.Windows.Forms.Label lblApagarAluno;
        private MyGroupBox gbGerenciar;
        private System.Windows.Forms.Panel panel6;
        private MyLabel lblGerenciamento;
        private RJTextBox txtRaAluno;
        private System.Windows.Forms.Label lblFoco;
        private RJTextBox txtUltimoNome;
        private RJTextBox txtPrimeiroNome;
        private RJTextBox txtEmailAluno;
        private Guna.UI2.WinForms.Guna2Button btnGerenciamento;
        private Guna.UI2.WinForms.Guna2CircleButton btnBuscar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgPerfil;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2Button btnTrocarPerfil;
        private Guna.UI2.WinForms.Guna2Button btnFecharAplicativo;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2Button btnAlterarFoto;
        private Guna.UI2.WinForms.Guna2Button btnAlterarSenha;
    }
}