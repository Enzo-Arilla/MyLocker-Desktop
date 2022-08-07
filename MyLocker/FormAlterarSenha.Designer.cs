
namespace MyLocker
{
    partial class FormAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarSenha));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblApm = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblArmarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpGerenciamento = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnGerenciar = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmarSenha = new MyLocker.RJTextBox();
            this.txtNovaSenha = new MyLocker.RJTextBox();
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.txtSenhaAntiga = new MyLocker.RJTextBox();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDesocuparArmario = new Guna.UI2.WinForms.Guna2Button();
            this.btnDadosArmarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlugarAmario = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGerenciarAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.btnDadosAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.btnSenha = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterarFoto = new Guna.UI2.WinForms.Guna2Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnTrocarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFecharAplicativo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.gpGerenciamento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(805, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 76);
            this.label1.TabIndex = 14;
            // 
            // gpGerenciamento
            // 
            this.gpGerenciamento.BorderColor = System.Drawing.Color.White;
            this.gpGerenciamento.BorderRadius = 10;
            this.gpGerenciamento.Controls.Add(this.btnGerenciar);
            this.gpGerenciamento.Controls.Add(this.txtConfirmarSenha);
            this.gpGerenciamento.Controls.Add(this.txtNovaSenha);
            this.gpGerenciamento.Controls.Add(this.lblEsqueceuSenha);
            this.gpGerenciamento.Controls.Add(this.txtSenhaAntiga);
            this.gpGerenciamento.Controls.Add(this.lblAlterarSenha);
            this.gpGerenciamento.CustomBorderColor = System.Drawing.Color.White;
            this.gpGerenciamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpGerenciamento.ForeColor = System.Drawing.Color.White;
            this.gpGerenciamento.Location = new System.Drawing.Point(325, 233);
            this.gpGerenciamento.Name = "gpGerenciamento";
            this.gpGerenciamento.Size = new System.Drawing.Size(1300, 800);
            this.gpGerenciamento.TabIndex = 15;
            this.gpGerenciamento.Text = "guna2GroupBox1";
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGerenciar.BackColor = System.Drawing.Color.Transparent;
            this.btnGerenciar.BorderRadius = 20;
            this.btnGerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnGerenciar.ForeColor = System.Drawing.Color.Black;
            this.btnGerenciar.Location = new System.Drawing.Point(334, 632);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnGerenciar.ShadowDecoration.Enabled = true;
            this.btnGerenciar.Size = new System.Drawing.Size(683, 87);
            this.btnGerenciar.TabIndex = 52;
            this.btnGerenciar.Text = "Confirmar";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtConfirmarSenha.BorderColor = System.Drawing.Color.Transparent;
            this.txtConfirmarSenha.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtConfirmarSenha.BorderRadius = 50;
            this.txtConfirmarSenha.BorderSize = 2;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(307, 496);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtConfirmarSenha.Multiline = false;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtConfirmarSenha.PasswordChar = false;
            this.txtConfirmarSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtConfirmarSenha.PlaceholderText = "Confirmar nova senha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(750, 109);
            this.txtConfirmarSenha.TabIndex = 35;
            this.txtConfirmarSenha.UnderlinedStyle = false;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtNovaSenha.BorderColor = System.Drawing.Color.Transparent;
            this.txtNovaSenha.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNovaSenha.BorderRadius = 50;
            this.txtNovaSenha.BorderSize = 2;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNovaSenha.Location = new System.Drawing.Point(307, 372);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtNovaSenha.Multiline = false;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtNovaSenha.PasswordChar = false;
            this.txtNovaSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtNovaSenha.PlaceholderText = "Nova senha";
            this.txtNovaSenha.Size = new System.Drawing.Size(750, 109);
            this.txtNovaSenha.TabIndex = 34;
            this.txtNovaSenha.UnderlinedStyle = false;
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.BackColor = System.Drawing.Color.White;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(326, 305);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(326, 45);
            this.lblEsqueceuSenha.TabIndex = 33;
            this.lblEsqueceuSenha.Text = "Esqueceu sua senha?";
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtSenhaAntiga.BorderColor = System.Drawing.Color.Transparent;
            this.txtSenhaAntiga.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSenhaAntiga.BorderRadius = 50;
            this.txtSenhaAntiga.BorderSize = 2;
            this.txtSenhaAntiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAntiga.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSenhaAntiga.Location = new System.Drawing.Point(307, 187);
            this.txtSenhaAntiga.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtSenhaAntiga.Multiline = false;
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtSenhaAntiga.PasswordChar = false;
            this.txtSenhaAntiga.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtSenhaAntiga.PlaceholderText = "Senha antiga";
            this.txtSenhaAntiga.Size = new System.Drawing.Size(750, 109);
            this.txtSenhaAntiga.TabIndex = 32;
            this.txtSenhaAntiga.UnderlinedStyle = false;
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AllowDrop = true;
            this.lblAlterarSenha.AutoEllipsis = true;
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.ForeColor = System.Drawing.Color.Black;
            this.lblAlterarSenha.Location = new System.Drawing.Point(519, 86);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(349, 61);
            this.lblAlterarSenha.TabIndex = 16;
            this.lblAlterarSenha.Text = "Alterar Senha";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnDesocuparArmario);
            this.panel2.Controls.Add(this.btnDadosArmarios);
            this.panel2.Controls.Add(this.btnAlugarAmario);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 254);
            this.panel2.TabIndex = 53;
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
            this.btnDesocuparArmario.BackColor = System.Drawing.Color.Transparent;
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
            this.btnDesocuparArmario.ShadowDecoration.BorderRadius = 20;
            this.btnDesocuparArmario.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnDesocuparArmario.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btnDesocuparArmario.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.btnDesocuparArmario.ShadowDecoration.Depth = 100;
            this.btnDesocuparArmario.ShadowDecoration.Enabled = true;
            this.btnDesocuparArmario.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20, 0, 0, 2);
            this.btnDesocuparArmario.Size = new System.Drawing.Size(397, 88);
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
            // btnAlugarAmario
            // 
            this.btnAlugarAmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnAlugarAmario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlugarAmario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugarAmario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugarAmario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlugarAmario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlugarAmario.FillColor = System.Drawing.Color.White;
            this.btnAlugarAmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnAlugarAmario.ForeColor = System.Drawing.Color.Black;
            this.btnAlugarAmario.Location = new System.Drawing.Point(0, 0);
            this.btnAlugarAmario.Name = "btnAlugarAmario";
            this.btnAlugarAmario.Size = new System.Drawing.Size(397, 86);
            this.btnAlugarAmario.TabIndex = 5;
            this.btnAlugarAmario.Text = "Alugar um Armário";
            this.btnAlugarAmario.Click += new System.EventHandler(this.btnAlugarAmario_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.btnGerenciarAlunos);
            this.panel7.Controls.Add(this.btnDadosAlunos);
            this.panel7.Location = new System.Drawing.Point(288, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 169);
            this.panel7.TabIndex = 55;
            this.panel7.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 2);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            // 
            // btnGerenciarAlunos
            // 
            this.btnGerenciarAlunos.BackColor = System.Drawing.Color.Transparent;
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
            this.btnGerenciarAlunos.Location = new System.Drawing.Point(0, 84);
            this.btnGerenciarAlunos.Name = "btnGerenciarAlunos";
            this.btnGerenciarAlunos.ShadowDecoration.BorderRadius = 20;
            this.btnGerenciarAlunos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnGerenciarAlunos.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btnGerenciarAlunos.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.btnGerenciarAlunos.ShadowDecoration.Depth = 100;
            this.btnGerenciarAlunos.ShadowDecoration.Enabled = true;
            this.btnGerenciarAlunos.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnGerenciarAlunos.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGerenciarAlunos.Size = new System.Drawing.Size(397, 88);
            this.btnGerenciarAlunos.TabIndex = 7;
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
            this.btnDadosAlunos.Size = new System.Drawing.Size(397, 88);
            this.btnDadosAlunos.TabIndex = 5;
            this.btnDadosAlunos.Text = "Dados dos Alunos";
            this.btnDadosAlunos.Click += new System.EventHandler(this.btnDadosAlunos_Click);
            // 
            // btnSenha
            // 
            this.btnSenha.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSenha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSenha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSenha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnSenha.ForeColor = System.Drawing.Color.Black;
            this.btnSenha.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnSenha.Location = new System.Drawing.Point(0, 0);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(397, 86);
            this.btnSenha.TabIndex = 5;
            this.btnSenha.Text = "Alterar Senha";
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(0, 83);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(397, 2);
            this.panel9.TabIndex = 8;
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(0, 166);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(397, 2);
            this.panel8.TabIndex = 9;
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.btnFecharAplicativo);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.btnTrocarPerfil);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.btnAlterarFoto);
            this.panel3.Controls.Add(this.btnSenha);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1043, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 339);
            this.panel3.TabIndex = 54;
            this.panel3.Visible = false;
            // 
            // btnFecharAplicativo
            // 
            this.btnFecharAplicativo.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharAplicativo.BorderColor = System.Drawing.Color.Transparent;
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
            this.btnFecharAplicativo.Font = new System.Drawing.Font("Roboto", 26.25F);
            this.btnFecharAplicativo.ForeColor = System.Drawing.Color.Black;
            this.btnFecharAplicativo.Location = new System.Drawing.Point(-1, 253);
            this.btnFecharAplicativo.Name = "btnFecharAplicativo";
            this.btnFecharAplicativo.ShadowDecoration.BorderRadius = 20;
            this.btnFecharAplicativo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnFecharAplicativo.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btnFecharAplicativo.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.btnFecharAplicativo.ShadowDecoration.Depth = 100;
            this.btnFecharAplicativo.ShadowDecoration.Enabled = true;
            this.btnFecharAplicativo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 20, 2);
            this.btnFecharAplicativo.Size = new System.Drawing.Size(398, 86);
            this.btnFecharAplicativo.TabIndex = 7;
            this.btnFecharAplicativo.Text = "Fechar Aplicativo";
            this.btnFecharAplicativo.UseTransparentBackground = true;
            this.btnFecharAplicativo.Click += new System.EventHandler(this.btnFecharAplicativo_Click);
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpGerenciamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterarSenha";
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.gpGerenciamento.ResumeLayout(false);
            this.gpGerenciamento.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgPerfil;
        private System.Windows.Forms.Label lblApm;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblArmarios;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox gpGerenciamento;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.Label lblEsqueceuSenha;
        private RJTextBox txtSenhaAntiga;
        private RJTextBox txtConfirmarSenha;
        private RJTextBox txtNovaSenha;
        private Guna.UI2.WinForms.Guna2Button btnGerenciar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnDesocuparArmario;
        private Guna.UI2.WinForms.Guna2Button btnDadosArmarios;
        private Guna.UI2.WinForms.Guna2Button btnAlugarAmario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnGerenciarAlunos;
        private Guna.UI2.WinForms.Guna2Button btnDadosAlunos;
        private Guna.UI2.WinForms.Guna2Button btnSenha;
        private Guna.UI2.WinForms.Guna2Button btnAlterarFoto;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2Button btnTrocarPerfil;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnFecharAplicativo;
    }
}