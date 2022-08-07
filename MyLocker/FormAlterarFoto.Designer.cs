
namespace MyLocker
{
    partial class FormAlterarFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarFoto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblApm = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblArmarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.imgPerfil2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnEscolherImagem = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.lblTrocarFotoPerfil = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDesocuparArmario = new Guna.UI2.WinForms.Guna2Button();
            this.btnDadosArmarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlugarArmario = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnTrocarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnFecharAplicativo = new Guna.UI2.WinForms.Guna2Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAlterarFoto = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterarSenha = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGerenciarAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.btnDadosAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
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
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.imgPerfil2);
            this.guna2GroupBox1.Controls.Add(this.btnEscolherImagem);
            this.guna2GroupBox1.Controls.Add(this.btnConfirmar);
            this.guna2GroupBox1.Controls.Add(this.lblTrocarFotoPerfil);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(325, 233);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1300, 800);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // imgPerfil2
            // 
            this.imgPerfil2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPerfil2.BackColor = System.Drawing.Color.Transparent;
            this.imgPerfil2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imgPerfil2.Image = ((System.Drawing.Image)(resources.GetObject("imgPerfil2.Image")));
            this.imgPerfil2.ImageRotate = 0F;
            this.imgPerfil2.Location = new System.Drawing.Point(533, 216);
            this.imgPerfil2.Name = "imgPerfil2";
            this.imgPerfil2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgPerfil2.Size = new System.Drawing.Size(253, 244);
            this.imgPerfil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil2.TabIndex = 54;
            this.imgPerfil2.TabStop = false;
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnEscolherImagem.BorderRadius = 10;
            this.btnEscolherImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolherImagem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEscolherImagem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEscolherImagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEscolherImagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEscolherImagem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEscolherImagem.Font = new System.Drawing.Font("Roboto", 20F);
            this.btnEscolherImagem.ForeColor = System.Drawing.Color.Black;
            this.btnEscolherImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolherImagem.Image")));
            this.btnEscolherImagem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEscolherImagem.ImageOffset = new System.Drawing.Point(0, 27);
            this.btnEscolherImagem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEscolherImagem.Location = new System.Drawing.Point(477, 506);
            this.btnEscolherImagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 50);
            this.btnEscolherImagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEscolherImagem.Size = new System.Drawing.Size(365, 84);
            this.btnEscolherImagem.TabIndex = 53;
            this.btnEscolherImagem.Text = "Escolher nova imagem";
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmar.BorderRadius = 20;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(424, 625);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(470, 87);
            this.btnConfirmar.TabIndex = 52;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTrocarFotoPerfil
            // 
            this.lblTrocarFotoPerfil.AllowDrop = true;
            this.lblTrocarFotoPerfil.AutoEllipsis = true;
            this.lblTrocarFotoPerfil.AutoSize = true;
            this.lblTrocarFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblTrocarFotoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocarFotoPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblTrocarFotoPerfil.Location = new System.Drawing.Point(406, 86);
            this.lblTrocarFotoPerfil.Name = "lblTrocarFotoPerfil";
            this.lblTrocarFotoPerfil.Size = new System.Drawing.Size(508, 61);
            this.lblTrocarFotoPerfil.TabIndex = 16;
            this.lblTrocarFotoPerfil.Text = "Trocar Foto de Perfil";
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.btnTrocarPerfil);
            this.panel3.Controls.Add(this.btnFecharAplicativo);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.btnAlterarFoto);
            this.panel3.Controls.Add(this.btnAlterarSenha);
            this.panel3.Location = new System.Drawing.Point(1043, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 345);
            this.panel3.TabIndex = 54;
            this.panel3.Visible = false;
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(0, 166);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(397, 2);
            this.panel8.TabIndex = 9;
            this.panel8.Visible = false;
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
            this.btnFecharAplicativo.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharAplicativo.BorderRadius = 20;
            this.btnFecharAplicativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharAplicativo.CustomizableEdges.BottomRight = false;
            this.btnFecharAplicativo.CustomizableEdges.TopLeft = false;
            this.btnFecharAplicativo.CustomizableEdges.TopRight = false;
            this.btnFecharAplicativo.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFecharAplicativo.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFecharAplicativo.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnFecharAplicativo.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnFecharAplicativo.FillColor = System.Drawing.Color.White;
            this.btnFecharAplicativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F);
            this.btnFecharAplicativo.ForeColor = System.Drawing.Color.Black;
            this.btnFecharAplicativo.ImageSize = new System.Drawing.Size(0, 0);
            this.btnFecharAplicativo.Location = new System.Drawing.Point(0, 254);
            this.btnFecharAplicativo.Name = "btnFecharAplicativo";
            this.btnFecharAplicativo.Size = new System.Drawing.Size(397, 86);
            this.btnFecharAplicativo.TabIndex = 10;
            this.btnFecharAplicativo.Text = "Fechar Aplicativo";
            this.btnFecharAplicativo.Click += new System.EventHandler(this.btnFecharAplicativo_Click);
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
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAlterarFoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterarFoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterarFoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterarFoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlterarFoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnAlterarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnAlterarFoto.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarFoto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnAlterarFoto.Location = new System.Drawing.Point(0, 83);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(397, 86);
            this.btnAlterarFoto.TabIndex = 6;
            this.btnAlterarFoto.Text = "Alterar Foto";
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
            // panel7
            // 
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.btnGerenciarAlunos);
            this.panel7.Controls.Add(this.btnDadosAlunos);
            this.panel7.Location = new System.Drawing.Point(288, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 167);
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
            this.btnDadosAlunos.Location = new System.Drawing.Point(0, 1);
            this.btnDadosAlunos.Name = "btnDadosAlunos";
            this.btnDadosAlunos.Size = new System.Drawing.Size(397, 86);
            this.btnDadosAlunos.TabIndex = 5;
            this.btnDadosAlunos.Text = "Dados dos Alunos";
            this.btnDadosAlunos.Click += new System.EventHandler(this.btnDadosAlunos_Click);
            // 
            // FormAlterarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterarFoto";
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblTrocarFotoPerfil;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnDesocuparArmario;
        private Guna.UI2.WinForms.Guna2Button btnDadosArmarios;
        private Guna.UI2.WinForms.Guna2Button btnAlugarArmario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button btnTrocarPerfil;
        private Guna.UI2.WinForms.Guna2Button btnFecharAplicativo;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2Button btnAlterarFoto;
        private Guna.UI2.WinForms.Guna2Button btnAlterarSenha;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnGerenciarAlunos;
        private Guna.UI2.WinForms.Guna2Button btnDadosAlunos;
        private Guna.UI2.WinForms.Guna2TileButton btnEscolherImagem;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgPerfil2;
    }
}