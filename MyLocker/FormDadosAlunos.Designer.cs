
namespace MyLocker
{
    partial class FormDadosAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDadosAlunos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblApm = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblArmarios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDesocuparArmario = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDadosArmarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlugarArmario = new Guna.UI2.WinForms.Guna2Button();
            this.btnTipoPesquisa = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.tblDadosAlunos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnDadosAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGerenciarAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanelImgPerfil = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAlterarSenha = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrocarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnFecharAplicativo = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnRaLocatario = new Guna.UI2.WinForms.Guna2Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnNumero = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatusApm = new Guna.UI2.WinForms.Guna2Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSobrenome = new Guna.UI2.WinForms.Guna2Button();
            this.btnNome = new Guna.UI2.WinForms.Guna2Button();
            this.lblFoco = new System.Windows.Forms.Label();
            this.txtPesquisarArmario = new MyLocker.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDadosAlunos)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanelImgPerfil.SuspendLayout();
            this.panel10.SuspendLayout();
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
            this.imgPerfil.TabIndex = 38;
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
            this.lblAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
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
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 1);
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
            this.panel3.Size = new System.Drawing.Size(397, 1);
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
            // btnTipoPesquisa
            // 
            this.btnTipoPesquisa.BorderRadius = 35;
            this.btnTipoPesquisa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTipoPesquisa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTipoPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTipoPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTipoPesquisa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.btnTipoPesquisa.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnTipoPesquisa.Location = new System.Drawing.Point(133, 214);
            this.btnTipoPesquisa.Name = "btnTipoPesquisa";
            this.btnTipoPesquisa.Size = new System.Drawing.Size(354, 75);
            this.btnTipoPesquisa.TabIndex = 12;
            this.btnTipoPesquisa.Text = "Tipo de Pesquisa";
            this.btnTipoPesquisa.Click += new System.EventHandler(this.btnTipoPesquisa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1445, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 50;
            this.guna2GradientPanel1.Controls.Add(this.guna2VScrollBar2);
            this.guna2GradientPanel1.Controls.Add(this.tblDadosAlunos);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(485, 343);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(809, 670);
            this.guna2GradientPanel1.TabIndex = 63;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.BindingContainer = this.tblDadosAlunos;
            this.guna2VScrollBar2.BorderRadius = 3;
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(766, 24);
            this.guna2VScrollBar2.Minimum = 1;
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.ScrollbarSize = 18;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(18, 615);
            this.guna2VScrollBar2.TabIndex = 57;
            this.guna2VScrollBar2.Value = 1;
            // 
            // tblDadosAlunos
            // 
            this.tblDadosAlunos.AllowUserToAddRows = false;
            this.tblDadosAlunos.AllowUserToDeleteRows = false;
            this.tblDadosAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.tblDadosAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.tblDadosAlunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblDadosAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDadosAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.tblDadosAlunos.ColumnHeadersHeight = 50;
            this.tblDadosAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblDadosAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ra,
            this.Nome,
            this.Sobrenome,
            this.Numero,
            this.status});
            this.tblDadosAlunos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDadosAlunos.DefaultCellStyle = dataGridViewCellStyle29;
            this.tblDadosAlunos.GridColor = System.Drawing.Color.Black;
            this.tblDadosAlunos.Location = new System.Drawing.Point(25, 24);
            this.tblDadosAlunos.MultiSelect = false;
            this.tblDadosAlunos.Name = "tblDadosAlunos";
            this.tblDadosAlunos.ReadOnly = true;
            this.tblDadosAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDadosAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.tblDadosAlunos.RowHeadersVisible = false;
            this.tblDadosAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblDadosAlunos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tblDadosAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblDadosAlunos.Size = new System.Drawing.Size(759, 615);
            this.tblDadosAlunos.TabIndex = 56;
            this.tblDadosAlunos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblDadosAlunos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblDadosAlunos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblDadosAlunos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblDadosAlunos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblDadosAlunos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblDadosAlunos.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.tblDadosAlunos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.tblDadosAlunos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblDadosAlunos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDadosAlunos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.tblDadosAlunos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblDadosAlunos.ThemeStyle.HeaderStyle.Height = 50;
            this.tblDadosAlunos.ThemeStyle.ReadOnly = true;
            this.tblDadosAlunos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.tblDadosAlunos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblDadosAlunos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tblDadosAlunos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblDadosAlunos.ThemeStyle.RowsStyle.Height = 22;
            this.tblDadosAlunos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.tblDadosAlunos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ra
            // 
            this.ra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ra.DefaultCellStyle = dataGridViewCellStyle28;
            this.ra.HeaderText = "RA";
            this.ra.MinimumWidth = 130;
            this.ra.Name = "ra";
            this.ra.ReadOnly = true;
            this.ra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ra.Width = 130;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 130;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 130;
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.MinimumWidth = 130;
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            this.Sobrenome.Width = 186;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Numero.HeaderText = "Número";
            this.Numero.MinimumWidth = 130;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 142;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.HeaderText = "Status ";
            this.status.MinimumWidth = 130;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 130;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.Controls.Add(this.btnDadosAlunos);
            this.guna2GradientPanel2.Controls.Add(this.panel4);
            this.guna2GradientPanel2.Controls.Add(this.btnGerenciarAlunos);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(288, 113);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(397, 167);
            this.guna2GradientPanel2.TabIndex = 64;
            this.guna2GradientPanel2.UseTransparentBackground = true;
            this.guna2GradientPanel2.Visible = false;
            // 
            // btnDadosAlunos
            // 
            this.btnDadosAlunos.Cursor = System.Windows.Forms.Cursors.No;
            this.btnDadosAlunos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDadosAlunos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDadosAlunos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDadosAlunos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDadosAlunos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnDadosAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnDadosAlunos.ForeColor = System.Drawing.Color.Black;
            this.btnDadosAlunos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnDadosAlunos.Location = new System.Drawing.Point(0, -1);
            this.btnDadosAlunos.Name = "btnDadosAlunos";
            this.btnDadosAlunos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnDadosAlunos.Size = new System.Drawing.Size(397, 86);
            this.btnDadosAlunos.TabIndex = 5;
            this.btnDadosAlunos.Text = "Dados dos Alunos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 1);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            // 
            // btnGerenciarAlunos
            // 
            this.btnGerenciarAlunos.BackColor = System.Drawing.Color.Transparent;
            this.btnGerenciarAlunos.BorderColor = System.Drawing.Color.Transparent;
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
            this.btnGerenciarAlunos.UseTransparentBackground = true;
            this.btnGerenciarAlunos.Click += new System.EventHandler(this.btnGerenciarAlunos_Click);
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
            this.guna2GradientPanelImgPerfil.TabIndex = 66;
            this.guna2GradientPanelImgPerfil.UseTransparentBackground = true;
            this.guna2GradientPanelImgPerfil.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(2, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(397, 1);
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
            this.btnAlterarSenha.Location = new System.Drawing.Point(2, 3);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(397, 86);
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
            this.btnTrocarPerfil.Location = new System.Drawing.Point(2, 91);
            this.btnTrocarPerfil.Name = "btnTrocarPerfil";
            this.btnTrocarPerfil.Size = new System.Drawing.Size(397, 89);
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
            this.btnFecharAplicativo.Location = new System.Drawing.Point(2, 182);
            this.btnFecharAplicativo.Name = "btnFecharAplicativo";
            this.btnFecharAplicativo.Size = new System.Drawing.Size(397, 86);
            this.btnFecharAplicativo.TabIndex = 66;
            this.btnFecharAplicativo.Text = "Fechar Aplicativo";
            this.btnFecharAplicativo.Click += new System.EventHandler(this.btnFecharAplicativo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(2, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 1);
            this.panel6.TabIndex = 12;
            this.panel6.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel15);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.btnRaLocatario);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.btnNumero);
            this.panel10.Controls.Add(this.btnStatusApm);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.btnSobrenome);
            this.panel10.Controls.Add(this.btnNome);
            this.panel10.Location = new System.Drawing.Point(110, 330);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(397, 430);
            this.panel10.TabIndex = 67;
            this.panel10.Visible = false;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Black;
            this.panel15.Location = new System.Drawing.Point(-1, 85);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(397, 2);
            this.panel15.TabIndex = 57;
            this.panel15.Visible = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(0, 340);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(397, 2);
            this.panel12.TabIndex = 11;
            this.panel12.Visible = false;
            // 
            // btnRaLocatario
            // 
            this.btnRaLocatario.BorderRadius = 20;
            this.btnRaLocatario.Cursor = System.Windows.Forms.Cursors.No;
            this.btnRaLocatario.CustomizableEdges.BottomLeft = false;
            this.btnRaLocatario.CustomizableEdges.BottomRight = false;
            this.btnRaLocatario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRaLocatario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRaLocatario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnRaLocatario.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnRaLocatario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnRaLocatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnRaLocatario.ForeColor = System.Drawing.Color.Black;
            this.btnRaLocatario.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnRaLocatario.Location = new System.Drawing.Point(0, 1);
            this.btnRaLocatario.Name = "btnRaLocatario";
            this.btnRaLocatario.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(81)))));
            this.btnRaLocatario.Size = new System.Drawing.Size(397, 86);
            this.btnRaLocatario.TabIndex = 56;
            this.btnRaLocatario.Text = "RA Locatário";
            this.btnRaLocatario.Click += new System.EventHandler(this.btnRaLocatario_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(0, 254);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(397, 2);
            this.panel13.TabIndex = 9;
            this.panel13.Visible = false;
            // 
            // btnNumero
            // 
            this.btnNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumero.FillColor = System.Drawing.Color.LightGray;
            this.btnNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F);
            this.btnNumero.ForeColor = System.Drawing.Color.Black;
            this.btnNumero.Location = new System.Drawing.Point(0, 254);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(397, 86);
            this.btnNumero.TabIndex = 7;
            this.btnNumero.Text = "Número";
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnStatusApm
            // 
            this.btnStatusApm.BorderRadius = 20;
            this.btnStatusApm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatusApm.CustomizableEdges.TopLeft = false;
            this.btnStatusApm.CustomizableEdges.TopRight = false;
            this.btnStatusApm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatusApm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatusApm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatusApm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatusApm.FillColor = System.Drawing.Color.LightGray;
            this.btnStatusApm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F);
            this.btnStatusApm.ForeColor = System.Drawing.Color.Black;
            this.btnStatusApm.Location = new System.Drawing.Point(0, 342);
            this.btnStatusApm.Name = "btnStatusApm";
            this.btnStatusApm.Size = new System.Drawing.Size(397, 86);
            this.btnStatusApm.TabIndex = 10;
            this.btnStatusApm.Text = "Status APM";
            this.btnStatusApm.Click += new System.EventHandler(this.btnStatusApm_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(0, 171);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(397, 2);
            this.panel14.TabIndex = 8;
            this.panel14.Visible = false;
            // 
            // btnSobrenome
            // 
            this.btnSobrenome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobrenome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSobrenome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSobrenome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSobrenome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSobrenome.FillColor = System.Drawing.Color.LightGray;
            this.btnSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnSobrenome.ForeColor = System.Drawing.Color.Black;
            this.btnSobrenome.Location = new System.Drawing.Point(0, 171);
            this.btnSobrenome.Name = "btnSobrenome";
            this.btnSobrenome.Size = new System.Drawing.Size(397, 86);
            this.btnSobrenome.TabIndex = 6;
            this.btnSobrenome.Text = "Sobrenome";
            this.btnSobrenome.Click += new System.EventHandler(this.btnSobrenome_Click);
            // 
            // btnNome
            // 
            this.btnNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNome.FillColor = System.Drawing.Color.LightGray;
            this.btnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F);
            this.btnNome.ForeColor = System.Drawing.Color.Black;
            this.btnNome.Location = new System.Drawing.Point(0, 87);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(397, 86);
            this.btnNome.TabIndex = 5;
            this.btnNome.Text = "Nome";
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // lblFoco
            // 
            this.lblFoco.AutoSize = true;
            this.lblFoco.Location = new System.Drawing.Point(723, 161);
            this.lblFoco.Name = "lblFoco";
            this.lblFoco.Size = new System.Drawing.Size(0, 13);
            this.lblFoco.TabIndex = 68;
            this.lblFoco.Visible = false;
            // 
            // txtPesquisarArmario
            // 
            this.txtPesquisarArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtPesquisarArmario.BorderColor = System.Drawing.Color.Transparent;
            this.txtPesquisarArmario.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPesquisarArmario.BorderRadius = 50;
            this.txtPesquisarArmario.BorderSize = 2;
            this.txtPesquisarArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarArmario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPesquisarArmario.Location = new System.Drawing.Point(630, 197);
            this.txtPesquisarArmario.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtPesquisarArmario.Multiline = false;
            this.txtPesquisarArmario.Name = "txtPesquisarArmario";
            this.txtPesquisarArmario.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtPesquisarArmario.PasswordChar = false;
            this.txtPesquisarArmario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (RA Locatário)";
            this.txtPesquisarArmario.Size = new System.Drawing.Size(1000, 106);
            this.txtPesquisarArmario.TabIndex = 32;
            this.txtPesquisarArmario.UnderlinedStyle = false;
            this.txtPesquisarArmario.Enter += new System.EventHandler(this.txtPesquisarArmario_Enter);
            this.txtPesquisarArmario.Leave += new System.EventHandler(this.txtPesquisarArmario_Leave);
            // 
            // FormDadosAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.lblFoco);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.guna2GradientPanelImgPerfil);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.txtPesquisarArmario);
            this.Controls.Add(this.btnTipoPesquisa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDadosAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDadosArmarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblDadosAlunos)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanelImgPerfil.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApm;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblArmarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnDesocuparArmario;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnDadosArmarios;
        private Guna.UI2.WinForms.Guna2Button btnAlugarArmario;
        private Guna.UI2.WinForms.Guna2Button btnTipoPesquisa;
        private RJTextBox txtPesquisarArmario;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView tblDadosAlunos;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnDadosAlunos;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnGerenciarAlunos;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanelImgPerfil;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button btnAlterarSenha;
        private Guna.UI2.WinForms.Guna2Button btnTrocarPerfil;
        private Guna.UI2.WinForms.Guna2Button btnFecharAplicativo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel12;
        private Guna.UI2.WinForms.Guna2Button btnRaLocatario;
        private System.Windows.Forms.Panel panel13;
        private Guna.UI2.WinForms.Guna2Button btnNumero;
        private Guna.UI2.WinForms.Guna2Button btnStatusApm;
        private System.Windows.Forms.Panel panel14;
        private Guna.UI2.WinForms.Guna2Button btnSobrenome;
        private Guna.UI2.WinForms.Guna2Button btnNome;
        private System.Windows.Forms.Label lblFoco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}