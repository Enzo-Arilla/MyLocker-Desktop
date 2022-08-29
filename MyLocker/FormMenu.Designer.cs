
namespace MyLocker
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblInicio = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
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
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientPanelImgPerfil = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAlterarSenha = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrocarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnFecharAplicativo = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GradientPanelImgPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoEllipsis = true;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(66, 648);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(605, 105);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Bem-vindo(a)";
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(130, 323);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(1169, 306);
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoEllipsis = true;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(679, 650);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(297, 105);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.imgPerfil);
            this.panel1.Controls.Add(this.lblApm);
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Controls.Add(this.lblArmarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 113);
            this.panel1.TabIndex = 3;
            // 
            // imgPerfil
            // 
            this.imgPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPerfil.Image = ((System.Drawing.Image)(resources.GetObject("imgPerfil.Image")));
            this.imgPerfil.ImageRotate = 0F;
            this.imgPerfil.Location = new System.Drawing.Point(1214, 15);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgPerfil.Size = new System.Drawing.Size(85, 82);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 35;
            this.imgPerfil.TabStop = false;
            this.imgPerfil.Click += new System.EventHandler(this.imgPerfil_Click);
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
            this.lblAlunos.ForeColor = System.Drawing.Color.White;
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
            this.panel7.TabIndex = 10;
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
            this.btnGerenciarAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarAlunos.CustomizableEdges.TopLeft = false;
            this.btnGerenciarAlunos.CustomizableEdges.TopRight = false;
            this.btnGerenciarAlunos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciarAlunos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciarAlunos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciarAlunos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciarAlunos.FillColor = System.Drawing.Color.White;
            this.btnGerenciarAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnGerenciarAlunos.ForeColor = System.Drawing.Color.Black;
            this.btnGerenciarAlunos.Location = new System.Drawing.Point(0, 83);
            this.btnGerenciarAlunos.Name = "btnGerenciarAlunos";
            this.btnGerenciarAlunos.Size = new System.Drawing.Size(397, 86);
            this.btnGerenciarAlunos.TabIndex = 6;
            this.btnGerenciarAlunos.Text = "Gerenciar Alunos";
            this.btnGerenciarAlunos.Click += new System.EventHandler(this.btnGerenciarAlunos_Click);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnDesocuparArmario);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnDadosArmarios);
            this.panel2.Controls.Add(this.btnAlugarArmario);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 252);
            this.panel2.TabIndex = 4;
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
            this.btnDesocuparArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
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
            this.btnAlugarArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugarArmario.ForeColor = System.Drawing.Color.Black;
            this.btnAlugarArmario.Location = new System.Drawing.Point(0, 0);
            this.btnAlugarArmario.Name = "btnAlugarArmario";
            this.btnAlugarArmario.Size = new System.Drawing.Size(397, 86);
            this.btnAlugarArmario.TabIndex = 5;
            this.btnAlugarArmario.Text = "Alugar um Armário";
            this.btnAlugarArmario.Click += new System.EventHandler(this.btnAlugarArmario_Click);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(487, 755);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 105);
            this.lblData.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2GradientPanelImgPerfil
            // 
            this.guna2GradientPanelImgPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanelImgPerfil.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanelImgPerfil.Controls.Add(this.panel8);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.btnAlterarSenha);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.btnTrocarPerfil);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.btnFecharAplicativo);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.panel6);
            this.guna2GradientPanelImgPerfil.Location = new System.Drawing.Point(1043, 111);
            this.guna2GradientPanelImgPerfil.Name = "guna2GradientPanelImgPerfil";
            this.guna2GradientPanelImgPerfil.Size = new System.Drawing.Size(397, 271);
            this.guna2GradientPanelImgPerfil.TabIndex = 67;
            this.guna2GradientPanelImgPerfil.UseTransparentBackground = true;
            this.guna2GradientPanelImgPerfil.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(1, 178);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(395, 2);
            this.panel8.TabIndex = 67;
            this.panel8.Visible = false;
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
            this.btnAlterarSenha.Location = new System.Drawing.Point(0, 3);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(396, 86);
            this.btnAlterarSenha.TabIndex = 66;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
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
            this.btnTrocarPerfil.Location = new System.Drawing.Point(0, 93);
            this.btnTrocarPerfil.Name = "btnTrocarPerfil";
            this.btnTrocarPerfil.Size = new System.Drawing.Size(395, 87);
            this.btnTrocarPerfil.TabIndex = 66;
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
            this.btnFecharAplicativo.Location = new System.Drawing.Point(0, 178);
            this.btnFecharAplicativo.Name = "btnFecharAplicativo";
            this.btnFecharAplicativo.Size = new System.Drawing.Size(397, 86);
            this.btnFecharAplicativo.TabIndex = 66;
            this.btnFecharAplicativo.Text = "Fechar Aplicativo";
            this.btnFecharAplicativo.Click += new System.EventHandler(this.btnFecharAplicativo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(394, 2);
            this.panel6.TabIndex = 12;
            this.panel6.Visible = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.guna2GradientPanelImgPerfil);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblInicio);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.guna2GradientPanelImgPerfil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApm;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAlugarArmario;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnDesocuparArmario;
        private Guna.UI2.WinForms.Guna2Button btnDadosArmarios;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button btnGerenciarAlunos;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnDadosAlunos;
        private System.Windows.Forms.Label lblArmarios;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgPerfil;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanelImgPerfil;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button btnAlterarSenha;
        private Guna.UI2.WinForms.Guna2Button btnTrocarPerfil;
        private Guna.UI2.WinForms.Guna2Button btnFecharAplicativo;
        private System.Windows.Forms.Panel panel6;
    }
}