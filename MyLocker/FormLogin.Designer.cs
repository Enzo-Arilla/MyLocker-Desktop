
namespace MyLocker
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.gbConjunto = new MyLocker.MyGroupBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.lblFoco = new System.Windows.Forms.Label();
            this.txtSenha = new MyLocker.RJTextBox();
            this.txtCpf = new MyLocker.RJTextBox();
            this.lblCriarConta = new System.Windows.Forms.Label();
            this.lblIniciarSessao = new System.Windows.Forms.Label();
            this.imgPanel = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.gbConjunto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConjunto
            // 
            this.gbConjunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConjunto.BorderColor = System.Drawing.Color.Transparent;
            this.gbConjunto.Controls.Add(this.btnLogin);
            this.gbConjunto.Controls.Add(this.btnSair);
            this.gbConjunto.Controls.Add(this.lblFoco);
            this.gbConjunto.Controls.Add(this.txtSenha);
            this.gbConjunto.Controls.Add(this.txtCpf);
            this.gbConjunto.Controls.Add(this.lblCriarConta);
            this.gbConjunto.Controls.Add(this.lblIniciarSessao);
            this.gbConjunto.Controls.Add(this.imgPanel);
            this.gbConjunto.Controls.Add(this.imgLogo);
            this.gbConjunto.Location = new System.Drawing.Point(0, 0);
            this.gbConjunto.Name = "gbConjunto";
            this.gbConjunto.Size = new System.Drawing.Size(1440, 878);
            this.gbConjunto.TabIndex = 0;
            this.gbConjunto.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(831, 875);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(275, 87);
            this.btnLogin.TabIndex = 51;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1202, 70);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 94);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 34;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblFoco
            // 
            this.lblFoco.AutoSize = true;
            this.lblFoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoco.Location = new System.Drawing.Point(203, 609);
            this.lblFoco.Name = "lblFoco";
            this.lblFoco.Size = new System.Drawing.Size(0, 51);
            this.lblFoco.TabIndex = 17;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderColor = System.Drawing.Color.Transparent;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSenha.BorderRadius = 15;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.LightGray;
            this.txtSenha.Location = new System.Drawing.Point(368, 720);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(30);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.Size = new System.Drawing.Size(741, 119);
            this.txtSenha.TabIndex = 16;
            this.txtSenha.UnderlinedStyle = false;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCpf.BackColor = System.Drawing.SystemColors.Window;
            this.txtCpf.BorderColor = System.Drawing.Color.Transparent;
            this.txtCpf.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtCpf.BorderRadius = 15;
            this.txtCpf.BorderSize = 2;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Silver;
            this.txtCpf.Location = new System.Drawing.Point(368, 572);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtCpf.Multiline = false;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Padding = new System.Windows.Forms.Padding(30);
            this.txtCpf.PasswordChar = false;
            this.txtCpf.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtCpf.PlaceholderText = "CPF";
            this.txtCpf.Size = new System.Drawing.Size(741, 119);
            this.txtCpf.TabIndex = 15;
            this.txtCpf.UnderlinedStyle = false;
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            // 
            // lblCriarConta
            // 
            this.lblCriarConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCriarConta.AutoSize = true;
            this.lblCriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarConta.ForeColor = System.Drawing.Color.White;
            this.lblCriarConta.Location = new System.Drawing.Point(400, 891);
            this.lblCriarConta.Name = "lblCriarConta";
            this.lblCriarConta.Size = new System.Drawing.Size(284, 59);
            this.lblCriarConta.TabIndex = 11;
            this.lblCriarConta.Text = "Criar Conta";
            this.lblCriarConta.Click += new System.EventHandler(this.lblCriarConta_Click);
            // 
            // lblIniciarSessao
            // 
            this.lblIniciarSessao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIniciarSessao.AutoSize = true;
            this.lblIniciarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSessao.ForeColor = System.Drawing.Color.White;
            this.lblIniciarSessao.Location = new System.Drawing.Point(502, 456);
            this.lblIniciarSessao.Name = "lblIniciarSessao";
            this.lblIniciarSessao.Size = new System.Drawing.Size(451, 76);
            this.lblIniciarSessao.TabIndex = 3;
            this.lblIniciarSessao.Text = "Iniciar Sessão";
            // 
            // imgPanel
            // 
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgPanel.Image = ((System.Drawing.Image)(resources.GetObject("imgPanel.Image")));
            this.imgPanel.Location = new System.Drawing.Point(3, 387);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(1434, 49);
            this.imgPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPanel.TabIndex = 1;
            this.imgPanel.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(3, 16);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(1434, 371);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.gbConjunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyUp);
            this.gbConjunto.ResumeLayout(false);
            this.gbConjunto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgPanel;
        private System.Windows.Forms.Label lblIniciarSessao;
        private System.Windows.Forms.Label lblCriarConta;
        private MyGroupBox gbConjunto;
        private RJTextBox txtCpf;
        private RJTextBox txtSenha;
        private System.Windows.Forms.Label lblFoco;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}