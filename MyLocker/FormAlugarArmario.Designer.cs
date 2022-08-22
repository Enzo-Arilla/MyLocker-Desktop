
namespace MyLocker
{
    partial class FormAlugarArmario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlugarArmario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblApm = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblArmarios = new System.Windows.Forms.Label();
            this.lblFoco = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDesocuparArmario = new Guna.UI2.WinForms.Guna2Button();
            this.btnDadosArmarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlugarArmario = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnGerenciarAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.btnDadosAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.gpGerenciamento = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnProcurar = new Guna.UI2.WinForms.Guna2Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblResultadoSituacao = new System.Windows.Forms.Label();
            this.lblResultadoSalaDireita = new System.Windows.Forms.Label();
            this.lblResultadoSalaEsquerda = new System.Windows.Forms.Label();
            this.lblResultadoAndar = new System.Windows.Forms.Label();
            this.btnAlugar = new Guna.UI2.WinForms.Guna2Button();
            this.lblAlugarArmario = new System.Windows.Forms.Label();
            this.lblResultadoCor = new System.Windows.Forms.Label();
            this.btnDisponibilidade = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblSalaDireita = new System.Windows.Forms.Label();
            this.lblSalaEsquerda = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAndar = new System.Windows.Forms.Label();
            this.cbPossuiApm = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lblPossuiApm = new System.Windows.Forms.Label();
            this.lblDadosArmario = new System.Windows.Forms.Label();
            this.guna2GradientPanelImgPerfil = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAlterarSenha = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrocarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnFecharAplicativo = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRaAluno = new MyLocker.RJTextBox();
            this.txtNumeroArmario = new MyLocker.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gpGerenciamento.SuspendLayout();
            this.guna2GradientPanelImgPerfil.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 4;
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
            this.imgPerfil.TabIndex = 36;
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
            this.lblArmarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lblArmarios.Location = new System.Drawing.Point(73, 26);
            this.lblArmarios.Name = "lblArmarios";
            this.lblArmarios.Size = new System.Drawing.Size(240, 61);
            this.lblArmarios.TabIndex = 0;
            this.lblArmarios.Text = "Armários";
            this.lblArmarios.Click += new System.EventHandler(this.lblArmarios_Click);
            // 
            // lblFoco
            // 
            this.lblFoco.AutoSize = true;
            this.lblFoco.Location = new System.Drawing.Point(787, 221);
            this.lblFoco.Name = "lblFoco";
            this.lblFoco.Size = new System.Drawing.Size(0, 13);
            this.lblFoco.TabIndex = 34;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnDesocuparArmario);
            this.panel2.Controls.Add(this.btnDadosArmarios);
            this.panel2.Controls.Add(this.btnAlugarArmario);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 252);
            this.panel2.TabIndex = 48;
            this.panel2.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 83);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 2);
            this.panel6.TabIndex = 9;
            // 
            // btnDesocuparArmario
            // 
            this.btnDesocuparArmario.BackColor = System.Drawing.Color.White;
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
            this.btnAlugarArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnAlugarArmario.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAlugarArmario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugarArmario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugarArmario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlugarArmario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlugarArmario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnAlugarArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnAlugarArmario.ForeColor = System.Drawing.Color.Black;
            this.btnAlugarArmario.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnAlugarArmario.Location = new System.Drawing.Point(0, 0);
            this.btnAlugarArmario.Name = "btnAlugarArmario";
            this.btnAlugarArmario.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnAlugarArmario.PressedDepth = 0;
            this.btnAlugarArmario.Size = new System.Drawing.Size(397, 86);
            this.btnAlugarArmario.TabIndex = 5;
            this.btnAlugarArmario.Text = "Alugar um Armário";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 2);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.btnGerenciarAlunos);
            this.panel7.Controls.Add(this.btnDadosAlunos);
            this.panel7.Location = new System.Drawing.Point(288, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 167);
            this.panel7.TabIndex = 49;
            this.panel7.Visible = false;
            // 
            // btnGerenciarAlunos
            // 
            this.btnGerenciarAlunos.BackColor = System.Drawing.Color.White;
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
            // gpGerenciamento
            // 
            this.gpGerenciamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpGerenciamento.BorderColor = System.Drawing.Color.White;
            this.gpGerenciamento.BorderRadius = 10;
            this.gpGerenciamento.Controls.Add(this.btnProcurar);
            this.gpGerenciamento.Controls.Add(this.panel10);
            this.gpGerenciamento.Controls.Add(this.lblResultadoSituacao);
            this.gpGerenciamento.Controls.Add(this.lblResultadoSalaDireita);
            this.gpGerenciamento.Controls.Add(this.lblResultadoSalaEsquerda);
            this.gpGerenciamento.Controls.Add(this.lblResultadoAndar);
            this.gpGerenciamento.Controls.Add(this.btnAlugar);
            this.gpGerenciamento.Controls.Add(this.lblAlugarArmario);
            this.gpGerenciamento.Controls.Add(this.lblResultadoCor);
            this.gpGerenciamento.Controls.Add(this.btnDisponibilidade);
            this.gpGerenciamento.Controls.Add(this.lblSituacao);
            this.gpGerenciamento.Controls.Add(this.lblSalaDireita);
            this.gpGerenciamento.Controls.Add(this.lblSalaEsquerda);
            this.gpGerenciamento.Controls.Add(this.lblCor);
            this.gpGerenciamento.Controls.Add(this.lblAndar);
            this.gpGerenciamento.Controls.Add(this.txtRaAluno);
            this.gpGerenciamento.Controls.Add(this.txtNumeroArmario);
            this.gpGerenciamento.Controls.Add(this.cbPossuiApm);
            this.gpGerenciamento.Controls.Add(this.lblPossuiApm);
            this.gpGerenciamento.Controls.Add(this.lblDadosArmario);
            this.gpGerenciamento.CustomBorderColor = System.Drawing.Color.White;
            this.gpGerenciamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpGerenciamento.ForeColor = System.Drawing.Color.White;
            this.gpGerenciamento.Location = new System.Drawing.Point(113, 148);
            this.gpGerenciamento.Name = "gpGerenciamento";
            this.gpGerenciamento.Size = new System.Drawing.Size(1200, 900);
            this.gpGerenciamento.TabIndex = 50;
            this.gpGerenciamento.Text = "guna2GroupBox1";
            this.gpGerenciamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gpGerenciamento_KeyPress);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.White;
            this.btnProcurar.BorderRadius = 20;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProcurar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProcurar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProcurar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProcurar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.Black;
            this.btnProcurar.Location = new System.Drawing.Point(165, 608);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(275, 87);
            this.btnProcurar.TabIndex = 91;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.ForeColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(930, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 900);
            this.panel10.TabIndex = 90;
            // 
            // lblResultadoSituacao
            // 
            this.lblResultadoSituacao.AutoSize = true;
            this.lblResultadoSituacao.BackColor = System.Drawing.Color.White;
            this.lblResultadoSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoSituacao.Location = new System.Drawing.Point(1266, 485);
            this.lblResultadoSituacao.Name = "lblResultadoSituacao";
            this.lblResultadoSituacao.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoSituacao.TabIndex = 89;
            this.lblResultadoSituacao.Text = "Vermelho";
            // 
            // lblResultadoSalaDireita
            // 
            this.lblResultadoSalaDireita.AutoSize = true;
            this.lblResultadoSalaDireita.BackColor = System.Drawing.Color.White;
            this.lblResultadoSalaDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSalaDireita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoSalaDireita.Location = new System.Drawing.Point(1324, 423);
            this.lblResultadoSalaDireita.Name = "lblResultadoSalaDireita";
            this.lblResultadoSalaDireita.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoSalaDireita.TabIndex = 88;
            this.lblResultadoSalaDireita.Text = "Vermelho";
            // 
            // lblResultadoSalaEsquerda
            // 
            this.lblResultadoSalaEsquerda.AutoSize = true;
            this.lblResultadoSalaEsquerda.BackColor = System.Drawing.Color.White;
            this.lblResultadoSalaEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSalaEsquerda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoSalaEsquerda.Location = new System.Drawing.Point(1376, 360);
            this.lblResultadoSalaEsquerda.Name = "lblResultadoSalaEsquerda";
            this.lblResultadoSalaEsquerda.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoSalaEsquerda.TabIndex = 87;
            this.lblResultadoSalaEsquerda.Text = "Vermelho";
            // 
            // lblResultadoAndar
            // 
            this.lblResultadoAndar.AutoSize = true;
            this.lblResultadoAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoAndar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoAndar.Location = new System.Drawing.Point(1204, 222);
            this.lblResultadoAndar.Name = "lblResultadoAndar";
            this.lblResultadoAndar.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoAndar.TabIndex = 86;
            this.lblResultadoAndar.Text = "Vermelho";
            // 
            // btnAlugar
            // 
            this.btnAlugar.BackColor = System.Drawing.Color.White;
            this.btnAlugar.BorderRadius = 20;
            this.btnAlugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlugar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlugar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlugar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.ForeColor = System.Drawing.Color.Black;
            this.btnAlugar.Location = new System.Drawing.Point(565, 608);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(275, 87);
            this.btnAlugar.TabIndex = 85;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // lblAlugarArmario
            // 
            this.lblAlugarArmario.AllowDrop = true;
            this.lblAlugarArmario.AutoEllipsis = true;
            this.lblAlugarArmario.AutoSize = true;
            this.lblAlugarArmario.BackColor = System.Drawing.Color.Transparent;
            this.lblAlugarArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlugarArmario.ForeColor = System.Drawing.Color.Black;
            this.lblAlugarArmario.Location = new System.Drawing.Point(108, 134);
            this.lblAlugarArmario.Name = "lblAlugarArmario";
            this.lblAlugarArmario.Size = new System.Drawing.Size(380, 61);
            this.lblAlugarArmario.TabIndex = 72;
            this.lblAlugarArmario.Text = "Alugar Armário";
            // 
            // lblResultadoCor
            // 
            this.lblResultadoCor.AutoSize = true;
            this.lblResultadoCor.BackColor = System.Drawing.Color.White;
            this.lblResultadoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoCor.Location = new System.Drawing.Point(1147, 294);
            this.lblResultadoCor.Name = "lblResultadoCor";
            this.lblResultadoCor.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoCor.TabIndex = 84;
            this.lblResultadoCor.Text = "Vermelho";
            // 
            // btnDisponibilidade
            // 
            this.btnDisponibilidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDisponibilidade.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisponibilidade.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisponibilidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisponibilidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisponibilidade.FillColor = System.Drawing.Color.White;
            this.btnDisponibilidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisponibilidade.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisponibilidade.Location = new System.Drawing.Point(758, 254);
            this.btnDisponibilidade.Name = "btnDisponibilidade";
            this.btnDisponibilidade.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDisponibilidade.Size = new System.Drawing.Size(65, 65);
            this.btnDisponibilidade.TabIndex = 83;
            this.btnDisponibilidade.Visible = false;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.BackColor = System.Drawing.Color.Transparent;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.Black;
            this.lblSituacao.Location = new System.Drawing.Point(1042, 488);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(218, 54);
            this.lblSituacao.TabIndex = 82;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblSalaDireita
            // 
            this.lblSalaDireita.AutoSize = true;
            this.lblSalaDireita.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaDireita.ForeColor = System.Drawing.Color.Black;
            this.lblSalaDireita.Location = new System.Drawing.Point(1042, 423);
            this.lblSalaDireita.Name = "lblSalaDireita";
            this.lblSalaDireita.Size = new System.Drawing.Size(276, 54);
            this.lblSalaDireita.TabIndex = 81;
            this.lblSalaDireita.Text = "Sala Direita:";
            // 
            // lblSalaEsquerda
            // 
            this.lblSalaEsquerda.AutoSize = true;
            this.lblSalaEsquerda.BackColor = System.Drawing.Color.White;
            this.lblSalaEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaEsquerda.ForeColor = System.Drawing.Color.Black;
            this.lblSalaEsquerda.Location = new System.Drawing.Point(1042, 353);
            this.lblSalaEsquerda.Name = "lblSalaEsquerda";
            this.lblSalaEsquerda.Size = new System.Drawing.Size(342, 54);
            this.lblSalaEsquerda.TabIndex = 80;
            this.lblSalaEsquerda.Text = "Sala Esquerda:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.White;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.Black;
            this.lblCor.Location = new System.Drawing.Point(1042, 292);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(112, 54);
            this.lblCor.TabIndex = 79;
            this.lblCor.Text = "Cor:";
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.BackColor = System.Drawing.Color.White;
            this.lblAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndar.ForeColor = System.Drawing.Color.Black;
            this.lblAndar.Location = new System.Drawing.Point(1042, 224);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(161, 54);
            this.lblAndar.TabIndex = 78;
            this.lblAndar.Text = "Andar:";
            // 
            // cbPossuiApm
            // 
            this.cbPossuiApm.BackColor = System.Drawing.Color.Transparent;
            this.cbPossuiApm.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPossuiApm.CheckedState.BorderRadius = 2;
            this.cbPossuiApm.CheckedState.BorderThickness = 0;
            this.cbPossuiApm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPossuiApm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPossuiApm.ForeColor = System.Drawing.Color.White;
            this.cbPossuiApm.Location = new System.Drawing.Point(458, 544);
            this.cbPossuiApm.Name = "cbPossuiApm";
            this.cbPossuiApm.Size = new System.Drawing.Size(20, 20);
            this.cbPossuiApm.TabIndex = 76;
            this.cbPossuiApm.Text = "guna2CustomCheckBox1";
            this.cbPossuiApm.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPossuiApm.UncheckedState.BorderRadius = 2;
            this.cbPossuiApm.UncheckedState.BorderThickness = 0;
            this.cbPossuiApm.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPossuiApm.UseTransparentBackground = true;
            // 
            // lblPossuiApm
            // 
            this.lblPossuiApm.AutoSize = true;
            this.lblPossuiApm.BackColor = System.Drawing.Color.Transparent;
            this.lblPossuiApm.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossuiApm.ForeColor = System.Drawing.Color.Black;
            this.lblPossuiApm.Location = new System.Drawing.Point(108, 523);
            this.lblPossuiApm.Name = "lblPossuiApm";
            this.lblPossuiApm.Size = new System.Drawing.Size(344, 61);
            this.lblPossuiApm.TabIndex = 75;
            this.lblPossuiApm.Text = "Possui APM?";
            // 
            // lblDadosArmario
            // 
            this.lblDadosArmario.AutoSize = true;
            this.lblDadosArmario.BackColor = System.Drawing.Color.White;
            this.lblDadosArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosArmario.Location = new System.Drawing.Point(1040, 86);
            this.lblDadosArmario.Name = "lblDadosArmario";
            this.lblDadosArmario.Size = new System.Drawing.Size(451, 61);
            this.lblDadosArmario.TabIndex = 77;
            this.lblDadosArmario.Text = "Dados do Armário";
            // 
            // guna2GradientPanelImgPerfil
            // 
            this.guna2GradientPanelImgPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanelImgPerfil.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanelImgPerfil.Controls.Add(this.panel8);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.btnAlterarSenha);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.btnTrocarPerfil);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.btnFecharAplicativo);
            this.guna2GradientPanelImgPerfil.Controls.Add(this.panel3);
            this.guna2GradientPanelImgPerfil.Location = new System.Drawing.Point(1043, 113);
            this.guna2GradientPanelImgPerfil.Name = "guna2GradientPanelImgPerfil";
            this.guna2GradientPanelImgPerfil.Size = new System.Drawing.Size(397, 271);
            this.guna2GradientPanelImgPerfil.TabIndex = 66;
            this.guna2GradientPanelImgPerfil.UseTransparentBackground = true;
            this.guna2GradientPanelImgPerfil.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(3, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(397, 2);
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
            this.btnAlterarSenha.Location = new System.Drawing.Point(3, 3);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(393, 86);
            this.btnAlterarSenha.TabIndex = 66;
            this.btnAlterarSenha.Text = "Alterar Senha";
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
            this.btnTrocarPerfil.Location = new System.Drawing.Point(2, 93);
            this.btnTrocarPerfil.Name = "btnTrocarPerfil";
            this.btnTrocarPerfil.Size = new System.Drawing.Size(394, 87);
            this.btnTrocarPerfil.TabIndex = 66;
            this.btnTrocarPerfil.Text = "Trocar Perfil";
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
            this.btnFecharAplicativo.Location = new System.Drawing.Point(2, 182);
            this.btnFecharAplicativo.Name = "btnFecharAplicativo";
            this.btnFecharAplicativo.Size = new System.Drawing.Size(394, 86);
            this.btnFecharAplicativo.TabIndex = 66;
            this.btnFecharAplicativo.Text = "Fechar Aplicativo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 2);
            this.panel3.TabIndex = 12;
            this.panel3.Visible = false;
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
            this.txtRaAluno.Location = new System.Drawing.Point(92, 370);
            this.txtRaAluno.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtRaAluno.Multiline = false;
            this.txtRaAluno.Name = "txtRaAluno";
            this.txtRaAluno.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtRaAluno.PasswordChar = false;
            this.txtRaAluno.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtRaAluno.PlaceholderText = "RA do Aluno";
            this.txtRaAluno.Size = new System.Drawing.Size(761, 109);
            this.txtRaAluno.TabIndex = 74;
            this.txtRaAluno.UnderlinedStyle = false;
            this.txtRaAluno.Enter += new System.EventHandler(this.txtRaAluno_Enter);
            // 
            // txtNumeroArmario
            // 
            this.txtNumeroArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtNumeroArmario.BorderColor = System.Drawing.Color.Transparent;
            this.txtNumeroArmario.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNumeroArmario.BorderRadius = 50;
            this.txtNumeroArmario.BorderSize = 2;
            this.txtNumeroArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroArmario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNumeroArmario.Location = new System.Drawing.Point(92, 233);
            this.txtNumeroArmario.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtNumeroArmario.Multiline = false;
            this.txtNumeroArmario.Name = "txtNumeroArmario";
            this.txtNumeroArmario.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtNumeroArmario.PasswordChar = false;
            this.txtNumeroArmario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtNumeroArmario.PlaceholderText = "Número do Armário";
            this.txtNumeroArmario.Size = new System.Drawing.Size(761, 109);
            this.txtNumeroArmario.TabIndex = 73;
            this.txtNumeroArmario.UnderlinedStyle = false;
            this.txtNumeroArmario.Enter += new System.EventHandler(this.txtNumeroArmario_Enter);
            // 
            // FormAlugarArmario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.guna2GradientPanelImgPerfil);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gpGerenciamento);
            this.Controls.Add(this.lblFoco);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlugarArmario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAlugarArmario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.gpGerenciamento.ResumeLayout(false);
            this.gpGerenciamento.PerformLayout();
            this.guna2GradientPanelImgPerfil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApm;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblArmarios;
        private System.Windows.Forms.Label lblFoco;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnDesocuparArmario;
        private Guna.UI2.WinForms.Guna2Button btnDadosArmarios;
        private Guna.UI2.WinForms.Guna2Button btnAlugarArmario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button btnGerenciarAlunos;
        private Guna.UI2.WinForms.Guna2Button btnDadosAlunos;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgPerfil;
        private Guna.UI2.WinForms.Guna2GroupBox gpGerenciamento;
        private System.Windows.Forms.Label lblResultadoSituacao;
        private System.Windows.Forms.Label lblResultadoSalaDireita;
        private System.Windows.Forms.Label lblResultadoSalaEsquerda;
        private System.Windows.Forms.Label lblResultadoAndar;
        private Guna.UI2.WinForms.Guna2Button btnAlugar;
        private System.Windows.Forms.Label lblAlugarArmario;
        private System.Windows.Forms.Label lblResultadoCor;
        private Guna.UI2.WinForms.Guna2CircleButton btnDisponibilidade;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblSalaDireita;
        private System.Windows.Forms.Label lblSalaEsquerda;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAndar;
        private RJTextBox txtRaAluno;
        private RJTextBox txtNumeroArmario;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbPossuiApm;
        private System.Windows.Forms.Label lblPossuiApm;
        private System.Windows.Forms.Label lblDadosArmario;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanelImgPerfil;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button btnAlterarSenha;
        private Guna.UI2.WinForms.Guna2Button btnTrocarPerfil;
        private Guna.UI2.WinForms.Guna2Button btnFecharAplicativo;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnProcurar;
    }
}