
namespace MyLocker
{
    partial class FormRecuperarSenhaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecuperarSenhaLogin));
            this.gbConjunto = new MyLocker.MyGroupBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtNovaSenha = new MyLocker.RJTextBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.lblFoco = new System.Windows.Forms.Label();
            this.txtCodigo = new MyLocker.RJTextBox();
            this.txtEmail = new MyLocker.RJTextBox();
            this.lblIniciarSessao = new System.Windows.Forms.Label();
            this.imgPanel = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
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
            this.gbConjunto.Controls.Add(this.guna2Button1);
            this.gbConjunto.Controls.Add(this.btnLogin);
            this.gbConjunto.Controls.Add(this.txtNovaSenha);
            this.gbConjunto.Controls.Add(this.btnSair);
            this.gbConjunto.Controls.Add(this.lblFoco);
            this.gbConjunto.Controls.Add(this.txtCodigo);
            this.gbConjunto.Controls.Add(this.txtEmail);
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
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(1135, 530);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(275, 87);
            this.btnLogin.TabIndex = 51;
            this.btnLogin.Text = "Confirmar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNovaSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtNovaSenha.BorderColor = System.Drawing.Color.Transparent;
            this.txtNovaSenha.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNovaSenha.BorderRadius = 15;
            this.txtNovaSenha.BorderSize = 2;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.ForeColor = System.Drawing.Color.LightGray;
            this.txtNovaSenha.Location = new System.Drawing.Point(368, 829);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtNovaSenha.Multiline = false;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Padding = new System.Windows.Forms.Padding(30);
            this.txtNovaSenha.PasswordChar = true;
            this.txtNovaSenha.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtNovaSenha.PlaceholderText = "Nova senha";
            this.txtNovaSenha.Size = new System.Drawing.Size(741, 119);
            this.txtNovaSenha.TabIndex = 52;
            this.txtNovaSenha.UnderlinedStyle = false;
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
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.Transparent;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtCodigo.BorderRadius = 15;
            this.txtCodigo.BorderSize = 2;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.LightGray;
            this.txtCodigo.Location = new System.Drawing.Point(368, 679);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(30);
            this.txtCodigo.PasswordChar = true;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtCodigo.PlaceholderText = "Código";
            this.txtCodigo.Size = new System.Drawing.Size(741, 119);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.UnderlinedStyle = false;
            this.txtCodigo.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(368, 530);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(30);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(741, 119);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Enter += new System.EventHandler(this.txtCpf_Enter);
            // 
            // lblIniciarSessao
            // 
            this.lblIniciarSessao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIniciarSessao.AutoSize = true;
            this.lblIniciarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSessao.ForeColor = System.Drawing.Color.White;
            this.lblIniciarSessao.Location = new System.Drawing.Point(458, 412);
            this.lblIniciarSessao.Name = "lblIniciarSessao";
            this.lblIniciarSessao.Size = new System.Drawing.Size(554, 76);
            this.lblIniciarSessao.TabIndex = 3;
            this.lblIniciarSessao.Text = "Recuperar Senha";
            // 
            // imgPanel
            // 
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgPanel.Image = ((System.Drawing.Image)(resources.GetObject("imgPanel.Image")));
            this.imgPanel.Location = new System.Drawing.Point(3, 326);
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
            this.imgLogo.Size = new System.Drawing.Size(1434, 310);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(605, 985);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(275, 87);
            this.guna2Button1.TabIndex = 53;
            this.guna2Button1.Text = "Confirmar";
            // 
            // FormRecuperarSenhaLogin
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
            this.Name = "FormRecuperarSenhaLogin";
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
        private MyGroupBox gbConjunto;
        private RJTextBox txtEmail;
        private RJTextBox txtCodigo;
        private System.Windows.Forms.Label lblFoco;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private RJTextBox txtNovaSenha;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}