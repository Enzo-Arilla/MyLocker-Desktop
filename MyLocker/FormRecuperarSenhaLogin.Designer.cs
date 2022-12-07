
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
            this.txtSenha1 = new MyLocker.RJTextBox();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnviar = new Guna.UI2.WinForms.Guna2Button();
            this.txtNovaSenha = new MyLocker.RJTextBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.lblFoco = new System.Windows.Forms.Label();
            this.txtCodigo = new MyLocker.RJTextBox();
            this.txtCpf = new MyLocker.RJTextBox();
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
            this.gbConjunto.Controls.Add(this.txtSenha1);
            this.gbConjunto.Controls.Add(this.btnConfirmar);
            this.gbConjunto.Controls.Add(this.btnEnviar);
            this.gbConjunto.Controls.Add(this.txtNovaSenha);
            this.gbConjunto.Controls.Add(this.btnSair);
            this.gbConjunto.Controls.Add(this.lblFoco);
            this.gbConjunto.Controls.Add(this.txtCodigo);
            this.gbConjunto.Controls.Add(this.txtCpf);
            this.gbConjunto.Controls.Add(this.lblIniciarSessao);
            this.gbConjunto.Controls.Add(this.imgPanel);
            this.gbConjunto.Controls.Add(this.imgLogo);
            this.gbConjunto.Location = new System.Drawing.Point(0, 0);
            this.gbConjunto.Name = "gbConjunto";
            this.gbConjunto.Size = new System.Drawing.Size(1440, 878);
            this.gbConjunto.TabIndex = 0;
            this.gbConjunto.TabStop = false;
            // 
            // txtSenha1
            // 
            this.txtSenha1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha1.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha1.BorderColor = System.Drawing.Color.Transparent;
            this.txtSenha1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSenha1.BorderRadius = 15;
            this.txtSenha1.BorderSize = 2;
            this.txtSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha1.ForeColor = System.Drawing.Color.LightGray;
            this.txtSenha1.Location = new System.Drawing.Point(320, 378);
            this.txtSenha1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtSenha1.Multiline = false;
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Padding = new System.Windows.Forms.Padding(30);
            this.txtSenha1.PasswordChar = true;
            this.txtSenha1.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtSenha1.PlaceholderText = "Senha";
            this.txtSenha1.Size = new System.Drawing.Size(741, 119);
            this.txtSenha1.TabIndex = 17;
            this.txtSenha1.UnderlinedStyle = false;
            this.txtSenha1.Visible = false;
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
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(605, 980);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(275, 87);
            this.btnConfirmar.TabIndex = 53;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar.BorderRadius = 20;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnviar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(602, 690);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(275, 87);
            this.btnEnviar.TabIndex = 51;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            this.txtNovaSenha.PasswordChar = false;
            this.txtNovaSenha.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtNovaSenha.PlaceholderText = "Nova senha";
            this.txtNovaSenha.Size = new System.Drawing.Size(741, 119);
            this.txtNovaSenha.TabIndex = 52;
            this.txtNovaSenha.UnderlinedStyle = false;
            this.txtNovaSenha.Visible = false;
            this.txtNovaSenha.Enter += new System.EventHandler(this.txtNovaSenha_Enter);
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
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtCodigo.PlaceholderText = "Código";
            this.txtCodigo.Size = new System.Drawing.Size(741, 119);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.UnderlinedStyle = false;
            this.txtCodigo.Visible = false;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
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
            this.txtCpf.Location = new System.Drawing.Point(368, 530);
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
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
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
        private RJTextBox txtCpf;
        private RJTextBox txtCodigo;
        private System.Windows.Forms.Label lblFoco;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2Button btnEnviar;
        private RJTextBox txtNovaSenha;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private RJTextBox txtSenha1;
    }
}